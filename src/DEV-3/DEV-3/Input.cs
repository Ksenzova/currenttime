using System;

namespace DEV_3
{
    // Read options from console line
    // Check User's options
    // Then return created User  
    class Input
    {
        private string name;
        private string surname;
        private short adge = -1;
        private DEV_3.Sex sex;
        private string usersData;
        private string[] parseUsersData;
 

        // Ipput all  User's options
        public User GetUser()
        {
            Console.WriteLine("\n\nInput User's options (Name,Surname,sex,age): ");
            name = GetName();
            surname = GetSurname();
            sex = GetSex();
            adge = GetAdge();

            User user = new User(name,surname,sex,adge);
            return user;
        }

        // Input User's sex male or female
        private Sex GetSex()
        {
            while(true)
            {       
               Console.Write("Input Sex male/female ");
                try
                {
                    sex = (Sex)Enum.Parse(typeof(Sex), Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error sex. Input male or female");
                }
                if ((sex == Sex.male) || (sex == Sex.female))
                {
                    break;
                }
                else
                {
                    continue;
                }
            } 
            return sex;
        }

        // Input User's name
        private string GetName()
        {
            while (true)
            {
                Console.Write("Input Name  ");
                name = Console.ReadLine();
                if (name != "")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            return name;
        }
        // Input User's surname
        private string GetSurname()
        {
            while (true)
            {
                Console.Write("Input Surname  ");
                surname = Console.ReadLine();
                if (surname != "")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            return surname;
        }

        // Input Adge
        private short GetAdge()
        {
            while (true)
            {
                Console.Write("Input Adge  ");
                try
                {
                    adge = short.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error adge. Try again");
                }
                if (adge > 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            return adge;
        }
    }
}
