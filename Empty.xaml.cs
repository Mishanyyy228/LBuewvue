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

namespace LB
{
    /// <summary>
    /// Логика взаимодействия для Empty.xaml
    /// </summary>
    public partial class Empty : Window
    {
        public Empty()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            WindowManager.SwitchWindow(this, main);

        }
    }
}
