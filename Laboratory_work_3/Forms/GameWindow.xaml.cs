using System;
using System.Windows;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Model.Gamer Gamer;
        Model.HomeLand Home;
        Model.Work Work;
        public GameWindow()
        {
            InitializeComponent();
            Gamer = App.myGamer;
            gridInfoGamer.DataContext = Gamer;

            Home = App.myHome;
            gridComputerInfo.DataContext = Home;

            Work = App.myWork;
            gridInfoWork.DataContext = Work;
        }

        private void btNextDay_Click(object sender, RoutedEventArgs e)
        {
            if (Gamer.Satiety <= 0)
            {
                MainWindow mainWindow = new MainWindow();
                MessageBox.Show("Вы умерли от голода. Дней прожито: " + App.myGamer.Day);
                mainWindow.Show();
                Close();
            }
           
            if (Gamer.Fatigue >= 100)
            {
                MessageBox.Show("Вы умерли от усталости. Дней прожито: " + Gamer.Day);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }

            if (Work.Experience >= 15000 && Work.Name == "Глава торговой гильдия" && Home.Farmers == 5 && Home.Tools == 5 &&
                Home.Livestock == 5 && Home.LivestockFeed == 5 && Home.LivestockMan == 5 && Home.ArayleLand == 5 && Home.Home == 5 && Home.Drug == 5)
            {
                MessageBox.Show("Поздравляем, вы прошли игру! Вам понадобилось на это " + Gamer.Day + " дней");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
           
            gridInfoWork.DataContext = null;
            gridInfoWork.DataContext = Work;

            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
            Work.Experience += App.myWork.UpExperience;
            Gamer.Money += App.myWork.Wages;
            Gamer.Fatigue = 0;
            Gamer.Day += 1;
            Gamer.Satiety -= 10;
        }

        private void btWork_Click(object sender, RoutedEventArgs e)
        {
            WorkWindow workWindow = new WorkWindow();
            workWindow.ShowDialog();
            Close();
        }

        private void btSaveGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BL.Saving();
                MessageBox.Show("Вы сохранили игру");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLearning_Click(object sender, RoutedEventArgs e)
        {
            Corn toLearn = new Corn();
            toLearn.ShowDialog();
            Close();
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btexit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btEating_Click(object sender, RoutedEventArgs e)
        {
            EatingWindow eatingWindow = new EatingWindow();
            eatingWindow.ShowDialog();
            Close();
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btFarm_Click(object sender, RoutedEventArgs e)
        {
            HomeLandWindow homeLandWindow = new HomeLandWindow();
            homeLandWindow.ShowDialog();
            Close();
            gridComputerInfo.DataContext = null;
            gridComputerInfo.DataContext = Home;
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
            gridInfoWork.DataContext = null;
            gridInfoWork.DataContext = Work;
        }

        private void btLoadGame_Click(object sender, RoutedEventArgs e)
        {
            Forms.RunGameWindow RunGame = new Forms.RunGameWindow();
            RunGame.Show();
            Close();
        }
    }
}
