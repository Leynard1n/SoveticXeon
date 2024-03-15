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
    /// Логика взаимодействия для CPU.xaml
    /// </summary>
    public partial class CPU : Page
    {
        public CPU()
        {
            InitializeComponent();
        }

        private void Back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
