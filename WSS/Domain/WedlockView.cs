using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class WedlockView
    {
        public static void View()
        {
            Console.Clear();
            Console.WriteLine($"Wedlock Id\tPrisoner one\tPrisoner two");
            Console.WriteLine("------------------------------------------------");
            
            foreach (var wedlock in Program.Wedlock)
            {
                
                Console.WriteLine($"{wedlock.Value.WedlockId}\t\t{wedlock.Value.Prisoner1.Name}\t\t{wedlock.Value.Prisoner2.Name} ");
            }

            Console.ReadKey();
            MenuMessages.WedlockDevices();
        }
    }
}
