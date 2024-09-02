using GasStation.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation.Interfaces
{
    public interface IPump
    {
        int Id { get; }
        PumpStatus Status { get; }
        decimal? PrefixedAmount { get; }
        void Free();
        void SetLimit(decimal amount);
        void Block();
        void Dispense(decimal amountDispensed, IPumpStation pumpStation);
    }
}
