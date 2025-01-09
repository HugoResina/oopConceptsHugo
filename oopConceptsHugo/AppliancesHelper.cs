using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopConceptsHugo
{
    public static class AppliancesHelper
    {
        public static void TurnOnAppliance(string appliance)
        {
            Console.WriteLine($"Turning on {appliance}");
        }

        public static void TurnOffAppliance(string appliance)
        {
            Console.WriteLine($"Turning off {appliance}");
        }


    }
}
