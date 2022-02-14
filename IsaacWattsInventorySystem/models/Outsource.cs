using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacWattsInventorySystem.models
{
    class Outsource : Part
    {
        public string CompanyName { get; set; }

        public static BindingList<Outsource> outsourceParts = new BindingList<Outsource>();
    }
}
