using DyeDurham.NameSorterApp.Interface;

namespace DyeDurham.NameSorterApp.SortService
{
    public class AdvancedSortStrategy : ISortStrategy
    {
        // We can implemet custom algorithm for larger amount of data
        List<string> ISortStrategy.Sort(List<string> names)
        {
            throw new NotImplementedException();
        }
    }
}
