using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busi.Semproli._4H.Tris
{
    public class Casella
    {
        private int Riga { get; set; }
        private int Colonna { get; set; }
        private int Libera { get; set; }

        public Casella(){ Libera = 0; }

        public void Riempi(){ Libera = 1; }

        public void ValoreCasella(string val)
        {
            if(val == "X")
                Libera = 1;
            else if(val == "O")
                Libera = 10;
        }

        public int OccupaCasella(){ return Libera; }
    }
}
