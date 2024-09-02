using GasStation.Classes;
using GasStation.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        {
            // Create a PumpStation with 5 pumps
            IPumpStation pumpStation = new PumpStation(5);

            // Initial status of all pumps
            Console.WriteLine("Initial status of all pumps:");
            PrintPumpStatuses(pumpStation);

            // Pump 1 - Free | Pump 2 - Prefixed 50€
            Console.WriteLine("\nPump 1 - Free | Pump 2 - Prefixed 20 euros");
            pumpStation.FreePump(1);
            pumpStation.SetPumpLimit(2, 20m);

            // Check status after free pump 1 and set limit on pump 2
            Console.WriteLine("\nPump Station status:");
            PrintPumpStatuses(pumpStation);


            // Attempt to dispense fuel
            Console.WriteLine("\nAttempt: Pump 1 - Dispense 85 euros | Pump 2 - 50 euros (prefixed into 20 only dispense 20)");
            var pump1 = pumpStation.GetPump(1);
            var pump2 = pumpStation.GetPump(2);
            pump1?.Dispense(85m, pumpStation);
            pump2?.Dispense(50m, pumpStation);

            // Check status after dispensing
            Console.WriteLine("\nPump Station status after dispensing:");
            PrintPumpStatuses(pumpStation);

            // Try to set a limit on other pump
            Console.WriteLine("\nAttempting to set limit on pump 3:");
            pumpStation.SetPumpLimit(3, 30m);

            // Free pump 3 to test setting a limit
            pumpStation.FreePump(3);
            pumpStation.SetPumpLimit(3, 30m);

            // Block pump 4
            Console.WriteLine("\nBlocking pump 3 (delete prefixed):");
            pumpStation.BlockPump(3);

            // Check status after blocking pump 3
            Console.WriteLine("\nStatus of pumps after blocking pump 3:");
            PrintPumpStatuses(pumpStation);

            // Get supply history
            Console.WriteLine("\nSupply history:");
            PrintSupplyHistory(pumpStation);
        }
    }

    private static void PrintPumpStatuses(IPumpStation pumpStation)
    {
        var pumps = pumpStation.GetAllPumps();
        foreach (var pump in pumps)
        {
            Console.WriteLine($"Pump {pump.Id} Status: {pump.Status}");
        }
    }

    private static void PrintSupplyHistory(IPumpStation pumpStation)
    {
        var history = pumpStation.GetSupplyHistory();
        foreach (var supply in history)
        {
            Console.WriteLine($"Pump ID: {supply.Pump.Id}, Date: {supply.DateTime}, " +
                              $"Prefixed Amount: {supply.PrefixedAmount}, Amount Dispensed: {supply.AmountDispensed}");
        }
    }
}