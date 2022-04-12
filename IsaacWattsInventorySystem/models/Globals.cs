using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacWattsInventorySystem.models
{
    public static class Globals
    {
        public static int maxGlobalProductID { get; set; } = 3;
        public static int maxGlobalPartID { get; set; } = 6;

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

        public static bool partialStringMatch(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
