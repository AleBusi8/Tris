using System;
using System.Collections.Generic;
using System.IO;
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

namespace Busi.Semproli._4H.Tris
{
    /// <summary>
    /// Logica di interazione per Storico.xaml
    /// </summary>
    public partial class Storico : Window
    {
        public Storico()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader r = new StreamReader("risultati.txt");
            string riga = r.ReadLine();
            string[] dati = riga.Split(';');
            w1.Content = dati[0];
            w2.Content = dati[1];
            draw.Content = dati[2];
            r.Close();
        }

        private void Azz_btn_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter s = new StreamWriter("risultati.txt");
            s.Write($"{0};{0};{0}");
            s.Close();

            Azz_btn.Content = "RIS. AZZERATI!";
            w1.Content = 0; w2.Content = 0; draw.Content = 0;
        }

        private void Esc_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow M = new MainWindow(); 
            this.Close();
            M.Show();
        }
    }
}
