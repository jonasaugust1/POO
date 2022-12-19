
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes
{
    public class TelevisaoConstrutor
    {
        public int Canal;
        public int Volume;
        public bool Ligada;

        public TelevisaoConstrutor(int canal = 1, int volume = 0, bool ligada = false)
        {
            Canal = canal;
            Volume = volume;
            Ligada = ligada;
        }

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
