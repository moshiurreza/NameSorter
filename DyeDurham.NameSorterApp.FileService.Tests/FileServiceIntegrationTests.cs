using System.IO;
using Xunit;
using FluentAssertions;
using DyeDurham.NameSorterApp.FileService;


namespace DyeDurham.NameSorterApp.FileService.Tests
{
    public class FileServiceIntegrationTests : IDisposable
    {
        private readonly FileService _fileService;
        private readonly string _tempDir;
        private readonly string _filePath;


        public FileServiceIntegrationTests()
        {
            _fileService = new FileService();
            _tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_tempDir);
            _filePath = Path.Combine(_tempDir, "test.txt");

        }

        [Fact]
        public void WriteLinesToFile_ShouldWriteLinesCorrectly()
        {
            //Arrange
            var lines = new List<string> { "Alpha", "Beta", "Gamma" };

            //Act
            _fileService.WriteLinesToFile(_filePath, lines);

            //Assert
            File.Exists(_filePath).Should().BeTrue();
            File.ReadAllLines(_filePath).Should().BeEquivalentTo(lines);
        }

        [Fact]
        public void ReadLines_ShouldReturnCorrectLines()
        {
            //Arrange
            var expected = new List<string> { "One", "Two", "Three" };
            File.WriteAllLines(_filePath, expected);

            //Act
            var result = _fileService.ReadLines(_filePath);

            //Assert
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReadLines_ShouldThrow_WhenFileMissing()
        {
            //Arrange
            var missingPath = Path.Combine(_tempDir, "missing.txt");

            //Act
            Action act = () => _fileService.ReadLines(missingPath);

            //Assert
            act.Should().Throw<FileNotFoundException>()
               .WithMessage("*File not found*");
        }

        [Fact]
        public void WriteLinesToFile_ShouldThrow_WhenFilePathIsEmpty()
        {
            //Arrange

            //Act
            Action act = () => _fileService.WriteLinesToFile(" ", new List<string> { "Line" });

            //Assert
            act.Should().Throw<ArgumentException>()
               .WithMessage("*File path cannot be null or empty*");
        }

        [Fact]
        public void WriteLinesToFile_ShouldThrow_WhenLinesIsNull()
        {
            //Arrange

            //Act
            Action act = () => _fileService.WriteLinesToFile(_filePath, null);

            //Assert
            act.Should().Throw<ArgumentNullException>();
        }

        public void Dispose()
        {
            if (Directory.Exists(_tempDir))
                Directory.Delete(_tempDir, true);
        }

    }
}