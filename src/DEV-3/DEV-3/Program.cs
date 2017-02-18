using System;
using System.Collections.Generic;

namespace DEV_3
{
    // Input User's options :name, surname, sex, adge
    // Find average adge, the oldest User, the most popular female name, namesakers
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            List<User> usersList = new List<User>();

            // Stop write User when enter ESC
            ConsoleKeyInfo cki = Console.ReadKey();
            while (cki.Key != ConsoleKey.Escape)
            {
                usersList.Add(input.GetUser());
                cki = Console.ReadKey();
            } 

            if (usersList.Count!=0)
            {
                // Write the oldest User
                TheOldestUser theOldest = new TheOldestUser();
                Console.WriteLine("\n\n\nthe oldest user");
                foreach (User user in theOldest.GetTheOldestUser(usersList))
                {
                    user.OutputUsersData();
                }

                // Calculate and write Average Age
                Console.Write("\nAverage Age:");
                AverageAdge averageAge = new AverageAdge();
                Console.WriteLine(averageAge.GetAverageAge(usersList));

                // Write the most popular famale name
                Console.WriteLine("\nThe most popular female name");
                TheMostPopularFemaleName popname = new TheMostPopularFemaleName();
                if (popname.getTheMostPopFemaleNAme(usersList) != "")
                {
                    Console.WriteLine(popname.getTheMostPopFemaleNAme(usersList));
                }
                else
                {
                    Console.WriteLine("There are no female name");
                }

                // Write all users with the same surnames
                Console.WriteLine("\nNamesakers");
                Namesakers namesaker = new Namesakers();
                if (namesaker.GetNamesakers(usersList).Count!=0)
                {
                    foreach (User user in namesaker.GetNamesakers(usersList))
                    {
                        user.OutputUsersData();
                    }
                }
                else
                {
                    Console.WriteLine("There are no Namesakers");
                }
                
            }
            else
            {
                Console.WriteLine("There are no input Users");
            }
            Console.ReadKey();
        }
    }
}
