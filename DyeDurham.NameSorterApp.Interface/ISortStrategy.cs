using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurham.NameSorterApp.Interface
{
    public interface ISortStrategy
    {
        List<string> Sort(List<string> names);
    }
}
