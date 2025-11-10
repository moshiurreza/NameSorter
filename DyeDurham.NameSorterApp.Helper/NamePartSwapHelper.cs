namespace DyeDurham.NameSorterApp.Helper
{
    public static class NamePartSwapHelper
    {
        // A validated full name should be provided 
        // Full name should be validated by DyeDurham.NameSorterApp.Helper.NameValidationHelper.ValidateName(fullName) method
        // A valid name will have at least a First Name and a Last name
        public static string MoveLastNameToBeginning(String fullName)
        {
            string[] nameParts = fullName.Split(' ');
            fullName = nameParts[nameParts.Length - 1] + " " + String.Join(" ", nameParts[..(nameParts.Length - 1)]);

            return fullName;
        }

        // A validated full name should be provided 
        // Full name should be validated by DyeDurham.NameSorterApp.Helper.NameValidationHelper.ValidateName(fullName) method
        // A valid name will have at least a First Name and a Last name
        public static string MoveLastNameToEnd(String fullName)
        {
            string[] nameParts = fullName.Split(' ');
            fullName = string.Join(" ", nameParts[1..]) + " " + nameParts[0];

            return fullName;
        }
    }
}
