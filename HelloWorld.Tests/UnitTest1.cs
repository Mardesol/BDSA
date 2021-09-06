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

        [Fact]
        public void Main_prints_Hello_World()
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
    }
}