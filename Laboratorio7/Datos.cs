using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    class Datos
    {
        int noCasa;
        int dpi;
        string nombre;
        string apellido;
        int cuotaPagar;

        public int NoCasa { get => noCasa; set => noCasa = value; }
        public int Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int CuotaPagar { get => cuotaPagar; set => cuotaPagar = value; }
    }
}
