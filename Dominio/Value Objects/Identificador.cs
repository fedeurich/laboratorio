﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValueObject
{
    public class Identificador
    {

        private Guid valor;

        public Identificador(Guid valor)
        {
            this.valor = valor;

        }

        public Guid GetValor()
        {
            return this.valor;
        }
    }
}
