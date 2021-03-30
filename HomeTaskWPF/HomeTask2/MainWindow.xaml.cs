using System.Windows;
using HomeTask2.UserClass;

namespace HomeTask2
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public StartClass _IAbstract { get; set; }

       
        public MainWindow()
        {
            InitializeComponent();
          
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            ExitClass.exit = false;
            StartClass runone = new RunOneResuorce();
            StartClass runtwo = new RunOneResuorce();
            StartClass runthree = new RunOneResuorce();

            runone.AllOnePerformer(5, 3, 1, 1, "one", "OneMachine");
            runtwo.AllOnePerformer(3, 3, 3, 2, "two", "TwoMachine");
            runthree.AllOnePerformer(1, 3, 5, 3, "three", "ThreeMachine");

            this.Start.IsEnabled = false;
            this.Stop.IsEnabled = true;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            ExitClass.exit = true;
            this.Start.IsEnabled = true;
            this.Stop.IsEnabled = false;
            Application.Current.Resources["OneMachine"] = "";
            Application.Current.Resources["TwoMachine"] = "";
            Application.Current.Resources["ThreeMachine"] = "";

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.Start.IsEnabled = true;
            this.Start.Content = "Старт";
            this.Stop.Content = "Стоп";
            this.Stop.IsEnabled = false;
            this.ResizeMode = ResizeMode.NoResize;
            this.Title = "Домашняя работа №2";
            double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            double screenWidth = SystemParameters.FullPrimaryScreenWidth;
            this.Top = (screenHeight - this.ActualHeight) / 2;
            this.Left = (screenWidth - this.ActualWidth) / 2;
        }
    }
}
