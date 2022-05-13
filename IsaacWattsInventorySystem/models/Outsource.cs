using System.ComponentModel;

namespace IsaacWattsInventorySystem.models
{
    class Outsource : Part
    {
        public string CompanyName { get; set; }

        public static BindingList<Outsource> outsourceParts = new BindingList<Outsource>();

        static Outsource()
        {
            outsourceParts.Add(new Outsource
            {
                PartID = 3,
                Name = "Cog",
                Price = 11.00m,
                InStock = 3,
                Min = 1,
                Max = 5,
                CompanyName = "Something Metal Inc"
            });
            outsourceParts.Add(new Outsource
            {
                PartID = 4,
                Name = "Nut",
                Price = 10.00m,
                InStock = 13,
                Min = 1,
                Max = 4,
                CompanyName = "Something Metal Inc"
            });
            outsourceParts.Add(new Outsource
            {
                PartID = 5,
                Name = "Bolt",
                Price = 12.00m,
                InStock = 30,
                Min = 1,
                Max = 3,
                CompanyName = "Something Metal Inc"
            });

        }
    }
}
