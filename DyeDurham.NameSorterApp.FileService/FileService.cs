using DyeDurham.NameSorterApp.Common;
using DyeDurham.NameSorterApp.Interface;

namespace DyeDurham.NameSorterApp.FileService
{
    public class FileService : IFileService
    {
        public FileService()
        { 
        }

        // Read the file content asynchronously. This will not put any load in the memory.
        // More suitable for very large file.
        public async IAsyncEnumerable<string> ReadLinesAsync(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(Constants.Messages.FileNotFound, filePath);

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = await reader.ReadLineAsync();
                        if (line != null)
                            yield return line;
                    }
                }
            }
        }

        // Read the file content quickly at once, in memory.
        // More suitable for small files.
        public IList<string> ReadLines(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(Constants.Messages.FileNotFound, filePath);


            IList<string> lines = new List<string>();

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        lines.Add(reader.ReadLine());
                    }
                }
            }

            return lines;
        }

        // Write the file content asynchronously. This will not put any load in the memory.
        // More suitable for very large file.
        public async Task WriteLinesToFileAsync(string filePath, IEnumerable<string> lines)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException(Constants.Messages.FilePathCannotBeNullOrEmpty, nameof(filePath));

            if (lines == null)
                throw new ArgumentNullException(nameof(lines));

            using var writer = new StreamWriter(filePath, append: false);
            foreach (var line in lines)
            {
                await writer.WriteLineAsync(line);
            }
        }


        // Write the file content quickly at once, in memory.
        // More suitable for small files.
        public void WriteLinesToFile(string filePath, IEnumerable<string> lines)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException(Constants.Messages.FilePathCannotBeNullOrEmpty, nameof(filePath));

            if (lines == null)
                throw new ArgumentNullException(nameof(lines));

            File.WriteAllLines(filePath, lines);
        }
    }
}
