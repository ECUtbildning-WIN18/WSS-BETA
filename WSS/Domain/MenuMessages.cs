using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WSS.Domain
{
    class MenuMessages

    {
        public static void MenuMessagesStart()
        {
            Console.Clear();
            Console.WriteLine("# Wedlock Security Systems #\n");
            Console.WriteLine("1 Infrastructure");
            Console.WriteLine("2 Prisoners");
            Console.WriteLine("3 Wedlock Devices");
            Console.WriteLine("4 Exit\n\n");

            char choice = Console.ReadKey().KeyChar;

            if (choice == '1')
            {
                InfrastructureMenu();
            }else if (choice == '2')
            {
                Prisoners();
            }
            else if (choice == '3')
            {
                WedlockDevices();
            }
            else if (choice == '4')
            {
                WssExit();
            }
            else
            {
                Console.WriteLine("Somthing get wrong try again!");
                MenuMessagesStart();
            }
        }

        public static void InfrastructureMenu()
        {
            Console.Clear();
            Console.WriteLine("# Infrastructure\n");
            Console.WriteLine("1 List Blocks");
            Console.WriteLine("2 Add Block");
            Console.WriteLine("3 Back to main menu\n");

            char choice = Console.ReadKey().KeyChar;

            if (choice == '1')
            {
                CellView.View();
            }
            else if (choice == '2')
            {
                BlocksAdd();
            }
            else if (choice == '3')
            {
                MenuMessagesStart();
            }
            else
            {
                Console.WriteLine("Somthing get wrong try again!");
                InfrastructureMenu();
            }

            Console.ReadKey();
        }

        public static void BlockList()
            {
                Console.Clear();
                Console.WriteLine("# List Blocks\n");
                //code

                Console.Write("Block >");
                string SelectBlock = Console.ReadLine();
                Console.WriteLine(SelectBlock);

                // (V)iew block, (D)elete block
                //
                //          
                //              # Block ID_
                //     
                //              // 1 List Cell
                // 2 Add Cell
                //Delete block [block] (Y)es, (N)o 

                //

                //code
        }  
                 
        public static void BlocksAdd()
        {
        //##//
        Console.Clear();
        Console.WriteLine("# Add Block\n");
        //code



        //code
                    
        Console.Clear();
        Console.WriteLine("# Back to main menu");
        MenuMessages.MenuMessagesStart();
        }

        public static void Prisoners()
        {
            Console.Clear();
            Console.WriteLine("# Prisoners\n");
            Console.WriteLine("1 Add Prisoner");
            Console.WriteLine("2 List Prisoner");

            char choice = Console.ReadKey().KeyChar;

            if (choice == '1')
            {
                Console.Clear();
                Console.WriteLine("Not yet ready!");
                Console.ReadKey();
                Prisoners();
                
            }
            else if (choice == '2')
            {
                PrisonerView.View();
            }
            else
            {
                Console.WriteLine("Somthing get wrong try again!");
                Console.ReadKey();
                Prisoners();
            }
        }

        public static void WedlockDevices()
        {
            //##//
            Console.Clear();
            Console.WriteLine("# Wedlock Devices\n");
            //code

            //code
            
            //##//
        }

        public static void WssExit()
        {
            Console.Clear();
            Console.WriteLine("# Wedlock Security Systems Exit");
            //code
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
