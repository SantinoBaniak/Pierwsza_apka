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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pierwsza_apka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Witaj, świecie!");
        }

        private void btnTime_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;           // Odczytanie bieżącej daty
            btnTime.Content = data.ToString("T");   // Przypisanie łańcucha znakowego
                                                    // prezentującego godzinę
        }

        private void btnTime_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTime.Content = "Czas";
        }
    }
}
