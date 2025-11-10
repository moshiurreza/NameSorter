// See https://aka.ms/new-console-template for more information
using DyeDurham.NameSorterApp.Common;
using DyeDurham.NameSorterApp.FileService;
using DyeDurham.NameSorterApp.Helper;
using DyeDurham.NameSorterApp.SortService;
using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;

#region User Inupt Validation

if (!(args is not null && args.Length > 0))
{
    Console.WriteLine(Constants.Messages.FileNameNotProvided);
    return;
}

#endregion

#region Variables

FileService fileService = new FileService();
IList<string> nameIlist = new List<string>();

#endregion

#region Read Names From File

try
{    
    var filePath = Path.Combine(Constants.Paths.SourceBasePath, args[0]);
    nameIlist = fileService.ReadLines(filePath);
}
catch (FileNotFoundException fnfEx)
{
    Console.WriteLine($"{fnfEx.Message}");
    return;
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
    return;
}

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

    var fullDestinationFilepath = Path.GetRelativePath(Constants.Paths.DestinationBasePath, Constants.Paths.DestinationFileName);
    fileService.WriteLinesToFile(fullDestinationFilepath, names);

    #endregion

}
else
{
    Console.WriteLine(Constants.Messages.NoNamesToSort);
}

