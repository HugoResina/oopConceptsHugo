using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopConceptsHugo
{
    public class SmartHouse : AHouse
    {
        private double energyConsumption;
        public double EnergyConsumption
        {
            get { return energyConsumption; }
            set
            {
                if (value >= 0)
                {
                    energyConsumption = value;
                    Console.WriteLine($"Energy consumption setted to {energyConsumption} kWh.");
                }
                else
                {
                    Console.WriteLine("Energy consumption must be positive");
                }
            }
        }
        public SmartHouse(string Direction, int Rooms, double initialEnergyConsumption)
        {
            this.Direction = Direction;
            this.Rooms = Rooms;
            this.EnergyConsumption = initialEnergyConsumption; 
        }

        public override void OpenDoor()
        {
            Console.WriteLine("opening modern door");
        }
        public override void Clean()
        {
            Console.WriteLine("cleaning modern house at {0}", this.Direction);
        }
    }
}
