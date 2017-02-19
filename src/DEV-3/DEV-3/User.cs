using System;

namespace DEV_3
{
    // Special data type for human's sex
    [Flags]
    public enum Sex
    {
        male = 0x00,
        female = 0x01
    }
    // Contain options
    // Give value of these options
    class User
    {
        // User's options 
        private string name;
        private string surname;
        private short age;
        private Sex sex;

        // Return User's options
        public short GetAge()
        {
            return this.age;
        }
        public Sex GetSex()
        {
            return this.sex;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetSurname()
        {
            return surname;
        }
       
        public User(string name, string surname,Sex sex, short age)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
            this.age = age;
        }

        // Print to one string options of one User
        public void OutputUsersData()
        {
            Console.WriteLine(name + "  " + surname + "  " + sex + "  " + age);
        }
    }
}
