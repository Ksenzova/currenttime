using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace DEV_12
{
    /// <summary>
    /// Calculate is it is possible how many step need draught to achieve curent field
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const string InputParams= "Input colour of draught current position and need position.Example: white a1 b2";
            const string InputParamsCannotBeParsed = "Input parametrs cannnot be parsed.Try input again: ";
            Coordinate c = new Coordinate('a', 9);
            // do this progrm while input escape
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                try
                {                              
                    Console.WriteLine(InputParams);
                    string inputString = Console.ReadLine();
                    Parser parser = new Parser();
                    // input paramters while they cannot be parsed
                    while (!parser.TryParseParams(inputString))
                    {
                        Console.Write(InputParamsCannotBeParsed);
                        inputString = Console.ReadLine();
                    }

                    // form coordinate and  draught
                    Coordinate coordinateNeed = parser.CoordinateNeed;
                    Draught draught = new Draught(parser.DraughtColour, parser.CoordinateCurrent);

                    // count number of steps
                    Counter counter = new Counter(coordinateNeed, draught);
                    Console.WriteLine(counter.GetNumberOfSteps());
                       
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (cki.Key != ConsoleKey.Escape);

            Console.ReadKey();     
        }
    }
}
