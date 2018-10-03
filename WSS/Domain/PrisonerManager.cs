using WSS.Domain;

namespace WSS
{
    class PrisonerManager
    {
        public static void LinkPrisonerToCell(Prisoner prisoner, PrisonCells cell)
        {
           //cell.Inmates.Add(prisoner);
        }

        public static void LinkPrisonerToDevice(Prisoner prisoner, Device device)
        {
            prisoner = device.Owner;
        }

        public void AddPrisoner(string prisonerId, string name)
        {
            Program.PrisonerList.Add(prisonerId, new Prisoner(prisonerId, name));
        }

        public void RemovePrisoner(string prisonerId)
        {
            Program.PrisonerList.Remove(prisonerId);
        }
    }
}
