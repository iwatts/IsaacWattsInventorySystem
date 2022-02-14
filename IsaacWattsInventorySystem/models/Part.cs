using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacWattsInventorySystem.models
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Global.sourceType SourceType { get; set; }

        public static BindingList<Part> parts = new BindingList<Part>();

        static Part()
        {
            foreach (InHouse part in InHouse.inhouseParts)
            {
                parts.Add(part);
            }
            foreach (Outsource part in Outsource.outsourceParts)
            {
                parts.Add(part);
            }

        }
    }
}
