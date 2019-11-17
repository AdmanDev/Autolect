using System;
using System.Windows;
using System.ComponentModel;

namespace Autolect
{
    public partial class LoadWidow : Window
    {
        //Variables
        private BackgroundWorker worker;
        private Action<BackgroundWorker> action;
 
        //Constructor
        public LoadWidow(Action<BackgroundWorker> _action)
        {
            InitializeComponent();

            action = _action;

            worker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (action != null)
                this.Close();

        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Update(e.ProgressPercentage);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            action?.Invoke(worker);
        }

        public void Update(int p)
        {
            this.LB_Participants.Content = p + " participant(s) chargé(s)"; ;
        }

        private void BT_Cancel_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }

       
    }
}
