using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WSS.Domain;

namespace WSS
{
    class PrisonerManager
    {
        public static void LinkPrisonerToCell(Prisoner prisoner, PrisonCells cell)
        {
           cell.Inmates.Add(prisoner);
        }

        public static void LinkPrisonerToDevice(Prisoner prisoner, Device device)
        {
            prisoner = device.Owner;
        }

        public void AddPrisoner(string socialSecurityNumber, string firstName, string lastName, DateTime birthDate)
        {
            Program.PrisonerList.Add(socialSecurityNumber, new Prisoner(socialSecurityNumber, firstName, lastName, birthDate));
        }

        public void RemovePrisoner(string socialSecurityNumber)
        {
            Program.PrisonerList.Remove(socialSecurityNumber);
        }
    }
}
