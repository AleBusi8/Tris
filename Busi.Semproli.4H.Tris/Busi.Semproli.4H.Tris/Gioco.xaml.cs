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
using System.Windows.Threading;

namespace Busi.Semproli._4H.Tris
{
    /// <summary>
    /// Logica di interazione per Gioco.xaml
    /// </summary>
    public partial class Gioco : Window
    {
        MainWindow mw = new MainWindow();
        Tris casa = new Tris();
        int win1, win2, draw;

        public Gioco()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("risultati.txt");
            string riga = sr.ReadLine();
            string [] dati = riga.Split(';');
            win1 = Convert.ToInt32(dati[0]);
            win2 = Convert.ToInt32(dati[1]);
            draw = Convert.ToInt32(dati[2]);
            sr.Close();
        }

        private void btn00_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(0, 0)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn00.Content = valore;
                int winner = casa.Vittoria();

                switch (winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(0, 1)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn01.Content = valore;
                int winner = casa.Vittoria();

                switch (winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void btn02_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(0, 2)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn02.Content = valore;
                int winner = casa.Vittoria();

                switch (winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(1, 0)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn10.Content = valore;
                int winner = casa.Vittoria();

                switch (winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(1, 1)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn11.Content = valore;
                int winner = casa.Vittoria();

                switch (winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(1, 2)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn12.Content = valore;
                int winner = casa.Vittoria();

                switch (winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void btn20_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(2, 0)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn20.Content = valore;
                int winner = casa.Vittoria();

                switch (winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void btn21_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(2, 1)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn21.Content = valore;
                int winner = casa.Vittoria();

                switch (winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void btn22_Click(object sender, RoutedEventArgs e)
        {
            string valore;
            if ((valore=casa.Mossa(2, 2)) == "")
            {
                MessageBox.Show("casella già occupata");
            }
            else
            {
                btn22.Content = valore;
                int winner = casa.Vittoria();

                switch(winner)
                {
                    case 3:
                        draw++;
                        MessageBox.Show($"Pareggio, che peccato!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 1:
                        win1++;
                        MessageBox.Show($"Giocatore 1, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    case 2:
                        win2++;
                        MessageBox.Show($"Giocatore 2, sei il vincitore!!");
                        mw.Show();
                        this.Close();
                        break;

                    default:
                        turno_lbl.Text = $"Giocatore {casa.Turno()}: fa la tua mossa!";
                        break;
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter s = new StreamWriter("risultati.txt");
            s.Write($"{win1};{win2};{draw}");
            s.Close();
        }
    }
}
