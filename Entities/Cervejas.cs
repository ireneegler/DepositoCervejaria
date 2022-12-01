﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Deposito.Entities
{
    internal class Cervejas
    {
        public double Quantidade { get; set; }
public OrderStatus Tipos { get; set; }

enum OrderStatus : int {
        Lager = 1,
        Pilsen = 2,
        PuroMalte = 3,
        Escura = 4,
        ZeroAlcool = 5
    }
}
}
