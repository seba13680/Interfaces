﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IHerbivoro: IAnimal
    {
        new string Nombre { get; set; }

        new string Alimentacion();

    }
}
