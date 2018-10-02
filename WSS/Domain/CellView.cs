using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class CellView
    {
        public static void View()
        {
            Console.Clear();
            ViewCells();
            Console.ReadKey();
            Console.WriteLine("Press key to continue...");
            MenuMessages.InfrastructureMenu();
        }

        static void ViewCells()
        {
            foreach (var cell in Program.CellsList)
            {
                if (cell.Block.Contains("A"))
                    Console.Write($"{cell.PrisonerSlot} {cell.Prisoner.Name}   ");
            }
            Console.WriteLine();

            foreach (var cell in Program.CellsList)
            {
                if (cell.Block.Contains("B"))
                    Console.Write($"{cell.PrisonerSlot} {cell.Prisoner.Name}   ");
            }
            Console.WriteLine();

            foreach (var cell in Program.CellsList)
            {
                if (cell.Block.Contains("C"))
                    Console.Write($"{cell.PrisonerSlot} {cell.Prisoner.Name}   ");
            }
            Console.WriteLine();

            foreach (var cell in Program.CellsList)
            {
                if (cell.Block.Contains("D"))
                    Console.Write($"{cell.PrisonerSlot} {cell.Prisoner.Name}   ");
            }
        }
    }
}
