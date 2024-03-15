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

namespace SoveticXeon.Viev
{
    /// <summary>
    /// Логика взаимодействия для MAIN.xaml
    /// </summary>
    public partial class MAIN : Window
    {
        public MAIN()
        {
            InitializeComponent();
            CPUFrame.Content = new Start();
            CPUFrame.Visibility = Visibility.Visible;
        }
    }
}
