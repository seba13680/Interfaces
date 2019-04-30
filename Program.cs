using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program

    {
        static void Main(string[] args)
        {
            var animales = new List<IAnimal>();

            animales.Add(new ClasePerro { Nombre = "Laika" });
            animales.Add(new ClaseVaca { Nombre = "ChuVaca" });
            animales.Add(new ClaseOveja { Nombre = "Dolly" });
            animales.Add(new ClaseLeon { Nombre = "Simba" });

            foreach (IAnimal animal in animales)
            {
               Console.WriteLine("Animal: {0} Alimentación: {1}", animal.Nombre, animal.Alimentacion());
            }
            
        }
    }
}

