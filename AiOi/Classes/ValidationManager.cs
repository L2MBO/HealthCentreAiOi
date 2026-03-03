using System.Linq;

namespace AiOi.Classes
{
    internal class ValidationManager
    {
        private static bool FieldsAreEmpty(params string[] fields)
        {
            return fields.Any(string.IsNullOrWhiteSpace);
        }

        public static bool ValidationHelper(params string[] fields)
        {
            if (FieldsAreEmpty(fields))
            {
                MessageHelper.ShowErrorMessage("Пожалуйста заполните все поля!");
                return true;
            }

            return false;
        }
    }
}
