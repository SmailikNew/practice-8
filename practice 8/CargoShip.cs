using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8
{
    class CargoShip : CargoTransport, IComparable, ICloneable
    {
        public CargoShip(int loadcapacity, int productiondate, string brand)
        {
            LoadCapacity = loadcapacity;
            ProductionDate = productiondate;
            Brand = brand;
        }

        public int LoadCapacity { get; set; }
        public int ProductionDate { get; set; }
        public string Brand { get; set; }

        public string ShipDescription()
        {
            return $"Судно бренда \"{Brand}\"//, произведенное в {ProductionDate} году имеет грузоподъемность {LoadCapacity} тонн.";
        }

        public object Clone()
        {
            return new CargoShip(LoadCapacity, ProductionDate, Brand);
        }

        public int CompareTo(object cargoship)
        {
            CargoShip ship = (CargoShip)cargoship;
            return LoadCapacity - ship.LoadCapacity;
        }

        public CargoShip ShallowClone()
        {
            return (CargoShip)this.MemberwiseClone();
        }
    }
}
