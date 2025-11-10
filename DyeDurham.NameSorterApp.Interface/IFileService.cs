using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurham.NameSorterApp.Interface
{
    public interface IFileService
    {
        public IAsyncEnumerable<string> ReadLinesAsync(string filePath);
        public IList<string> ReadLines(string filePath);

        public Task WriteLinesToFileAsync(string filePath, IEnumerable<string> lines);
        public void WriteLinesToFile(string filePath, IEnumerable<string> lines);
    }
}
