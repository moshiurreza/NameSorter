// See https://aka.ms/new-console-template for more information
using DyeDurham.NameSorterApp.Common;
using DyeDurham.NameSorterApp.FileService;
using DyeDurham.NameSorterApp.Helper;
using DyeDurham.NameSorterApp.SortService;
using System.Collections.Immutable;
using System.Reflection.Metadata;

#region User Inupt Validation



#endregion

#region Read Names From File

FileService fileService = new FileService();
var nameIlist = fileService.ReadLines(Path.GetRelativePath(".", "unsorted-names-list.txt"));

#endregion

if (nameIlist != null && nameIlist.Count > 0)
{
    #region Sort Names

    var names = nameIlist.ToList<String>();

    var sorter = new SortService();
    sorter.SetStrategy(new DefaultSortStrategy());
    sorter.Sort(names);

    #endregion

    #region Print Sorted Names to Console

    foreach (var name in names)
    {
        Console.WriteLine(name);
    }

    #endregion

    #region Write Sorted Names to File

    var fullDestinationFilepath = Path.GetRelativePath(Constants.Paths.DestinationPath, Constants.Paths.DestinationFileName);
    fileService.WriteLinesToFile(fullDestinationFilepath, names);

    #endregion

}

