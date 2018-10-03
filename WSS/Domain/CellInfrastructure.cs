using System.Linq;

namespace WSS.Domain
{
    class CellInfrastructure
    {
        public static void AddAllCells()
        {
            Program.CellsList.Add(new PrisonCells("A", "1", 1, true, false, Program.PrisonerList["0001"]));
            Program.CellsList.Add(new PrisonCells("A", "2", 1, true, false, Program.PrisonerList["0002"]));
            Program.CellsList.Add(new PrisonCells("A", "3", 1, true, false, Program.PrisonerList["0003"]));
            Program.CellsList.Add(new PrisonCells("A", "4", 1, true, false, Program.PrisonerList["0004"]));
            Program.CellsList.Add(new PrisonCells("A", "5", 1, true, false, Program.PrisonerList["0005"]));
            Program.CellsList.Add(new PrisonCells("A", "6", 1, true, false, Program.PrisonerList["0006"]));

            Program.CellsList.Add(new PrisonCells("B", "1", 1, true, false, Program.PrisonerList["0001"]));
            Program.CellsList.Add(new PrisonCells("B", "2", 1, true, false, Program.PrisonerList["0003"]));
            Program.CellsList.Add(new PrisonCells("B", "3", 1, true, false, Program.PrisonerList["0002"]));
            Program.CellsList.Add(new PrisonCells("B", "4", 1, true, false, Program.PrisonerList["0005"]));
            Program.CellsList.Add(new PrisonCells("B", "5", 1, true, false, Program.PrisonerList["0003"]));
            Program.CellsList.Add(new PrisonCells("B", "6", 1, true, false, Program.PrisonerList["0004"]));

            Program.CellsList.Add(new PrisonCells("C", "1", 1, true, false, Program.PrisonerList["0005"]));
            Program.CellsList.Add(new PrisonCells("C", "2", 1, true, false, Program.PrisonerList["0001"]));
            Program.CellsList.Add(new PrisonCells("C", "3", 1, true, false, Program.PrisonerList["0005"]));
            Program.CellsList.Add(new PrisonCells("C", "4", 1, true, false, Program.PrisonerList["0003"]));
            Program.CellsList.Add(new PrisonCells("C", "5", 1, true, false, Program.PrisonerList["0002"]));
            Program.CellsList.Add(new PrisonCells("C", "6", 1, true, false, Program.PrisonerList["0006"]));

            Program.CellsList.Add(new PrisonCells("D", "1", 1, true, false, Program.PrisonerList["0005"]));
            Program.CellsList.Add(new PrisonCells("D", "2", 1, true, false, Program.PrisonerList["0002"]));
            Program.CellsList.Add(new PrisonCells("D", "3", 1, true, false, Program.PrisonerList["0001"]));
            Program.CellsList.Add(new PrisonCells("D", "4", 1, true, false, Program.PrisonerList["0005"]));
            Program.CellsList.Add(new PrisonCells("D", "5", 1, true, false, Program.PrisonerList["0006"]));
            Program.CellsList.Add(new PrisonCells("D", "6", 1, true, false, Program.PrisonerList["0005"]));
        }
    }
}
