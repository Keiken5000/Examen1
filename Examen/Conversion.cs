using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Conversion
    {
        public  double PesoMexicano { get; set; }

        public  double DolarEstadosUnidos { get; set; }

        public double DolarCanadiense { get; set; }

        public double Euro { get; set; }

        public double YenJapones { get; set; }

        public Conversion()
        {
            this.PesoMexicano = 0;
            this.DolarEstadosUnidos = 0;
            this.DolarCanadiense = 0;
            this.Euro = 0;
            this.YenJapones = 0;
        }

        public Conversion(double pesoMexicano)
        {
            this.PesoMexicano = PesoMexicano;
            this.DolarEstadosUnidos = DolarEstadosUnidos;
            this.DolarCanadiense = DolarCanadiense;
            this.Euro = Euro;
            this.YenJapones = YenJapones;


        }
    }
}
