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

            Prisoner p7 = new Prisoner("0006", "Petter");
            Prisoner p8 = new Prisoner("0007", "Olle");
            Prisoner p9 = new Prisoner("0008", "Pelle");
            Prisoner p10 = new Prisoner("0009", "Göran");
            Prisoner p11 = new Prisoner("0010", "Klas");
            Prisoner p12 = new Prisoner("0011", "Sture");

            Prisoner p13 = new Prisoner("0012", "Petter");
            Prisoner p14 = new Prisoner("0013", "Olle");
            Prisoner p15 = new Prisoner("0014", "Pelle");
            Prisoner p16 = new Prisoner("0015", "Göran");
            Prisoner p17 = new Prisoner("0016", "Klas");
            Prisoner p18 = new Prisoner("0017", "Sture");

            Prisoner p19 = new Prisoner("0018", "Petter");
            Prisoner p20 = new Prisoner("0019", "Olle");
            Prisoner p21 = new Prisoner("0020", "Pelle");
            Prisoner p22 = new Prisoner("0021", "Göran");
            Prisoner p23 = new Prisoner("0022", "Klas");
            Prisoner p24 = new Prisoner("0023", "Sture");


            Program.PrisonerList.Add(p1.PrisonerId, p1);
            Program.PrisonerList.Add(p2.PrisonerId, p2);
            Program.PrisonerList.Add(p3.PrisonerId, p3);
            Program.PrisonerList.Add(p4.PrisonerId, p4);
            Program.PrisonerList.Add(p5.PrisonerId, p5);
            Program.PrisonerList.Add(p6.PrisonerId, p6);

            Program.PrisonerList.Add(p7.PrisonerId, p7);
            Program.PrisonerList.Add(p8.PrisonerId, p8);
            Program.PrisonerList.Add(p9.PrisonerId, p9);
            Program.PrisonerList.Add(p10.PrisonerId, p10);
            Program.PrisonerList.Add(p11.PrisonerId, p11);
            Program.PrisonerList.Add(p12.PrisonerId, p12);

            Program.PrisonerList.Add(p13.PrisonerId, p13);
            Program.PrisonerList.Add(p14.PrisonerId, p14);
            Program.PrisonerList.Add(p15.PrisonerId, p15);
            Program.PrisonerList.Add(p16.PrisonerId, p16);
            Program.PrisonerList.Add(p17.PrisonerId, p17);
            Program.PrisonerList.Add(p18.PrisonerId, p18);

            Program.PrisonerList.Add(p19.PrisonerId, p19);
            Program.PrisonerList.Add(p20.PrisonerId, p20);
            Program.PrisonerList.Add(p21.PrisonerId, p21);
            Program.PrisonerList.Add(p22.PrisonerId, p22);
            Program.PrisonerList.Add(p23.PrisonerId, p23);
            Program.PrisonerList.Add(p24.PrisonerId, p24);
        }
    }
}
