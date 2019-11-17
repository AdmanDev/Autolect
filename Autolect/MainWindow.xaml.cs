using System;
using System.Windows;
using System.Windows.Controls;
using MyFunctions;

namespace Autolect
{
    public partial class MainWindow : Window
    {
        //Variables
        public ContextMenu CM_Participant = new ContextMenu();

        //Constructor
        public MainWindow()
        {
            AppDomain.CurrentDomain.AssemblyResolve += Global.LoadEmbedAssembly;
            Global.mainWindow = this;
            System.Windows.Forms.Application.EnableVisualStyles();

            InitializeComponent();

            CM_Participant = (ContextMenu)this.FindResource("CM_Partticipant");
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateManager.CheckUpdate();
        }

        #region participants list menu


        public void Participant_click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ShowParticipantComment((Label)sender);
        }

        private void BT_ShowParticipantComment_Click(object sender, RoutedEventArgs e)
        {
            ShowParticipantComment((Label)this.List_Participants.SelectedItem);
        }

        private void ShowParticipantComment(Label participant)
        {
            if(participant.ToolTip != null)
            {
                MessageBox.Show((string)participant.ToolTip, (string)participant.Content);
            }

        }

        private void BT_RemoveParticipant_Click(object sender, RoutedEventArgs e)
        {
            int index = this.List_Participants.SelectedIndex;

            this.List_Participants.Items.RemoveAt(index);
            Global.participants.RemoveAt(index);

            if (Global.comments.Count > 0)
                Global.comments.RemoveAt(index);

            ShowNuberOfParticipants();
        }

        #endregion

        public void ShowNuberOfParticipants()
        {
            this.Group_Participants.Header = "Liste de " + Global.participants.Count + " participants";
        }

        private void BT_SelectRandom_Click(object sender, RoutedEventArgs e)
        {
            if (Global.participants.Count > 0)
                new SelectRandom_Window().ShowDialog();
        }

        private void BT_Add_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            new AddManually_Window().Show();

        }


        private void BT_AddFromYoutube_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            new AddYoutube_Window().Show();
                
        }

        private void BT_AddFromExcel_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            new AddExcel_Window().Show();
        }

        private void BT_AddRandomNumbers_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            new AddRandomNumbers_Window().Show();
        }

        public void EditFinish(bool cencel)
        {
            if (!cencel)
                Global.ShowParticipants(this.List_Participants, this);

            this.Visibility = Visibility.Visible;
        }
 
    }
}
