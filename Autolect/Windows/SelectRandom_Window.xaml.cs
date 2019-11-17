using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Autolect
{
    public partial class SelectRandom_Window : Window
    {
        //Variables
        int minR, maxR;

        private int currentParticipantIndex;
        private int lastParticipantIndex;
        private readonly Random rnd;
        private const int maxDuration = 3000;
        private int curTime;
        private const int switchSpeed = 100;

        private Timer timer;

        //Constructor
        public SelectRandom_Window()
        {
            InitializeComponent();

            //Start the gif image
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@"pack://application:,,,/Resources/Images/Winner annim.gif");
            image.EndInit();
            ImageBehavior.SetAnimatedSource(img, image);

            //Initialize variables

            currentParticipantIndex = 0;
            curTime = 0;
            rnd = new Random();

            timer = new Timer() { Interval = switchSpeed };

            switch (Global.mode)
            {
                case Mode.Normal:
                    timer.Tick += Normal_TimerTick;
                    break;
                case Mode.RandomNumber:
                    timer.Tick += RandomNumber_TimerTick;
                    minR = Convert.ToInt32(Global.args[0]);
                    maxR = Convert.ToInt32(Global.args[1]);
                    break;

                default:
                    goto case Mode.Normal;
            }

            timer.Start();
        }

        private void Tick(string participent)
        {
            this.LB.Text = participent;
            this.LB.ToolTip = participent;

            //Stop animation
            if (curTime >= maxDuration)
            {
                this.timer.Stop();
                this.BT_Finish.Visibility = Visibility.Visible;
            }

            curTime += this.timer.Interval;
        }

        private void Normal_TimerTick(object sender, EventArgs e)
        {
            //Choose a random participant
            lastParticipantIndex = currentParticipantIndex;

            while (lastParticipantIndex == currentParticipantIndex)
                currentParticipantIndex = rnd.Next(0, Global.participants.Count);

            Tick(Global.participants[currentParticipantIndex]);

            
        }

        private void RandomNumber_TimerTick(object sender, EventArgs e)
        {
            //Choose a random participant
            lastParticipantIndex = currentParticipantIndex;

            while (lastParticipantIndex == currentParticipantIndex)
                currentParticipantIndex = rnd.Next(minR, maxR + 1);

            Tick(currentParticipantIndex.ToString());
        }



        //Close this window
        private void BT_Finish_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
