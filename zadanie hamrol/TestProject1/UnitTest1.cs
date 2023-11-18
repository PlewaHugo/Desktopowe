using zadanie_hamrol.Core.Services;
using zadanie_hamrol.Shared.Entities;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string textWithLetters = "Hello123";
            string textWithNumbers = "123456";
            string textWithSpecialCharacters = "πÍÛüøúÊ• ”èØå∆";
            string textWithoutLettersNumbersOrSpecial = "!@#$%^&*()";

            TextAnalyzerService analyzer = new TextAnalyzerService();

        
            TextAnalyzeResult resultWithLetters = analyzer.PerformAnalysis(textWithLetters);
            TextAnalyzeResult resultWithNumbers = analyzer.PerformAnalysis(textWithNumbers);
            TextAnalyzeResult resultWithSpecial = analyzer.PerformAnalysis(textWithSpecialCharacters);
            TextAnalyzeResult resultWithoutLettersNumbersOrSpecial = analyzer.PerformAnalysis(textWithoutLettersNumbersOrSpecial);

            Assert.True(resultWithLetters.hasLetter);
            Assert.True(resultWithLetters.hasNumber);
            Assert.True(resultWithLetters.hasSpecial);

            Assert.False(resultWithNumbers.hasLetter);
            Assert.True(resultWithNumbers.hasNumber);
            Assert.False(resultWithNumbers.hasSpecial);

            Assert.True(resultWithSpecial.hasLetter);
            Assert.False(resultWithSpecial.hasNumber);
            Assert.True(resultWithSpecial.hasSpecial);

            Assert.False(resultWithoutLettersNumbersOrSpecial.hasLetter);
            Assert.False(resultWithoutLettersNumbersOrSpecial.hasNumber);
            Assert.False(resultWithoutLettersNumbersOrSpecial.hasSpecial);
        }
    }
}