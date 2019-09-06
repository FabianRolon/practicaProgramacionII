﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    public class Euro
    {
        double cantidad;
        static double cotizRespectoDolar;

        Euro()
        {
            Euro.cotizRespectoDolar = 1.16;
        }
        public Euro(double cantidad)
            :this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }


        
    }
}