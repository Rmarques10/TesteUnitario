using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;
using System;

namespace MyClassTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExists()
        {
            FileProcess fp = new FileProcess();

            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\addins\FXSEXT.ecf");
            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();

            bool fromCall;

            fromCall = fp.FileExists(@"C:\FXSEXT.ecf");
            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_throwArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }
        [TestMethod]
        public void FileNameNullOrEmpty_throwArgumentNullException_UsingTryCath()
        {
            FileProcess fp = new FileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                //the test was a Success.
                return;
            }

            Assert.Fail("Fail expected");
        }
    }
}
