using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes
{
    public class Televisao
    {
        public int Canal { get; set; }
        public int Volume { get; set; } 
        public bool Ligada { get; set; }

        public void Liga()
        {
            Ligada = true;
        }

        public void Desliga()
        {
            Ligada = false;
        }

        public int MudaDeCanal(int canal)
        {
            Canal = canal;

            return Canal;
        }

        public int AumentaVolume(int volume)
        {
            Volume += volume;

            return Volume;
        }

        public int DiminuiVolume(int volume)
        {
            Volume -= volume;

            return Volume;
        }
    }
}
