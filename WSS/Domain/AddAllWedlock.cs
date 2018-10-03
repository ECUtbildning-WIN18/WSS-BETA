using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSS.Domain
{
    class AddAllWedlock
    {
        public static void AddWedlocks()
        {
            WedlockSystem w01 = new WedlockSystem("A", Program.PrisonerList["0000"], Program.PrisonerList["0001"]);
            WedlockSystem w02 = new WedlockSystem("B", Program.PrisonerList["0002"], Program.PrisonerList["0003"]);
            WedlockSystem w03 = new WedlockSystem("C", Program.PrisonerList["0004"], Program.PrisonerList["0005"]);
            WedlockSystem w04 = new WedlockSystem("D", Program.PrisonerList["0006"], Program.PrisonerList["0007"]);
            WedlockSystem w05 = new WedlockSystem("E", Program.PrisonerList["0008"], Program.PrisonerList["0009"]);
            WedlockSystem w06 = new WedlockSystem("F", Program.PrisonerList["0010"], Program.PrisonerList["0011"]);
            WedlockSystem w07 = new WedlockSystem("G", Program.PrisonerList["0012"], Program.PrisonerList["0013"]);
            WedlockSystem w08 = new WedlockSystem("H", Program.PrisonerList["0014"], Program.PrisonerList["0015"]);
            WedlockSystem w09 = new WedlockSystem("I", Program.PrisonerList["0016"], Program.PrisonerList["0017"]);
            WedlockSystem w10 = new WedlockSystem("J", Program.PrisonerList["0018"], Program.PrisonerList["0019"]);
            WedlockSystem w11 = new WedlockSystem("K", Program.PrisonerList["0020"], Program.PrisonerList["0021"]);
            WedlockSystem w12 = new WedlockSystem("L", Program.PrisonerList["0022"], Program.PrisonerList["0023"]);

            Program.Wedlock.Add(w01.WedlockId, w01);
            Program.Wedlock.Add(w02.WedlockId, w02);
            Program.Wedlock.Add(w03.WedlockId, w03);
            Program.Wedlock.Add(w04.WedlockId, w04);
            Program.Wedlock.Add(w05.WedlockId, w05);
            Program.Wedlock.Add(w06.WedlockId, w06);

            Program.Wedlock.Add(w07.WedlockId, w07);
            Program.Wedlock.Add(w08.WedlockId, w08);
            Program.Wedlock.Add(w09.WedlockId, w09);
            Program.Wedlock.Add(w10.WedlockId, w10);
            Program.Wedlock.Add(w11.WedlockId, w11);
            Program.Wedlock.Add(w12.WedlockId, w12);


        }
    }
}
