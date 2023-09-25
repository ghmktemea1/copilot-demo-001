using Xunit;

namespace GitHub.Demo.App.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var expected = "Hello, World!";

            // Act
            var actual = Program.GetMessage();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}