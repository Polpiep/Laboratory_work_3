using System.Windows;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для ComputerWindow.xaml
    /// </summary>
    public partial class ComputerWindow : Window
    {
        Model.HomeLand Computer;
        Model.Gamer Gamer;
        Model.Work Work;
        public ComputerWindow()
        {
            InitializeComponent();

            Computer = App.myHome;
            gridComputerInfo.DataContext = Computer;

            Gamer = App.myGamer;
            tbInfoFat.DataContext = Gamer;

            Work = App.myWork;
            tbInfoExp.DataContext = Work;
        }

        private void btUpgrade1_Click(object sender, RoutedEventArgs e)
        {
            if (Computer.Farmers == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Farmers += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
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
            if (Computer.Tools == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Tools += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
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
            if (Computer.Livestock == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Livestock += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
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
            if (Computer.LivestockFeed == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.LivestockFeed += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
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
            if (Computer.LivestockMan == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.LivestockMan += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
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
            if (Computer.ArayleLand == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.ArayleLand += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
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
            if (Computer.Home == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Home += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
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
            if (Computer.Drug == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Computer.Drug += 1;
                    gridComputerInfo.DataContext = null;
                    gridComputerInfo.DataContext = Computer;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btCreateWebSite_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 25;
            App.myWork.Experience += 10;
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

        private void btCreateGame_Click(object sender, RoutedEventArgs e)
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

        private void btCreateMobileApp_Click(object sender, RoutedEventArgs e)
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
