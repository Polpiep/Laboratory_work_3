using System.Windows;

namespace Laboratory_work_3.Forms
{
    /// <summary>
    /// Логика взаимодействия для Corn.xaml
    /// </summary>
    public partial class Corn : Window
    {
        public Corn()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btReadBooks_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Corning(3));
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btListenToGrand_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Corning(0.5));
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btTreatEveryone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BL.Corning(5));
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }
    }
}
