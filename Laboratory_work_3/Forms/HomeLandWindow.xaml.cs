using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для HomeLandWindow.xaml
    /// </summary>
    public partial class HomeLandWindow : Window
    {
        Model.HomeLand homeLand;
        Model.Gamer Gamer;
        Model.Work Work;
        public HomeLandWindow()
        {
            InitializeComponent();

            homeLand = App.myHome;
            gridComputerInfo.DataContext = homeLand;

            Gamer = App.myGamer;
            tbInfoFat.DataContext = Gamer;

            Work = App.myWork;
            tbInfoExp.DataContext = Work;
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btUpgrade1_Click(object sender, RoutedEventArgs e)
        {
            if (homeLand.Home == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    BL.Upgraiding(1);
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                }
                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade2_Click(object sender, RoutedEventArgs e)
        {
            if (homeLand.Farmers == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    BL.Upgraiding(2);
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade3_Click(object sender, RoutedEventArgs e)
        {

            if (homeLand.Tools == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    BL.Upgraiding(3);
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade4_Click(object sender, RoutedEventArgs e)
        {
            if (homeLand.ArayleLand == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    BL.Upgraiding(4);
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade5_Click(object sender, RoutedEventArgs e)
        {
            if (homeLand.Livestock == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    BL.Upgraiding(5);
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade6_Click(object sender, RoutedEventArgs e)
        {
            if (homeLand.LivestockFeed == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    BL.Upgraiding(6);
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                }
                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade7_Click(object sender, RoutedEventArgs e)
        {
            if (homeLand.LivestockMan == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    BL.Upgraiding(7);
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }
        private void btUpgrade8_Click(object sender, RoutedEventArgs e)
        {
            if (homeLand.Drug == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    BL.Corning(8);
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }
        private void btTellStories_Click(object sender, RoutedEventArgs e)
        {

            if (App.myGamer.Fatigue <= 90)
            {
                var rand = new Random();
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
                MessageBox.Show("Вы Рассказали историю");
                BL.Corning(rand.Next(10));
            }
            else
            {
                MessageBox.Show("Вы слишком устали, подождите следующего дня");
            }
        }

        private void btWriteStories_Click(object sender, RoutedEventArgs e)
        {
            if (App.myGamer.Fatigue <= 90)
            {
                var rand = new Random();
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
                MessageBox.Show("Вы Что-то написали");
                int randNum = rand.Next(10);
                BL.Corning(randNum);
            }
            else
            {
                MessageBox.Show("Вы слишком устали, подождите следующего дня");
            }

        }

        private void btDOStories_Click(object sender, RoutedEventArgs e)
        {
            if (App.myGamer.Fatigue <= 90)
            {
                var rand = new Random();
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
                if (rand.Next(10) == 10)
                {
                    int x = rand.Next(10);
                    MessageBox.Show("Вы выкопали клад");
                    App.myGamer.Fatigue -= 3 * x;
                    tbInfoFat.DataContext = null;
                    tbInfoFat.DataContext = Gamer;
                    tbInfoExp.DataContext = null;
                    tbInfoExp.DataContext = Work;
                }
                else
                {
                    MessageBox.Show("Вы так ничего и не нашли(");
                }
            }
            else
            {
                MessageBox.Show("Вы слишком устали, подождите следующего дня");
            }
        }
    }
}
