using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Autolect
{
    public static class Global
    {
        //-------------------------------VARIABLES-------------------------------//
        public static MainWindow mainWindow;
        public static Mode mode;
        public static object[] args;
        public static List<string> participants = new List<string>();
        public static List<string> comments = new List<string>();

        //-------------------------------FUNCTIONS-------------------------------//

        //Load embed assembly
        public static Assembly LoadEmbedAssembly(object sender, ResolveEventArgs args)
        {
            string name = args.Name.Split(',')[0];
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Autolect" + ".Resources.dlls." + name + ".dll"))
            {
                byte[] assemblyData = new byte[stream.Length];

                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }

        //Show the list of participants in a TextBox
        public static void ShowParticipants(ListBox lb, Window window)
        {
            lb.Items.Clear();

            Action<BackgroundWorker> action = new Action<BackgroundWorker>((worker) =>
            {
                Label label;

                for (int i = 0; i < Global.participants.Count; i++)
                {
                    if (worker.CancellationPending)
                        return;


                    window.Dispatcher.Invoke(new Action(() =>
                    {
                        label = new Label() { Content = participants[i], Width = 384, HorizontalContentAlignment = HorizontalAlignment.Center };
                        label.MouseLeftButtonDown += Global.mainWindow.Participant_click;
                        label.ContextMenu = Global.mainWindow.CM_Participant;

                        if (comments.Count > 0)
                            label.ToolTip = comments[i];

                        lb.Items.Add(label);
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

    }
}
