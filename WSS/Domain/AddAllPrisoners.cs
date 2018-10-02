using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class AddAllPrisoners
    {
        public static void AllPrisoners()
        {
            Program.PrisonerList.Add("0001", new Prisoner("0001", "Olle"));
            Program.PrisonerList.Add("0002", new Prisoner("0001", "Pelle"));
            Program.PrisonerList.Add("0003", new Prisoner("0001", "Göran"));
            Program.PrisonerList.Add("0004", new Prisoner("0001", "Klas"));
            Program.PrisonerList.Add("0005", new Prisoner("0001", "Sture"));
            Program.PrisonerList.Add("0006", new Prisoner("0001", "Bengt"));
        }
    }
}
