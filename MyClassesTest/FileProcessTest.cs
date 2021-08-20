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
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }
        [TestMethod]
        
        public void FileNameNullOrEmpty_ThrowsArgumentNullException_UsingTryCatch()
        {
            FileProcess fp = new FileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (Exception)
            {
                //The test was a sucess.
                return;
            }
            Assert.Fail("Fail expected");
        }

    }
}
