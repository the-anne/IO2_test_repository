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
    }
}