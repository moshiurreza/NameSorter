using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurham.NameSorterApp.Helper
{
    public class NameValidationHelper
    {
        // Validating a fullname.
        // To be a eligible fullname -
        // Can not be null, empty, or whitespaces
        // Should have atleast two parts, give name(s) and a last name
        // According to the requirement, given names can be maximum of 3. But there is no clrear instructions
        // about invalid names, like remove it from the list or put those at the end or ignore. 
        // the items are not ignored with more than 3 given names
        public static bool ValidateName(String fullName)
        {
            if (!String.IsNullOrEmpty(fullName.Trim()) &&
                fullName.Trim().Split(' ').Count() > 1)
            { 
                return true;
            }
            
            return false;
        }
    }
}
