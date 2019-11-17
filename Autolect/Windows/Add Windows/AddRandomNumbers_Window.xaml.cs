using System;
using System.Windows;

namespace Autolect
{
    public partial class AddRandomNumbers_Window : Window
    {
        public AddRandomNumbers_Window()
        {
            InitializeComponent();
        }

        private void BT_Validate_Click(object sender, RoutedEventArgs e)
        {
            Global.mode = Mode.RandomNumber;
            Global.args = new object[]
            {
                this.NUD_Min.Value,
                this.NUD_Max.Value
            };

            Global.participants = new System.Collections.Generic.List<string>()
            {
                "Random( " + this.NUD_Min.Value + ", " + this.NUD_Max.Value + " )"
            };

            Global.mainWindow.EditFinish(false);
            this.Close();
        }
    }
}
