using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ClasePerro: ICarnivoro
    {
        public string Nombre { get; set; }

        public string Alimentacion()
        {
            return "Carne";
        }
    }
}
