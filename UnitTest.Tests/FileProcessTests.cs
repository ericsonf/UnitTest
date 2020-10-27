using System;
using NUnit.Framework;

namespace UnitTest.Tests
{
    public class FileProcessTests
    {
        private FileProcess _fp;
        private bool _exists;
        private bool _notExists;

        [SetUp]
        public void Setup()
        {
            /*
             * Executa antes que cada teste da classe seja executado 
             */

            //_fp = new FileProcess();
            //_exists = _fp.FileExists(@"/Users/ericsonf/RiderProjects/UnitTest/README.md");
            //_notExists = _fp.FileExists(@"/Users/ericsonf/RiderProjects/UnitTest/NotExists.txt");
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            /*
             * Executa uma única vez antes do executar o primeiro teste da classe 
             */

            _fp = new FileProcess();
            _exists = _fp.FileExists(@"/Users/ericsonf/RiderProjects/UnitTest/README.md");
            _notExists = _fp.FileExists(@"/Users/ericsonf/RiderProjects/UnitTest/NotExists.txt");
        }

        [TearDown]
        public void TearDown()
        {
            /*
             * Executa depois que cada teste da classe seja executado 
             */

            //_fp = null;
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            /*
             * Executa depois que o último teste foi executado dentro da classe 
             */

            _fp = null;
        }

        [Test]
        public void FileNameExists()
        {
            Assert.IsTrue(_exists);
        }

        [Test]
        public void FileNameNotExists()
        {
            Assert.IsFalse(_notExists);
        }

        [Test]
        public void FileNameNullOrEmpty_ArgumentNullException()
        {
            var expectedErrorParam = "filename";
            try
            {
                _fp.FileExists("");
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual(expectedErrorParam, e.ParamName);
            }
        }

        [Test]
        public void FileNameNullOrEmpty_ThrowArgumentNullException()
        {
            try
            {
                _fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                return;
            }

            Assert.Fail("Error: File is Null or Empty");
        }

        [Test]
        public void FileNameNullOrEmpty_ThrowWithThatArgumentNullException()
        {
            Assert.That(() => _fp.FileExists(""), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void CompareEquality()
        {
            var newFp = _fp;

            Assert.That(_fp, Is.SameAs(newFp));
        }
    }
}
