using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTest.Tests
{
    public class AssertTests
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
        public void CompareWrongYears()
        {
            var year = DateTime.Now.Year;
            var actualYear = 2021;

            Assert.That(year, Is.Not.EqualTo(actualYear));
        }

        [Test]
        public void CompareEquality()
        {
            var x = new List<int> { 1, 2 };
            var y = x;
            var z = new List<int> { 1, 2 };

            Assert.That(y, Is.SameAs(x));
            Assert.That(z, Is.Not.SameAs(x));
        }

        [Test]
        public void CompareDouble()
        {
            double a = 1.0 / 3.0;

            Assert.That(a, Is.EqualTo(0.33).Within(0.004));
            Assert.That(a, Is.EqualTo(0.33).Within(10).Percent);
        }

        [Test]
        public void NotAllowedZeroValue()
        {
            Assert.That(() => new Base(0), Throws.TypeOf<ArgumentOutOfRangeException>());

            Assert.That(() => new Base(0), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With
                .Property("Message")
                .EqualTo("The value must be higher than 0. (Parameter 'value')"));
        }

        [Test]
        public void CheckNullOrEmpty()
        {
            string name = "Unit Test";

            Assert.That(name, Is.Not.Empty);
            Assert.That(name, Is.EqualTo("Unit Test"));
            Assert.That(name, Is.EqualTo("UNIT TEST").IgnoreCase);
            Assert.That(name, Does.StartWith("Unit").And.EndWith("Test"));
        }

        [Test]
        public void CheckBool()
        {
            bool check = false;

            Assert.That(check == false);
            Assert.That(check, Is.False);
            Assert.That(check, Is.Not.True);
        }

        [Test]
        public void CheckIntAndRanges()
        {
            int value = 8;

            Assert.That(value, Is.GreaterThan(7));
            Assert.That(value, Is.GreaterThanOrEqualTo(8));
            Assert.That(value, Is.InRange(7, 9));
        }

        [Test]
        public void CheckDates()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Now.AddDays(3);

            Assert.That(date1, Is.EqualTo(date2).Within(5).Days);
        }
    }
}
