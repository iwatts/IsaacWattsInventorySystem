using System.ComponentModel.DataAnnotations;

namespace IsaacWattsInventorySystem.models
{
    public static class Globals
    {
        public static int maxGlobalProductID { get; set; } = 3;
        public static int maxGlobalPartID { get; set; } = 6;

        public static List<ValidationResult> validationResults = new List<ValidationResult>();

        public static bool confirmationPrompt(string message)
        {
            var confirmationDialog = MessageBox.Show(message, "Confirm", MessageBoxButtons.OKCancel);
            return confirmationDialog == DialogResult.OK ? true : false;
        }

        public static bool partialStringMatch(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        public static bool validateObject<T>(T objectToValidate)
        {
            ValidationContext vc = new ValidationContext(objectToValidate);

            bool isValid = Validator.TryValidateObject(objectToValidate, vc, validationResults, true);
            return isValid;
        }

        public static void errorListMessage()
        {
            string errorMessage = string.Join("\n", validationResults);
            MessageBox.Show(errorMessage);
        }

    }
}
