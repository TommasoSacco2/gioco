using gioco.Personaggi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gioco.Personaggi
{
    internal class Cavaliere:Personaggi
    {
        public Cavaliere(int PuntiForza)
        {
            PuntiVita = 1000;
            PuntiForza += PuntiForza;
        }

    }
}
