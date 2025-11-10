# Name Sorter

A lightweight .NET Core console application that sort names. The names are sort by last name, then its given name(s)



## Installation

### Clone the repo and restore dependencies:

[PS] git clone https://github.com/moshiurreza/NameSorter.git

[PS] cd NameSorter

[PS] dotnet restore

[PS] dotnet build .\NameSorter.sln




## Usage

### Run the application:

#### Option 1:
[PS] cd DyeDurham.NameSorterApp\bin\Debug\net8.0

Place your file with unsorted names at this path. For example - unsorted-names-list.txt
You can find some sample files with unsorted name files in NameSorter\Docs\SampleTestFiles

To run the application - 

[PS] .\DyeDurham.NameSorterApp .\unsorted-names-list.txt

if you wish not to use .\ at the beginging, the add the full path of "NameSorter\DyeDurham.NameSorterApp\bin\Debug\net8.0" to env path variable.

This will sort the names, print the sorted names in console, and create/recreate sorted-names-list.txt with the sorted names

#### Option 2:
You are in folder "NameSorter"
Place your file with unsorted names at this path. For example - unsorted-names-list.txt
You can find some sample files with unsorted name files in NameSorter\Docs\SampleTestFiles

[PS] dotnet run --project DyeDurham.NameSorterApp .\unsorted-names-list.txt



## Tests

You are in folder "NameSorter"

Run unit tests for DyeDurham.NameSorterApp.SortService with:

[PS] dotnet test DyeDurham.NameSorterApp.SortService.Tests

Run unit tests for DyeDurham.NameSorterApp.Helper with:

[PS] dotnet test DyeDurham.NameSorterApp.Helper.Tests

Run integration tests for DyeDurham.NameSorterApp.FileService with:

[PS] dotnet test DyeDurham.NameSorterApp.FileService.Tests



## Build Status

https://ci.appveyor.com/project/MoshiurRahmanReza/namesorter

