﻿using System;
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
            Status = PumpStatus.Free;
        }

        public void SetLimit(decimal amount)
        {
            PrefixedAmount = amount;
            Status = PumpStatus.Prefixed;
        }

        public void Block()
        {
            Status = PumpStatus.Blocked;
            PrefixedAmount = null;
        }

        public void Dispense(decimal amountDispensed, IPumpStation pumpStation)
        {
            if (Status == PumpStatus.Free)
            {
                pumpStation.RecordSupply(new Supply
                {
                    Pump = this,
                    DateTime = DateTime.Now,
                    PrefixedAmount = PrefixedAmount,
                    AmountDispensed = amountDispensed
                });
                Block();
            }
            else if(Status == PumpStatus.Prefixed)
            {
                var amount = amountDispensed > PrefixedAmount ? PrefixedAmount : amountDispensed;

                pumpStation.RecordSupply(new Supply
                {
                    Pump = this,
                    DateTime = DateTime.Now,
                    PrefixedAmount = PrefixedAmount,
                    AmountDispensed = amount.Value
                });
                Block();
            }
            else
            {
                Console.WriteLine($"Pump {this.Id} is Blocked.");
            }
        }
    }
}
