using DyeDurham.NameSorterApp.Interface;
using DyeDurham.NameSorterApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace DyeDurham.NameSorterApp.SortService
{
    public class SortService
    {
        private ISortStrategy _sortStrategy;

        public void SetStrategy(ISortStrategy strategy)
        {
            _sortStrategy = strategy;
        }

        public void Sort(List<string> names)
        {
            if (_sortStrategy == null)
            {
                throw new Exception(Constants.Messages.NoSortingStrategySelected);
            }

            _sortStrategy.Sort(names);
        }

    }
}
