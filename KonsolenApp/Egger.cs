using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolenApp
{
    class Egger
    {
        public int Zahl { get; set; }
        public string Zeichenkette { get; set; }

        public Egger(int zahl, string zk)
        {
            Zahl = zahl;
            Zeichenkette = zk;
        }
    }
}
