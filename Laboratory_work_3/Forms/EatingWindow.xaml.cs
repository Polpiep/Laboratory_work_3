using System.Windows;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для EatingWindow.xaml
    /// </summary>
    public partial class EatingWindow : Window
    {
        public EatingWindow()
        {
            InitializeComponent();
        }
        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
            GameWindow gameWindow = new GameWindow();

            gameWindow.Show();

        }

        private void btFirstBreackfast_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Eating(1.5));
            Close();
            GameWindow gameWindow = new GameWindow();

            gameWindow.Show();

        }

        private void btSecondBreackfast_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Eating(1));
            Close();
            GameWindow gameWindow = new GameWindow();

            gameWindow.Show();

        }

        private void btafterDinnerTea_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Eating(0.7));
            Close();
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();

        }

        private void btaBranch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Eating(0.5));
            Close();
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();

        }

        private void btaDinner_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Eating(2.5));
            Close();
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();

        }

        private void btaEveningMeal_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Eating(2));
            Close();
            GameWindow gameWindow = new GameWindow();

            gameWindow.Show();
        }

        private void btaSecondEveningMeal_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Eating(0.3));
            Close();
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();

        }
    }
}
