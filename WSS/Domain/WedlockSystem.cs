using System;
using System.Collections.Generic;
using System.Text;

namespace WSS.Domain
{
    class WedlockSystem
    {
        public string WedlockId { get; set; }
        public Prisoner Prisoner1 { get; set; }
        public Prisoner Prisoner2 { get; set; }

        public WedlockSystem(string wedlockid, Prisoner prisoner1, Prisoner prisoner2)
        {
            WedlockId = wedlockid;
            Prisoner1 = prisoner1;
            Prisoner2 = prisoner2;
        }
    }
}
