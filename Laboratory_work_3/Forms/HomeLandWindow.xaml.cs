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
                    homeLand.Home += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                    App.myGamer.Money -= 1000;
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
                    homeLand.Farmers += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                    App.myGamer.Money -= 1000;
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
                    homeLand.Tools += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                    App.myGamer.Money -= 1000;
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
                    homeLand.ArayleLand += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                    App.myGamer.Money -= 1000;
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
                    homeLand.Livestock += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                    App.myGamer.Money -= 1000;
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
                    homeLand.LivestockFeed += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                    App.myGamer.Money -= 1000;
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
                    homeLand.LivestockMan += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                    App.myGamer.Money -= 1000;
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
                    homeLand.Drug += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = homeLand;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }
        private void btTellStories_Click(object sender, RoutedEventArgs e)
        {

            App.myGamer.Fatigue += 25;
            App.myWork.Experience += 10;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы Рассказали историю");
            if (App.myHome.Farmers == 2 && App.myHome.Tools == 2 && App.myHome.Livestock == 2 && App.myHome.LivestockFeed == 2 &&
                App.myHome.LivestockMan == 2 && App.myHome.ArayleLand == 2 && App.myHome.Home == 2 && App.myHome.Drug == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 3 && App.myHome.Tools == 3 && App.myHome.Livestock == 3 && App.myHome.LivestockFeed == 3 &&
                App.myHome.LivestockMan == 3 && App.myHome.ArayleLand == 3 && App.myHome.Home == 3 && App.myHome.Drug == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 4 && App.myHome.Tools == 4 && App.myHome.Livestock == 4 && App.myHome.LivestockFeed == 4 &&
                App.myHome.LivestockMan == 4 && App.myHome.ArayleLand == 4 && App.myHome.Home == 4 && App.myHome.Drug == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 5 && App.myHome.Tools == 5 && App.myHome.Livestock == 5 && App.myHome.LivestockFeed == 5 &&
                App.myHome.LivestockMan == 5 && App.myHome.ArayleLand == 5 && App.myHome.Home == 5 && App.myHome.Drug == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }

        private void btWriteStories_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 50;
            App.myWork.Experience += 25;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы выполнили разработку");
            if (App.myHome.Farmers == 2 && App.myHome.Tools == 2 && App.myHome.Livestock == 2 && App.myHome.LivestockFeed == 2 &&
                App.myHome.LivestockMan == 2 && App.myHome.ArayleLand == 2 && App.myHome.Home == 2 && App.myHome.Drug == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 3 && App.myHome.Tools == 3 && App.myHome.Livestock == 3 && App.myHome.LivestockFeed == 3 &&
                App.myHome.LivestockMan == 3 && App.myHome.ArayleLand == 3 && App.myHome.Home == 3 && App.myHome.Drug == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 4 && App.myHome.Tools == 4 && App.myHome.Livestock == 4 && App.myHome.LivestockFeed == 4 &&
                App.myHome.LivestockMan == 4 && App.myHome.ArayleLand == 4 && App.myHome.Home == 4 && App.myHome.Drug == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 5 && App.myHome.Tools == 5 && App.myHome.Livestock == 5 && App.myHome.LivestockFeed == 5 &&
                App.myHome.LivestockMan == 5 && App.myHome.ArayleLand == 5 && App.myHome.Home == 5 && App.myHome.Drug == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }

        private void btDOStories_Click(object sender, RoutedEventArgs e)
        {

            App.myGamer.Fatigue += 75;
            App.myWork.Experience += 50;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы выполнили разработку");
            if (App.myHome.Farmers == 2 && App.myHome.Tools == 2 && App.myHome.Livestock == 2 && App.myHome.LivestockFeed == 2 &&
                App.myHome.LivestockMan == 2 && App.myHome.ArayleLand == 2 && App.myHome.Home == 2 && App.myHome.Drug == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 3 && App.myHome.Tools == 3 && App.myHome.Livestock == 3 && App.myHome.LivestockFeed == 3 &&
                App.myHome.LivestockMan == 3 && App.myHome.ArayleLand == 3 && App.myHome.Home == 3 && App.myHome.Drug == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 4 && App.myHome.Tools == 4 && App.myHome.Livestock == 4 && App.myHome.LivestockFeed == 4 &&
                App.myHome.LivestockMan == 4 && App.myHome.ArayleLand == 4 && App.myHome.Home == 4 && App.myHome.Drug == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myHome.Farmers == 5 && App.myHome.Tools == 5 && App.myHome.Livestock == 5 && App.myHome.LivestockFeed == 5 &&
                App.myHome.LivestockMan == 5 && App.myHome.ArayleLand == 5 && App.myHome.Home == 5 && App.myHome.Drug == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }
    }
}
