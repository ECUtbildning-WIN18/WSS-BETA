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
        public static Dictionary<string, WedlockSystem> Wedlock = new Dictionary<string, WedlockSystem>();


        static void Main(string[] args)
        {
            
            AddAllPrisoners.AllPrisoners();
            CellInfrastructure.AddAllCells();
            AddAllWedlock.AddWedlocks();
            MenuMessages.MenuMessagesStart();
        }
    }
}