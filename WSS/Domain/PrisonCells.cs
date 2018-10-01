using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class PrisonCells
    {
        public string CellId { get; }
        public string Block { get; set; }
        public string CellNumber { get; set; }
        public int PrisonerBlock { get; set; }
        public bool Toilet { get; private set; }
        public bool Shower { get; private set; }

        public PrisonCells(string block, string cellNumber, int prisonerBlock, bool toilet, bool shower)
        {
            Block = block;
            CellNumber = cellNumber;
            PrisonerBlock = prisonerBlock;
            CellId = $"{block}-{cellNumber}";
            Toilet = toilet;
            Shower = shower;
        }

        public void InstallToilet()
        {
            Toilet = true;
            Console.Clear();
            Console.WriteLine("A brand new Toilet is installed");
        }

        public void InstallShower()
        {
            Shower = true;
            Console.Clear();
            Console.WriteLine("A brand new Shower is installed");
        }

    }
}
