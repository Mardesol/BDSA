using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void BoilerPlate()
        {
            // Arrange
            //var writer = new StringWriter();
            //Console.SetOut(writer);

            // Act
            // Program.(Metoden man vil teste)


            // Assert
            // Assert.Equal("expectedOutput!", actualOutput);
            //Assert.Equal("Hello World!", output);
        }

        [Fact]
        public void HelloWorld_Prints_Hello_World()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.HelloWorld();
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("Hello World!", output);
        }

        [Fact]
        public void Year_1600_Is_Leap_Year()
        {
            bool isLeapYear = Program.IsLeapYear(1600);
            Assert.True(isLeapYear);
        }

        [Fact]
        public void Year_1700_Is_Not_Leap_Year()
        {
            bool isLeapYear = Program.IsLeapYear(1700);
            Assert.False(isLeapYear);
        }

        [Theory]
        [InlineData("1600", "Yay")]
        [InlineData("1584", "Yay")]
        [InlineData("2000", "Yay")]
        public void Prints_Yay_If_Leap_Year(string input, string output)
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var reader = new StringReader(input);
            Console.SetIn(reader);

            //Act           
            Program.IsLeapYearUI();
            var actual = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal(output, actual);
        }

        [Theory]
        [InlineData("1803", "Nay")]
        [InlineData("1907", "Nay")]
        [InlineData("10003", "Nay")]
        public void Prints_Nay_If_Not_Leap_Year(string input, string output)
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var reader = new StringReader(input);
            Console.SetIn(reader);

            //Act           
            Program.IsLeapYearUI();
            var actual = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal(output, actual);
        }
    

    [Theory]
        [InlineData("1581", "Too old")]
        [InlineData("0", "Too old")]
        [InlineData("-1", "Too old")]
        public void Prints_Too_Old_If_Not_Leap_Year(string input, string output)
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var reader = new StringReader(input);
            Console.SetIn(reader);

            //Act           
            Program.IsLeapYearUI();
            var actual = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal(output, actual);
        }
    }
}
