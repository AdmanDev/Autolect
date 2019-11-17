using MyFunctions;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Autolect
{
    public partial class WindowHeader : UserControl
    {
        //Variables;
        private Window window;
        private Menu_ADMAN_SoftwareFR admanMenu;
        private const string feature_WebPage = "https://admansoftware.wordpress.com/2018/07/03/autolect-fonctionnalites-a-venir/";

        //Properties
        public static readonly DependencyProperty ShowADMANProperty = DependencyProperty.Register(nameof(ShowADMAN), typeof(bool), typeof(WindowHeader), new PropertyMetadata(false));
        public bool ShowADMAN
        {
            get  => (bool)GetValue(ShowADMANProperty);
            set => SetValue(ShowADMANProperty, value);
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(WindowHeader), new PropertyMetadata("Autolect"));
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }


        //Constructor
        public WindowHeader()
        {
            InitializeComponent();

            admanMenu = new Menu_ADMAN_SoftwareFR(feature_WebPage);
        }

        private void Header_Loaded(object sender, RoutedEventArgs e)
        {
            window = Window.GetWindow(this);
        }

        private void Grid_Header_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            window.DragMove();
        }

        private void BT_Close_Click(object sender, RoutedEventArgs e)
        {
            if(window is MainWindow)
            {
                Application.Current.Shutdown();
                return;
            }

            Global.mainWindow.EditFinish(true);
            window.Close();
        }

        private void BT_ADMANSoftware_Click(object sender, RoutedEventArgs e)
        {
            int x = System.Windows.Forms.Cursor.Position.X;
            int y = System.Windows.Forms.Cursor.Position.Y;
            admanMenu.ShowMenu(x, y);
        }

    }
}
