using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace Autolect
{
    public partial class AddManually_Window : Window
    {
        //Variables
        private SaveFileDialog sfd;
        private OpenFileDialog ofd;
        private const string fileType = "txt";

        //Constructor
        public AddManually_Window()
        {
            InitializeComponent();

            sfd = new SaveFileDialog()
            {
                AddExtension = true,
                CheckPathExists = true,
                DefaultExt = fileType,
                Title = "Enregistrer sous...",
                Filter = "|*." + fileType
            };

            ofd = new OpenFileDialog()
            {
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = fileType,
                Title = "Ouvrir un fichier...",
                Multiselect = false,
                Filter = "|*." + fileType
            };


            ShowParticipants();  
        }

        private void BT_Add_Click(object sender, RoutedEventArgs e)
        {
            Global.participants.Clear();
            Global.comments.Clear();

            int count = this.TB_Participants.LineCount;

            Action<BackgroundWorker> action = new Action<BackgroundWorker>((worker) =>
            {
                for (int i = 0; i < count; i++)
                {
                    if (worker.CancellationPending)
                        return;

                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        if (!string.IsNullOrEmpty(this.TB_Participants.GetLineText(i)) && this.TB_Participants.GetLineText(i) != Environment.NewLine)
                            Global.participants.Add(this.TB_Participants.GetLineText(i).Replace(Environment.NewLine, ""));
                    }));

                    worker.ReportProgress(i);
                }

            });

            this.Visibility = Visibility.Hidden;
            new LoadWidow(action).ShowDialog();
            Global.mainWindow.EditFinish(false);
            this.Close();
        }

        //Show the list of participants in a TextBox
        private void ShowParticipants()
        {
            this.TB_Participants.Text = "";

            Action<BackgroundWorker> action = new Action<BackgroundWorker>((worker) =>
            {
                Global.mode = Mode.Normal;

                for (int i = 0; i < Global.participants.Count; i++)
                {
                    if (worker.CancellationPending)
                        return;


                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        if (this.TB_Participants.Text == "")
                            this.TB_Participants.Text = Global.participants[i];
                        else
                            this.TB_Participants.Text += Environment.NewLine + Global.participants[i];
                    }));

                    worker.ReportProgress(i + 1);
                }

            });

            window.Dispatcher.Invoke(new Action(() =>
            {
                new LoadWidow(action).ShowDialog();
            }));

            Global.mainWindow.ShowNuberOfParticipants();
        }

        private void BT_SaveFile_Click(object sender, RoutedEventArgs e)
        {
            string participants = this.TB_Participants.Text;

            if (string.IsNullOrEmpty(participants))
                return;

            if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, participants);
            }
        }

        private void BT_OpenFile_Click(object sender, RoutedEventArgs e)
        {
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string readFile = File.ReadAllText(ofd.FileName);

                if (!string.IsNullOrEmpty(readFile))
                    this.TB_Participants.Text = readFile;
            }
        }
    }
}
