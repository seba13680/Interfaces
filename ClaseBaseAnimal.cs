using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ClaseBaseAnimal : IAnimal
    {
        public string Nombre { get; set; }

        public string Alimentacion()
        {
            throw new NotImplementedException();
        }
    }
}
