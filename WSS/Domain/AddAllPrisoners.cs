using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class AddAllPrisoners
    {
        public static void AllPrisoners()
        {
            Prisoner p1 = new Prisoner("0000", "Petter");
            Prisoner p2 = new Prisoner("0001", "Olle");
            Prisoner p3 = new Prisoner("0002", "Pelle");
            Prisoner p4 = new Prisoner("0003", "Göran");
            Prisoner p5 = new Prisoner("0004", "Klas");
            Prisoner p6 = new Prisoner("0005", "Sture");
            Prisoner p7 = new Prisoner("0006", "Bengt");
            
            Program.PrisonerList.Add(p1.PrisonerId, p1);
            Program.PrisonerList.Add(p2.PrisonerId, p2);
            Program.PrisonerList.Add(p3.PrisonerId, p3);
            Program.PrisonerList.Add(p4.PrisonerId, p4);
            Program.PrisonerList.Add(p5.PrisonerId, p5);
            Program.PrisonerList.Add(p6.PrisonerId, p6);
            Program.PrisonerList.Add(p7.PrisonerId, p7);
        }
    }
}
