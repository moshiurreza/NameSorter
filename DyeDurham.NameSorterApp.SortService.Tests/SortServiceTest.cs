using FakeItEasy;
using FluentAssertions;
using DyeDurham.NameSorterApp.SortService;

namespace DyeDurham.NameSorterApp.SortService.Tests
{
    public class SortServiceTest
    {
        [Fact]
        public void SortService_Sort_ReturnVoid()
        {
            // Arrange
            List<string> names = new List<string>() {
                "Melissa Ward",                
                "Joshua Nguyen",
                "Sandra Daniel Reed",
                "Karen Howard",
                "Angela Rivera"                
                };

            SortService sorter = new SortService();
            sorter.SetStrategy(new DefaultSortStrategy());
            
            // Act
            sorter.Sort(names);

            // Assert
            names[0].Should().Be("Karen Howard");
            names[1].Should().Be("Joshua Nguyen");
            names[2].Should().Be("Sandra Daniel Reed");
            names[3].Should().Be("Angela Rivera");
            names[4].Should().Be("Melissa Ward");
        }
    }
}