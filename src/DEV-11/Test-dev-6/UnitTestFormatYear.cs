using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;
using static DEV_6.Program;
using System.Globalization;

namespace Test_dev_6
{
  
    [TestClass]
    public class UnitTestFormatYear
    {

        [TestMethod]
        public void TestYearForm_yyyy()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatYear());
            Format formate = Format.yyyy;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("yyyy");

            Assert.AreEqual(right, formateDate);
        }

        [TestMethod]
        public void TestYearForm_yyy()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatYear());
            Format formate = Format.yyy;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("yyy");

            Assert.AreEqual(right, formateDate);
        }

        [TestMethod]
        public void TestYearForm_yy()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatYear());
            Format formate = Format.yy;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("yy");

            Assert.AreEqual(right, formateDate);
        }

        [TestMethod]
        public void TestYearForm_y()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatYear());
            Format formate = Format.y;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("%y");

            Assert.AreEqual(right, formateDate);
        }

    }
}
