using System.Collections;
using NUnit.Framework;

namespace UnitTest.Tests
{
    public class CentralizedTests
    {
        public static IEnumerable TestCasesDataDriven
        {
            get
            {
                yield return new TestCaseData(10, 5);
                yield return new TestCaseData(8, 4);
                yield return new TestCaseData(50, 25);
            }
        }

        public static IEnumerable TestCasesDataDrivenReturn
        {
            get
            {
                yield return new TestCaseData(10, 5).Returns(2);
                yield return new TestCaseData(8, 8).Returns(1);
                yield return new TestCaseData(15, 3).Returns(5);
            }
        }
    }
}
