using System.IO;
using System.Xml.Linq;

namespace DyeDurham.NameSorterApp.Common
{
    public static class Constants
    {
        public static class Paths
        {
            public const string SourceBasePath = @".";
            public const string DestinationBasePath = @".";
            public const string DestinationFileName = @"sorted-names-list.txt";
        }

        public static class Messages
        {
            public const string FileNameNotProvided = "File name not provided.";
            public const string FileNotFound = "File not found.";
            public const string FilePathCannotBeNullOrEmpty = "File path cannot be null or empty.";
            public const string NoSortingStrategySelected = "No sorting strategy selected.";
            public const string NoNamesToSort = "No names to sort!";
        }
    }

}
