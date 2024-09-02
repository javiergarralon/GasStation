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
        }

        public void FreePump(int id)
        {
        }

        public void SetPumpLimit(int id, decimal amount)
        {
        }

        public void BlockPump(int id)
        {
        }

        public List<PumpStatus> GetPumpStatuses()
        {
            return null;
        }

        public void RecordSupply(Supply supply)
        {
        }

        public List<Supply> GetSupplyHistory()
        {
            return null;
        }
    }
}
