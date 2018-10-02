using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class PrisonerView
    {
        public static void View()
        {
            Console.Clear();
            PrisonerList();
            Console.WriteLine();
            Console.WriteLine("Press key to continue...");
            Console.ReadKey();
            
            MenuMessages.InfrastructureMenu();
        }

        static void PrisonerList()
        {
            Console.Clear();
            foreach (var prisoner in Program.PrisonerList)
            {
                Console.WriteLine($"Name: {prisoner.Value.Name}, Prisoner Id: {prisoner.Key}");
            }
        }
    }
}
