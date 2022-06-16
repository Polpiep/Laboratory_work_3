using System;
using System.Collections.Generic;
using System.Windows;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для NewGameWindow.xaml
    /// </summary>
    public partial class NewGameWindow : Window
    {
        public NewGameWindow()
        {
            InitializeComponent();
            List<string> genderList = new List<string> { "мужской", "женский" };
            cbGender.ItemsSource = genderList;
            cbGender.SelectedIndex = 0;
        }

        private void btCreateGame_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbAge.Text))
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                if (Convert.ToInt32(tbAge.Text) >= 33 && Convert.ToInt32(tbAge.Text) <= 130)
                {

                    Model.Gamer gamer = new Model.Gamer();
                    gamer.Name = tbName.Text;
                    gamer.Age = Convert.ToInt32(tbAge.Text);
                    gamer.Gender = cbGender.SelectedValue.ToString();

                    gamer.Satiety = 100;
                    gamer.Fatigue = 0;
                    gamer.Money = 100;
                    gamer.Day = 0;
                    App.myGamer = gamer;

                    Model.HomeLand homeLand = new Model.HomeLand();
                    homeLand.Farmers = 0;
                    homeLand.Tools = 0;
                    homeLand.Livestock = 0;
                    homeLand.LivestockFeed = 0;
                    homeLand.LivestockMan = 0;
                    homeLand.ArayleLand = 0;
                    homeLand.Home = 0;
                    homeLand.Drug = 0;
                    App.myHome = homeLand;

                    Model.Work work = new Model.Work();
                    work.Name = "Безработный";
                    work.Experience = 0;
                    work.Wages = 0;
                    work.UpExperience = 0;
                    App.myWork = work;

                    Forms.GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Введите корректный возраст!");
                }
                
            }
        }
    }
}
