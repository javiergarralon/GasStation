using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GasStation.Classes;
using GasStation.Interfaces;

namespace GasStation.Tests
{
    [TestFixture]
    public class PumpStationTests
    {
        private IPumpStation _pumpStation;

        [SetUp]
        public void SetUp()
        {
            // Create a new PumpStation with 5 pumps for each test
            _pumpStation = new PumpStation(5);
        }

        [Test]
        public void Pump_ShouldBeBlockedInitially()
        {
            // Arrange
            var pumps = _pumpStation.GetAllPumps();

            // Assert
            foreach (var pump in pumps)
            {
                Assert.AreEqual(PumpStatus.Blocked, pump.Status);
            }
        }

        [Test]
        public void FreePump_ShouldSetPumpToFreeState()
        {
            // Act
            _pumpStation.FreePump(1);

            // Assert
            var pump = _pumpStation.GetPump(1);
            Assert.AreEqual(PumpStatus.Free, pump.Status);
        }

        [Test]
        public void BlockPump_ShouldBlockThePump()
        {
            // Arrange
            _pumpStation.FreePump(1);

            // Act
            _pumpStation.BlockPump(1);

            // Assert
            var pump = _pumpStation.GetPump(1);
            Assert.AreEqual(PumpStatus.Blocked, pump.Status);
        }

        [Test]
        public void SetPumpLimit_ShouldSetTheLimitOnThePump()
        {
            // Arrange
            _pumpStation.FreePump(1);

            // Act
            _pumpStation.SetPumpLimit(1, 50m);

            // Assert
            var pump = _pumpStation.GetPump(1);
            Assert.AreEqual(50m, pump.PrefixedAmount);
        }

        [Test]
        public void Dispense_ShouldRecordSupplyAndBlockPump()
        {
            // Arrange
            _pumpStation.FreePump(1);
            _pumpStation.SetPumpLimit(1, 50m);
            var pump = _pumpStation.GetPump(1);

            // Act
            pump.Dispense(30m, _pumpStation);

            // Assert
            Assert.AreEqual(PumpStatus.Blocked, pump.Status);

            var supplyHistory = _pumpStation.GetSupplyHistory();
            Assert.AreEqual(1, supplyHistory.Count);
            Assert.AreEqual(30m, supplyHistory[0].AmountDispensed);
        }

        [Test]
        public void GetSupplyHistory_ShouldReturnSuppliesOrderedByDateAndAmount()
        {
            // Arrange
            _pumpStation.FreePump(1);
            _pumpStation.FreePump(2);
            _pumpStation.GetPump(1).Dispense(40m, _pumpStation);
            _pumpStation.GetPump(2).Dispense(50m, _pumpStation);

            // Act
            var supplyHistory = _pumpStation.GetSupplyHistory();

            // Assert
            Assert.AreEqual(2, supplyHistory.Count);
            Assert.AreEqual(50m, supplyHistory[0].AmountDispensed);
            Assert.AreEqual(40m, supplyHistory[1].AmountDispensed);
        }
    }
}