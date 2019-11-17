using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Forms;
using Taramon.Exceller;

namespace Autolect
{
    public partial class AddExcel_Window : Window
    {
        //Variables
        private OpenFileDialog ofd;
        private const string fileType = "Fichier Excel|*.xls;*.xlsx";

        //Constructor
        public AddExcel_Window()
        {
            InitializeComponent();

            ofd = new OpenFileDialog()
            {
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = fileType,
                Title = "Ouvrir un fichier Excel...",
                Multiselect = false,
                Filter = fileType
            };
        }

        private void BT_Add_Click(object sender, RoutedEventArgs e)
        {
            string fill = this.TB_FilePath.Text;
            string sheet = this.TB_SheetName.Text;
            string startCell = this.TB_StartCell.Text;
            string endCell = this.TB_EndCell.Text;

            if (string.IsNullOrEmpty(fill) || string.IsNullOrEmpty(sheet) || string.IsNullOrEmpty(startCell) || string.IsNullOrEmpty(endCell))
                return;

            Action<BackgroundWorker> action = new Action<BackgroundWorker>((worker) =>
            {
                Global.mode = Mode.Normal;

                ExcelManager em = new ExcelManager();
                em.Open(fill);
                em.ActivateSheet(sheet);

                ArrayList data = em.GetRangeFormattedValues(startCell, endCell);

                Global.participants.Clear();
                Global.comments.Clear();

                int i = 0;
                foreach (string d in data)
                {
                    if (string.IsNullOrEmpty(d))
                        continue;

                    Global.participants.Add(d);

                    i++;
                    worker.ReportProgress(i);
                }

                em.Close();
            });

            this.Visibility = Visibility.Hidden;
            new LoadWidow(action).ShowDialog();
            Global.mainWindow.EditFinish(false);
            this.Close();
        }

        private void BT_ChooseFile_Click(object sender, RoutedEventArgs e)
        {
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TB_FilePath.Text = ofd.FileName;
            }
        }
    }
}
