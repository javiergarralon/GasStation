using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasStation.Interfaces;

namespace GasStation.Classes
{
    public class Pump : IPump
    {
        public int Id { get; private set; }
        public PumpStatus Status { get; private set; }
        public decimal? PrefixedAmount { get; private set; }

        public Pump(int id)
        {
            Id = id;
            Status = PumpStatus.Blocked;
        }

        public void Free()
        {
        }

        public void SetLimit(decimal amount)
        {
        }

        public void Block()
        {
        }

        public void Dispense(decimal amountDispensed, IPumpStation pumpStation)
        {
        }
    }
}
