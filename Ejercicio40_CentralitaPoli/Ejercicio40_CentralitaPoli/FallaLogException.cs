﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40_CentralitaPoli
{
    public class FallaLogException : Exception
    {
        public FallaLogException(string mensaje, Exception inner)
            :base(mensaje, inner)
        {

        }
    }
}
