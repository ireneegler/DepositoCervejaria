using System;
using System.Collections.Generic;
using System.Text;

namespace Deposito.Entities
{
    internal class Cervejas
    {
        public int Tipos { get; set; }
public OrderStatus Status { get; set; }

enum OrderStatus : int {
        Lager = 1,
        Pilsen = 2,
        PuroMalte = 3,
        Escura = 4,
        ZeroAlcool = 5
    }
}
}
