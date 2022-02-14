using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacWattsInventorySystem.models
{
    class InHouse : Part
    {
        public int MachineID { get; set; }

        public static BindingList<InHouse> inhouseParts = new BindingList<InHouse>();
    }
}
