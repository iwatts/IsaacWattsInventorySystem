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

        static InHouse()
        {
            inhouseParts.Add(new InHouse
            {
                PartID = 0,
                Name = "Spring",
                Price = 12.00f,
                InStock = 3,
                Min = 1,
                Max = 5,
                SourceType = Globals.sourceType.InHouse,
                MachineID = 112
            });
            inhouseParts.Add(new InHouse
            {
                PartID = 1,
                Name = "Gear",
                Price = 12.00f,
                InStock = 3,
                Min = 1,
                Max = 5,
                SourceType = Globals.sourceType.InHouse,
                MachineID = 1138
            });
            inhouseParts.Add(new InHouse
            {
                PartID = 2,
                Name = "Pipe",
                Price = 12.00f,
                InStock = 3,
                Min = 1,
                Max = 5,
                SourceType = Globals.sourceType.InHouse,
                MachineID = 110
            });

        }
    }
}
