using System.IO;

namespace DyeDurham.NameSorterApp.Common
{
    public static class Constants
    {
        public static class Paths
        {
            public const string DestinationPath = @".";
            public const string DestinationFileName = @"sorted-names-list.txt";
        }

        public static class Messages
        {
            public const string FileNotFound = "File not found.";
            public const string FilePathCannotBeNullOrEmpty = "File path cannot be null or empty.";
            public const string NoSortingStrategySelected = "No sorting strategy selected.";
        }
    }

}
