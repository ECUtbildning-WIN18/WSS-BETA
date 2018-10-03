using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class PrisonCells
    {
        public string CellId { get; }
        public string PrisonerSlot { get; set; }
        public string Block { get; set; }
        public string CellNumber { get; set; }
        public int BedNumber { get; set; }
        public bool Toilet { get; private set; }
        public bool Shower { get; private set; }
        public Prisoner Prisoner { get; set; }

        public PrisonCells(string block, string cellNumber, int bedNumber, bool toilet, bool shower, Prisoner prisoner)
        {
            CellId = $"{block}-{cellNumber}";
            PrisonerSlot = $"{block}-{cellNumber}:{bedNumber}";
            Block = block;
            CellNumber = cellNumber;
            BedNumber = bedNumber;
            Toilet = toilet;
            Shower = shower;
            Prisoner = prisoner;
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
