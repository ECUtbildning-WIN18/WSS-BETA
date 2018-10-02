using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class AddPrisoner
    {
        public static void AddInmate()
        {
            int count = Program.PrisonerList.Count;
            string id = String.Format($"{count:0000}");
            Console.WriteLine($"Prisoner Id generated: {id}");
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Program.PrisonerList.Add(id, new Prisoner(id, name));

            MenuMessages.Prisoners();
        } 
    }
}
