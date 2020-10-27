using NUnit.Framework;

namespace UnitTest.Tests
{
    public class DataDrivenTests
    {
        /*
         * Testando vários cenários na mesma classe.
         */
        [Test]
        [TestCase(10, 5)]
        [TestCase(8, 4)]
        [TestCase(50, 25)]
        public void ValidateDivision(int number1, int number2)
        {
            var remainder = number1 / number2;
            var expectedValue = 2;

            Assert.That(remainder, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase(10, 5, ExpectedResult = 2)]
        [TestCase(8, 8, ExpectedResult = 1)]
        [TestCase(15, 3, ExpectedResult = 5)]
        public int ValidateDivision_ExpectedResult(int number1, int number2)
        {
            return number1 / number2;
        }

        /*
         * Testando vários cenários utilizando um arquivo externo como base.
         */
        [Test]
        [TestCaseSource(typeof(CentralizedTests), nameof(CentralizedTests.TestCasesDataDriven))]
        public void ValidateDivision_Centralized(int number1, int number2)
        {
            var remainder = number1 / number2;
            var expectedValue = 2;

            Assert.That(remainder, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCaseSource(typeof(CentralizedTests), nameof(CentralizedTests.TestCasesDataDrivenReturn))]
        public int ValidateDivision_ExpectedResult_centralized(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
