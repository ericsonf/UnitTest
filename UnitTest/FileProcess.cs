using System;
using System.IO;

namespace UnitTest
{
    public class FileProcess
    {
        public bool FileExists(string filename)
        {
            if (string.IsNullOrEmpty(filename)) { throw new ArgumentNullException(nameof(filename)); }
            return File.Exists(filename);
        }
    }
}
