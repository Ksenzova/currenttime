using DEV_12;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace UnitTestDev_12
{
    [TestClass]
    public class UnitTest
    {
        // Test parser
        [TestMethod]
        public void TestParserColour()
        {
            string inputData = "white a1 h2";
            colour coloutNeed = colour.white;
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);
            colour colourCurrent = (colour)param[0];
            Assert.AreEqual(coloutNeed, colourCurrent);
        }

        [TestMethod]
        public void TestParserCoordinateNeed()
        {
            string inputData = "white a1 h2";
            Parser parser = new Parser();
            Coordinate coordinate = new Coordinate('a', 1);
            ArrayList param = parser.GetParams(inputData);
            Coordinate parsedCoordinate = (Coordinate)param[1];

            Assert.AreEqual(coordinate.X, parsedCoordinate.X);
            Assert.AreEqual(coordinate.Y, parsedCoordinate.Y);
        }


        [TestMethod]
        public void TestParserCoordinateCurrent()
        {
            string inputData = "white a1 h2";
            Parser parser = new Parser();
            Coordinate coordinate = new Coordinate('h', 2);
            ArrayList param = parser.GetParams(inputData);
            Coordinate parsedCoordinate = (Coordinate)param[2];

            Assert.AreEqual(coordinate.X, parsedCoordinate.X);
            Assert.AreEqual(coordinate.Y, parsedCoordinate.Y);
        }

        // Test valid input
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNotValidInputColour()
        {
            string inputData = "Green l1 h2";
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);
        }

        [TestMethod]
        [ExpectedException(typeof(RegexMatchTimeoutException))]
        public void TestNotValidInputCoordinate()
        {
            string inputData = "white l1 h2";
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);
        }

        
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestNotValidNumberOfCoordinate()
        {
            string inputData = "white h2";
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNotInputData()
        {
            string inputData = "";
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);
        }

        // Test algorithm
        [TestMethod]
        public void TestWhiteChequerMoving()
        {
            Checker checker = new Checker();
            string inputData = "white d4 b8";
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);

            checker.Colour = (colour)param[0];
            checker.CoordiareCurrent = (Coordinate)param[1];
            checker.CoordinateNeed = (Coordinate)param[2];
            Counter counter = new Counter();
            int calculatedSteps = counter.GetNumberOfSteps(checker);
            int needSteps = 4;
            Assert.AreEqual(needSteps.ToString(), calculatedSteps.ToString());
        }

        [TestMethod]
        public void TestBlackChequerMoving()
        {
            Checker checker = new Checker();
            string inputData = "black d8 b2";
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);

            checker.Colour = (colour)param[0];
            checker.CoordiareCurrent = (Coordinate)param[1];
            checker.CoordinateNeed = (Coordinate)param[2];
            Counter counter = new Counter();
            int calculatedSteps = counter.GetNumberOfSteps(checker);
            int needSteps = 6;
            Assert.AreEqual(needSteps.ToString(), calculatedSteps.ToString());
        }

        /// <summary>
        /// Test idle moving
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CannotAchieve))]     
        public void TestIdle()
        {
            Checker checker = new Checker();
            string inputData = "black b2 d8";
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);
            checker.Colour = (colour)param[0];
            checker.CoordiareCurrent = (Coordinate)param[1];
            checker.CoordinateNeed = (Coordinate)param[2];
            Counter counter = new Counter();
            int calculatedSteps = counter.GetNumberOfSteps(checker);
        }

        [TestMethod]
        [ExpectedException(typeof(NotValidInputField))]
        public void TestPutCheckerOnWhiteField()
        {
            Checker checker = new Checker();
            string inputData = "white a2 b3";
            Parser parser = new Parser();
            ArrayList param = parser.GetParams(inputData);

            checker.Colour = (colour)param[0];
            checker.CoordiareCurrent = (Coordinate)param[1];
            checker.CoordinateNeed = (Coordinate)param[2];
            Counter counter = new Counter();
            int calculatedSteps = counter.GetNumberOfSteps(checker);
        }
    }
}
