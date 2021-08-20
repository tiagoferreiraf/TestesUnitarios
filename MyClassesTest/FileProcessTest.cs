using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestesUnitarios;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");
            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Regedit.exe");
            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            //TODO
            Assert.Inconclusive();
        }
    }
}
