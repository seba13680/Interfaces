using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ClaseVaca : IHerbivoro
    {
        public string Nombre { get; set; }

        public string Alimentacion()
        {
            return "Pasto";
        }
    }
}
