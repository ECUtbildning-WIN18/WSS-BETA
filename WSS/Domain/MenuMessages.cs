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
            bool menuRun = true;

            do                                                       
            {
                Console.Clear();
                Console.WriteLine("# Wedlock Security Systems #\n");
                Console.WriteLine("1 Infrastructure");
                Console.WriteLine("2 Prisoners");
                Console.WriteLine("3 Wedlock Devices");
                Console.WriteLine("4 Exit\n\n");
                


            Int32.TryParse(Console.ReadLine(), out int tal);
                
                switch (tal)
                {

                    case 1:
                        {
                            
                                bool menu2Run = true;
                                while (menu2Run)
                                {

                                    Console.Clear();
                                    Console.WriteLine("# Infrastructure\n");
                                    Console.WriteLine("1 List Blocks");
                                    Console.WriteLine("2 Add Block");
                                    Console.WriteLine("3 Back to main menu\n");
                                    Int32.TryParse(Console.ReadLine(), out int tal2);
                                    switch (tal2)
                                    {
                                        case 1:
                                            {
                                            Console.Clear();
                                            Console.WriteLine("# List Blocks");
                                            //code

                                            //code
                                            Console.ReadLine();
                                                break;
                                            }

                                        case 2:
                                            {
                                            Console.Clear();
                                            Console.WriteLine("# Add Block");
                                            //code

                                            //code
                                                Console.ReadLine();
                                                break;
                                            }

                                        case 3:
                                            {
                                            Console.Clear();
                                            Console.WriteLine("# Back to main menu");
                                                //Back to main menu

                                                menu2Run = false;
                                                break;
                                            }

                                        default:
                                            Console.WriteLine(" !!! ");
                                            break;
                                    }

                                }

                            
                        
                        }

                            break;

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("# Prisoners\n");
                            //code

                            //code
                            Console.ReadLine();
                           
                        }

                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("# Wedlock Devices");
                            //code

                            //code
                            Console.ReadLine();
                            
                        }

                        break;

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("# Wedlock Security Systems Exit");
                            //code
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                            //code
                            Console.ReadLine();
                            
                        }

                        break;


                    default:
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.ReadLine();
                        }
                        break;


                }

            }while (menuRun) ;

        }
    }
}
