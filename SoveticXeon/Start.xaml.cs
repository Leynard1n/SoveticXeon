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

namespace SoveticXeon
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();
        }
        private void CPU_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CPU());
        }

        private void GPU_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GPU());
        }

        private void ZU_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ZY());
        }
    }
}
