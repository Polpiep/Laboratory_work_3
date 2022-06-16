using System;
using System.Collections.Generic;
using System.Windows;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow()
        {
            InitializeComponent();
            var rand = new Random();
            List<Model.Work> works = new List<Model.Work>
            {
                 new Model.Work{ Name = "помадить рассаду"  , Minqualifications = 0 , Wages = 0 , UpExperience = 1} ,
                 new Model.Work{ Name = "придумывать истории"  , Minqualifications = 5 , Wages = 5 , UpExperience = 3 } ,
                 new Model.Work{ Name = "Быть фермером"  , Minqualifications = 10 , Wages = 20 , UpExperience = 2} ,
                 new Model.Work{ Name = "Быть пастухом"  , Minqualifications = 50 , Wages = 50 , UpExperience = 5} ,
                 new Model.Work{ Name = "помощник алхимика"  , Minqualifications = 100 , Wages = 100  , UpExperience = 20} ,
                 new Model.Work{ Name = "Проводник путешественников"  , Minqualifications = 250 , Wages = 250 , UpExperience = 40} ,
                 new Model.Work{ Name = "Писатель"  , Minqualifications = 500 , Wages = rand.Next(300, 700) , UpExperience = 30} ,
                 new Model.Work{ Name = "старейшина деревни"  , Minqualifications = 1500 , Wages = 500 , UpExperience = 200} ,
                 new Model.Work{ Name = "Крупная торговля"  , Minqualifications = 5000 , Wages = rand.Next(3000,5000) , UpExperience = 500} ,
                 new Model.Work{ Name = "Глава торговой гильдия"  , Minqualifications = 10000 , Wages = 10000 , UpExperience = 1000} ,
            };

            listWork.ItemsSource = works;
        }

        private void btWorking_Click(object sender, RoutedEventArgs e)
        {
            Model.Work work = listWork.SelectedItem as Model.Work;

            if (work.Minqualifications <= App.myWork.Experience)
            {
                App.myWork.Name = work.Name;
                App.myWork.Wages = work.Wages;
                App.myWork.UpExperience = work.UpExperience;
                GameWindow gameWingdow = new GameWindow();
                gameWingdow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Вы не можете устроиться на эту работу");
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }
    }
}
