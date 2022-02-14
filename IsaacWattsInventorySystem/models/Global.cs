using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacWattsInventorySystem.models
{
    public class Global
    {
        public static int maxGlobalProductID { get; set; } = 0;
        public static int maxGlobalPartID { get; set; } = 0;

        public static bool confirmationPrompt(string message)
        {
            var confirmationDialog = MessageBox.Show(message, "Confirm", MessageBoxButtons.OKCancel);
            return confirmationDialog == DialogResult.OK ? true : false;
        }

        public enum sourceType
        {
            InHouse,
            OutSource
        }
    }
}
