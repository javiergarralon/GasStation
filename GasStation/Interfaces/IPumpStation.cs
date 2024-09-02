using GasStation.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation.Interfaces
{
    public interface IPumpStation
    {
        void FreePump(int id);
        void SetPumpLimit(int id, decimal amount);
        void BlockPump(int id);
        List<PumpStatus> GetPumpStatuses();
        void RecordSupply(Supply supply);
        List<Supply> GetSupplyHistory();
    }
}
