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
            parser.TryParseParams(inputData);        
            Assert.AreEqual(coloutNeed, parser.DraughtColour);
        }
        [TestMethod]
        public void TestParserCordinateCurrent()
        {
            string inputData = "white a1 h2";
            Coordinate coordinateMustBe = new Coordinate('a', 1);
            Parser parser = new Parser();
            parser.TryParseParams(inputData);
            Assert.AreEqual(coordinateMustBe.X,parser.CoordinateCurrent.X);
            Assert.AreEqual(coordinateMustBe.Y, parser.CoordinateCurrent.Y);
        }

        [TestMethod]
        public void TestParserCordinateNeed()
        {
            string inputData = "white a1 h2";
            Coordinate coordinateMustBe = new Coordinate('h', 2);
            Parser parser = new Parser();
            parser.TryParseParams(inputData);
            Assert.AreEqual(coordinateMustBe.X, parser.CoordinateNeed.X);
            Assert.AreEqual(coordinateMustBe.Y, parser.CoordinateNeed.Y);
        }

        [TestMethod]
        [ExpectedException(typeof(RegexMatchTimeoutException))]
        public void TestNotValidInputCoordinate()
        {
            Coordinate coordinateMustBe = new Coordinate('a', 9);
        }

        [TestMethod]
        public void TestWhiteDraught()
        {
            string inputString = "white a1 h8";
            int numberOfSteps = 7;
            TestAlgorithm(inputString, numberOfSteps);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestWhiteDraughtCannotGoDown()
        {
            string inputString = "white h8 a1";
            int numberOfSteps = 7;
            TestAlgorithm(inputString, numberOfSteps);
        }

        [TestMethod]
        public void TestBlackDraught()
        {
            string inputString = "black b8 g1";
            int numberOfSteps = 7;
            TestAlgorithm(inputString, numberOfSteps);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestWhiteBlackCannotGoDown()
        {
            string inputString = "black g1 b8";
            int numberOfSteps = 7;
            TestAlgorithm(inputString, numberOfSteps);
        }


        [TestMethod]
        public void TestOneCoordinateisOverAnotherBlack()
        {
            string inputString = "black b8 b2";
            int numberOfSteps = 6;
            TestAlgorithm(inputString, numberOfSteps);
        }


        [TestMethod]
        public void TestOneCoordinateisOverAnotherWhite()
        {
            string inputString = "white a1 a5";
            int numberOfSteps = 4;
            TestAlgorithm(inputString, numberOfSteps);
        }

        public void TestAlgorithm(string inputString, int numberOfSteps)
        {
            Parser parser = new Parser();
            // input paramters while they cannot be parsed
            parser.TryParseParams(inputString);

            // form coordinate and  draught
            Coordinate coordinateNeed = parser.CoordinateNeed;
            Draught draught = new Draught(parser.DraughtColour, parser.CoordinateCurrent);
            // count number of steps
            Counter counter = new Counter(coordinateNeed, draught);
            Assert.AreEqual(counter.GetNumberOfSteps(), numberOfSteps);
            Console.WriteLine(counter.GetNumberOfSteps());
        }
    }
}
