using Xunit;
using CAMC.Temperatura;

namespace CAMC.Temperatura.UnitTest
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseStringTest()
        {
            // Arrange
            var sm = new StringManipulator();

            // Act
            string r1 = sm.ReverseString("casa");
            string r2 = sm.ReverseString("A");
            string r3 = sm.ReverseString(string.Empty);
            string r4 = sm.ReverseString("reconocer"); // palíndromo

            // Assert
            Assert.Equal("asac", r1);
            Assert.Equal("A", r2);
            Assert.Equal(string.Empty, r3);
            Assert.Equal("reconocer", r4);
        }

        [Fact]
        public void RemoveSpacesTest()
        {
            // Arrange
            var sm = new StringManipulator();

            // Act
            string r1 = sm.RemoveSpaces("hola mundo");
            string r2 = sm.RemoveSpaces("  a b  c   ");
            string r3 = sm.RemoveSpaces(string.Empty);
            string r4 = sm.RemoveSpaces("a\t b\n c"); // tabs/newlines se conservan

            // Assert
            Assert.Equal("holamundo", r1);
            Assert.Equal("abc", r2);
            Assert.Equal(string.Empty, r3);
            Assert.Equal("a\tb\nc", r4);
        }
    }
}
