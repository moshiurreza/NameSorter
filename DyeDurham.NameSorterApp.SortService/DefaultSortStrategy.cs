using DyeDurham.NameSorterApp.Helper;
using DyeDurham.NameSorterApp.Interface;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace DyeDurham.NameSorterApp.SortService
{
    public class DefaultSortStrategy : ISortStrategy
    {
        // This function will sort the fullname list by its "Last Name" first, then by its given names.
        //
        // To achieve this -
        // At first it brings the last name at the first position of the string
        // This will lead to sort the strings only.
        // We will not have to consider the position of last name, given names, and number of given names.
        //
        // Sorting the name list using the native sort function of List (System.Collections.Generic.List<T>.Sort())
        // which is a hybrid of Quick Sort, Heap Sort, and Insertion sort
        //
        // After the sort is complete, moving the last name from the beginning to the end of the string

        public List<string> Sort(List<string> names)
        {
            // Brings the last name at the first position of the string
            for (int i = 0; i < names.Count(); i++)
            {
                if (NameValidationHelper.ValidateName(names[i]))
                {
                    names[i] = NamePartSwapHelper.MoveLastNameToBeginning(names[i]);
                }
            }

            //performing the sort
            names.Sort();

            // Moving the last name from the beginning to the end of the string
            for (int i = 0; i < names.Count(); i++)
            {
                if (NameValidationHelper.ValidateName(names[i]))
                {
                    names[i] = NamePartSwapHelper.MoveLastNameToEnd(names[i]);
                }
            }
            
            return names;
        }

    }
}
