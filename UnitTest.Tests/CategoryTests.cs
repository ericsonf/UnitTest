using System;
using NUnit.Framework;

namespace UnitTest.Tests
{
    public class CategoryTests
    {
        [Test]
        [Category("Years Category")]
        public void CompareYears()
        {
            var year = DateTime.Now.Year;
            var actualYear = 2020;

            Assert.That(year, Is.EqualTo(actualYear), "Year must be 2020.");
        }

        [Test]
        [Ignore("Test to be ignore.")]
        public void CompareWrongYears()
        {
            var year = DateTime.Now.Year;
            var actualYear = 2021;

            Assert.That(year, Is.Not.EqualTo(actualYear));
        }
    }
}
