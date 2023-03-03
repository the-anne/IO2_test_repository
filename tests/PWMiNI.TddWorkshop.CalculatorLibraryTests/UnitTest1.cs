using PWMiNI.TddWorkshop.CalculatorLibrary;

namespace PWMiNI.TddWorkshop.CalculatorLibraryTests
{
    public class UnitTest1
    {
        private readonly StringCalculator stringCalculator = new StringCalculator();

        [Fact]
        public void Test_WhenEmptyStringProvidedItShouldReturnZero()
        {
            Assert.Equal(0, stringCalculator.Add(""));
        }

        [Theory]
        [InlineData("2", 2)]
        [InlineData("5", 5)]
        [InlineData("-10", -10)]
        [InlineData("0", 0)]
        public void Test_WhenSingleNumberProvidedItShouldReturnThisNumber(string input, int expected)
        {
            Assert.Equal(expected, stringCalculator.Add(input));
        }
    }
}