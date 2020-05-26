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

namespace Busi.Semproli._4H.Tris
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Storico_Click(object sender, RoutedEventArgs e)
        {
            Storico S = new Storico();
            this.Close();
            S.Show();
        }

        private void Gioca_Click(object sender, RoutedEventArgs e)
        {
            Gioco G = new Gioco();
            this.Close();
            G.Show();
        }
    }
}
