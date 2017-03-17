using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace DEV_12
{
    /// <summary>
    /// Calculate is it is possible how many step need to achieve cuurent field
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Checker checker = new Checker();
            Console.WriteLine("Input parametrs in format: color currentCoordinate needCoordinate ");
            string inputData = Console.ReadLine();
            Parser parser = new Parser();
            try
            {
                ArrayList param = parser.GetParams(inputData);
                checker.Colour = (colour)param[0];
                checker.CoordiareCurrent = (Coordinate)param[1];
                checker.CoordinateNeed = (Coordinate)param[2];
                Counter counter = new Counter();
                Console.WriteLine(counter.GetNumberOfSteps(checker));
                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error format of input data");
            }
            catch (RegexMatchTimeoutException)
            {
                Console.WriteLine("Error format of field's value");
            }
            catch  (IndexOutOfRangeException)
            {
                Console.WriteLine("Error format of input data");
            }
            catch(CannotAchieve ex)
            {
                    Console.WriteLine(ex.Message);
            }
            catch (NotValidInputField ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();     
        }
    }
}
