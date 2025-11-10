using FluentAssertions;

namespace DyeDurham.NameSorterApp.Helper.Tests
{
    public class NamePartSwapHelperTest
    {
        [Theory]
        [InlineData("Melissa Ward", "Ward Melissa")]
        [InlineData("Sandra Daniel Reed", "Reed Sandra Daniel")]        
        public void NamePartSwapHelper_MoveLastNameToBeginning_ReturnsString(string fullName, string expected)
        {
            //Arrange 
            
            //Act 
            var result = NamePartSwapHelper.MoveLastNameToBeginning(fullName);

            //Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("Ward Melissa", "Melissa Ward")]
        [InlineData("Reed Sandra Daniel", "Sandra Daniel Reed")]
        public void NamePartSwapHelper_MoveLastNameToEnd_ReturnsString(string fullName, string expected)
        {
            //Arrange 

            //Act 
            var result = NamePartSwapHelper.MoveLastNameToEnd(fullName);

            //Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().Be(expected);
        }
    }
}