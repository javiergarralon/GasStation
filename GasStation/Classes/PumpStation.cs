using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasStation.Interfaces;

namespace GasStation.Classes
{
    public class PumpStation : IPumpStation
    {
        private readonly List<IPump> pumps;
        private readonly List<Supply> supplyHistory;

        public PumpStation(int numberOfPumps)
        {
            pumps = new List<IPump>();
            supplyHistory = new List<Supply>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                pumps.Add(new Pump(i + 1));
            }
        }

        public void FreePump(int id)
        {
            var pump = pumps.FirstOrDefault(p => p.Id == id);
            pump?.Free();
        }

        public void SetPumpLimit(int id, decimal amount)
        {
            var pump = pumps.FirstOrDefault(p => p.Id == id);
            pump?.SetLimit(amount);
        }

        public void BlockPump(int id)
        {
            var pump = pumps.FirstOrDefault(p => p.Id == id);
            pump?.Block();
        }

        public List<IPump> GetAllPumps()
        {
            return pumps;
        }

        public IPump GetPump(int id)
        {
            return pumps.FirstOrDefault(p => p.Id == id);
        }

        public void RecordSupply(Supply supply)
        {
            supplyHistory.Add(supply);
        }

        public List<Supply> GetSupplyHistory()
        {
            return supplyHistory
                .OrderByDescending(x => x.DateTime)
                .ThenBy(x => x.AmountDispensed)
                .ToList();
        }
    }
}
