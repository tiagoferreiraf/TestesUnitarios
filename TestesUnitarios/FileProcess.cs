using System;
using System.IO;

namespace TestesUnitarios
{
    public class FileProcess
    {
        public Boolean FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(fileName);
        }
    }
}
