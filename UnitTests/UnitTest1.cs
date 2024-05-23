using MainProject;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(3, 2, 5)]
        [InlineData(0, -10, -10)]
        public void AddTest(int a, int b, int expected)
        {
            //Arrange
            var helper = new Helper();

            //Act
            var actual = helper.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        public void SubtractTest(int a, int b, int expected)
        {
            //Arrange
            var helper = new Helper();

            //Act
            var actual = helper.Subtract(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Seth", "Hello, Seth!")]
        [InlineData("Mack", "Hello, Mack!")]
        [InlineData("", "Hello!")]
        [InlineData(null, "Hello!")]
        public void GreetingTest(string name, string expected)
        {
            //Arrange
            var helper = new Helper();

            //Act
            var actual = helper.Greeting(name);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}