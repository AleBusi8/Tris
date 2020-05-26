using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busi.Semproli._4H.Tris
{
    public class Tris
    {
        private int ContaMossa { get; set; }

        public Casella[,] campo = new Casella[3,3];

        Casella casella = new Casella();
        
        public Tris()
        {
            ContaMossa = 0;

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    campo[r, c] = new Casella();
                }
            }
        }

        public int Vittoria()
        {
            int vincitore = 0;
            int somma = 0;

            for (int r = 0; r < 3; r++)
            {
                somma = 0;
                for (int c = 0; c < 3; c++)
                    somma += campo[r, c].OccupaCasella();

                if (somma == 3)
                    vincitore = 1;
                if (somma == 30)
                    vincitore = 2;
            }

            for (int r = 0; r < 3; r++)
            {
                somma = 0;
                for (int c = 0; c < 3; c++)
                    somma += campo[c, r].OccupaCasella();

                if (somma == 3)
                    vincitore = 1;
                if (somma == 30)
                    vincitore = 2;
            }

            somma = 0;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (r == c)
                        somma += campo[r, c].OccupaCasella();

                    if (somma == 3)
                        vincitore = 1;
                    if (somma == 30)
                        vincitore = 2;
                }
            }

            somma = 0;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (r + 2 == c || (r == 1 && c == 1) || r - 2 == c)
                        somma += campo[r, c].OccupaCasella();

                    if (somma == 3)
                        vincitore = 1;
                    if (somma == 30)
                        vincitore = 2;
                }
            }

            if (vincitore == 0 && ContaMossa == 9)
                vincitore = 3;

            return vincitore;
        }

        public int Turno()
        { 
            return (ContaMossa % 2) + 1; 
        }

        public string Mossa(int riga, int colonna)
        {
            string disegno = "";
            string frase;
            if (campo[riga,colonna].OccupaCasella() == 0)
            {
                if(ContaMossa%2 == 0) //se è resto 0, sta al giocatore 1, se è resto 1, sta al giocatore 2
                {
                    campo[riga, colonna].Riempi();
                    disegno = "X";
                    frase = "Giocatore 2: fa la tua mossa!";
                    campo[riga, colonna].ValoreCasella(disegno);
                }
                else if(ContaMossa%2 == 1)
                {
                    campo[riga, colonna].Riempi();
                    disegno = "O";
                    frase = "Giocatore 1: fa la tua mossa!";
                    campo[riga, colonna].ValoreCasella(disegno);
                }
                ContaMossa++;
            }
            return disegno;
        }
    }   
}
