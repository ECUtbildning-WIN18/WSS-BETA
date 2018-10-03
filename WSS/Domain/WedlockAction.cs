using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WSS.Domain
{
    class WedlockAction
    {
        public static void BlowUp(string chosen)
        {
            Console.Clear();
            //Console.WriteLine(chosen);
            //Console.ReadKey();
            Console.WriteLine("Are you sure? [Yes][No]");
            Thread.Sleep(20);
            Console.WriteLine("Ignore that, its just prisoners, go and clean the mess");
            List<WedlockSystem> tempList = new List<WedlockSystem>();
            
                foreach (var weblock in Program.Wedlock)
                {
                    if (weblock.Key.Contains(chosen))
                    {
                        tempList.Add(weblock.Value);
                        
                    }
                else {
                        
                    }
                }
                foreach (var temp in tempList)
                {
                    temp.Prisoner1.IsAlive = false;
                    temp.Prisoner2.IsAlive = false;
                }
                MenuMessages.WedlockDevices();
        }


        public static void ShowDeadPeople()
        {
            Console.Clear();
            foreach (var prisoner in Program.PrisonerList)
            {
                if (!prisoner.Value.IsAlive)
                {
                    Console.WriteLine(prisoner.Value.Name);
                }
            }

            Console.ReadKey();
            MenuMessages.WedlockDevices();
        }
    }
}
