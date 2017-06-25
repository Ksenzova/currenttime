using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;
using static DEV_6.Program;

namespace Test_dev_6
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Test not valid format
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNotVAlodInputFormat()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatYear());
            Format formate = (Format)Enum.Parse(typeof(Format), "error");
        }

    }
}
