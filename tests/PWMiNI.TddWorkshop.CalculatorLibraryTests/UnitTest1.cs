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

        [Theory]
        [InlineData("2,3", 5)]
        [InlineData("5,0", 5)]
        [InlineData("-10,7", -3)]
        [InlineData("-2,4", 2)]
        [InlineData("-2,2", 0)]
        public void Test_WhenTwoNumbersCommaSeparatedProvidedItShouldReturnTheSum(string input, int expected)
        {
            Assert.Equal(expected, stringCalculator.Add(input));
        }

        [Theory]
        [InlineData("2\n3", 5)]
        [InlineData("5\n0", 5)]
        [InlineData("-10\n7", -3)]
        [InlineData("-2\n4", 2)]
        [InlineData("-2\n2", 0)]
        public void Test_WhenTwoNumbersNewlineSeparatedProvidedItShouldReturnTheSum(string input, int expected)
        {
            Assert.Equal(expected, stringCalculator.Add(input));
        }
    }
}