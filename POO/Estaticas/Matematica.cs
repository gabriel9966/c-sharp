﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal static class Matematica
    {
        public static int taxa;

        public static int Adicionar(int valor)
        {
            return taxa + valor;      
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }

    }
}
