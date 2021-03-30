using System.Windows;
using HomeTask2.Common;
using HomeTask2.UserClass;

namespace HomeTask2
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IStartClass _IAbstract { get; set; }

       
        public MainWindow()
        {
            InitializeComponent();
          
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            ExitClass.exit = false;
            IStartClass runone = new RunOneResuorce();
            IStartClass runtwo = new RunOneResuorce();
            IStartClass runthree = new RunOneResuorce();

            //Запускаем первого исполнителя(время, время, время, исполнитель,имя динамической переменной,имя динамической переменной) 
            runone.AllOnePerformer(5, 3, 1, 1, "one", "OneMachine");
            //Запускаем второго исполнителя (Параметры теже)
            runtwo.AllOnePerformer(3, 3, 3, 2, "two", "TwoMachine");
            //Запускаем третьего иполнителя (Параметры теже)
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
            // Центрация формы по центру
            FormCentre.CentreForm(this);

            Application.Current.Resources["one"] = "Свободен";
            Application.Current.Resources["two"] = "Свободен";
            Application.Current.Resources["three"] = "Свободен";
        }
    }
}
