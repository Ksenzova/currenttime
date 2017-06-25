using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_6;
using static DEV_6.Program;
using System.Globalization;
using DEV_11;

namespace Test_dev_6
{
    [TestClass]
    public class UnitTestFormatMonth
    {
        [TestMethod]
        public void TestMonthForm_MM()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatMonth());
            Format formate = Format.MM;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("MM", CultureInfo.CreateSpecificCulture("en-US"));

            Assert.AreEqual(right, formateDate);
        }

        [TestMethod]
        public void TestMonthForm_MMM()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatMonth());
            Format formate = Format.MMM;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("MMM", CultureInfo.CreateSpecificCulture("en-US"));

            Assert.AreEqual(right, formateDate);
        }

        [TestMethod]
        public void TestMonthForm_MMMM()
        {
            DateTime curDate = DateTime.Now;
            Formater formater = new Formater(new FormatMonth());
            Format formate = Format.MMMM;
            string formateDate = formater.GetData(curDate, formate);

            string right = curDate.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US"));

            Assert.AreEqual(right, formateDate);
        }
    }      
}

