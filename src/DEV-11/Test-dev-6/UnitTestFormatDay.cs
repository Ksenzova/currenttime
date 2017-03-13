using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;
using static DEV_6.Program;
using System.Globalization;

namespace Test_dev_6
{

    [TestClass]
    public class UnitTestFormatDay
    {
        [TestMethod]
        public void TestYearForm_d()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatDay());
            Format formate = Format.d;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("d");

            Assert.AreEqual(right, formateDate);
        }

        [TestMethod]
        public void TestYearForm_dd()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatDay());
            Format formate = Format.dd;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("dd");

            Assert.AreEqual(right, formateDate);
        }
        [TestMethod]
        public void TestYearForm_ddd()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatDay());
            Format formate = Format.ddd;
            string formateDate = formater.GetData(curDate, formate);
            string right = curDate.ToString("ddd", CultureInfo.CreateSpecificCulture("en-US"));
            Assert.AreEqual(right, formateDate);
        }
        [TestMethod]
        public void TestYearForm_dddd()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatDay());
            Format formate = Format.dddd;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("dddd", CultureInfo.CreateSpecificCulture("en-US"));

            Assert.AreEqual(right, formateDate);
        }
    }
}
