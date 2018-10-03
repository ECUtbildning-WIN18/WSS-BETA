

namespace WSS
{
    class Device
    {
        public Device()
        {
            
        }

        public Device(Prisoner owner)
        {
            Owner = owner;
        }

        public int BatteryPower { get; set; } = 100;

        public bool MateInRange { get; set; } = false;

        public Prisoner Owner { get; set; }

        public int DeviceMateID { get; }

        public static void BlowUp(Prisoner prisoner)
        {
           //prisoner.IsAlive = false;
        }
    }
}
