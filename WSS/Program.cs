using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using WSS.Domain;

namespace WSS
{
    class Program
    {
        public static Dictionary<string, Prisoner> PrisonerList = new Dictionary<string, Prisoner>();

        public static List<PrisonCells> CellsList = new List<PrisonCells>();

        static void Main(string[] args)
        {
            AddAllPrisoners.AllPrisoners();
            CellInfrastructure.AddAllCells();
            MenuMessages.MenuMessagesStart();

            Console.WriteLine("testar");
        }

        
        

    }
}