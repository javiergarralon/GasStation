using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasStation.Interfaces;

namespace GasStation.Classes
{
    public class Supply
    {
        public IPump Pump { get; set; }
        public DateTime DateTime { get; set; }
        public decimal? PrefixedAmount { get; set; }
        public decimal AmountDispensed { get; set; }
    }

}
