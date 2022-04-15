using System.ComponentModel;

namespace IsaacWattsInventorySystem.models
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Globals.sourceType SourceType { get; set; }

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
