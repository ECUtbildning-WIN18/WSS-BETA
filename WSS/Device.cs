using System;
using System.Collections.Generic;
using System.Text;

namespace WSS
{
    class Device
    {
        public int BatteryPower { get; set; } = 100;

        public bool MateInRange { get; set; } = false;

        public Prisoner Owner { get; set; }

        public int DeviceMateID { get; }

        public static void BlowUp(Prisoner prisoner)
        {
            prisoner.IsAlive = false;
        }

    }
}
