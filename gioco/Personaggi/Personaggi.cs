using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gioco.Personaggi
{
    public abstract class Personaggi
    {
        public int PuntiVita { get; set; }
        public int PuntiForza { get; set; }
        public string Squadra { get; set; }

        public int Velocita { get;set; }

        public int PuntiDifesa { get; set; }
    }

}
