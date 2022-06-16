using System;
using System.Linq;
using System.Windows;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для RunGameWindow.xaml
    /// </summary>
    public partial class RunGameWindow : Window
    {
        public RunGameWindow()
        {
            InitializeComponent();

            Loaded += RunGameWindow_Loaded;
        }

        private void RunGameWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MySqlLiteContext mySqlLiteContext = new DB.MySqlLiteContext();
                var gamer = mySqlLiteContext.Gamers.ToList();
                var farms = mySqlLiteContext.Farms.ToList();
                var work = mySqlLiteContext.Works.ToList();
                dgListGame.ItemsSource = gamer;
                dgListHomeLand.ItemsSource = farms;
                dgListWork.ItemsSource = work;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRunGame_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer = dgListGame.SelectedItem as Model.Gamer;
            App.myHome = dgListHomeLand.SelectedItem as Model.HomeLand;
            App.myWork = dgListWork.SelectedItem as Model.Work;

            App.myGamer.GamerId = App.myHome.HomeId;
            App.myWork.WorkId = App.myHome.HomeId;
            if (App.myGamer.GamerId == App.myHome.HomeId)
            {
                if (App.myGamer.GamerId == App.myWork.WorkId)
                {
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Выберете поля с одинаковым id");
                }
            }
            else
            {
                MessageBox.Show("Выберете поля с одинаковым id");
            }
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
