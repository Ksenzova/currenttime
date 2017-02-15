using System.Collections.Generic;

namespace DEV_3
{
    // Calculate Average Age of Users
    class AverageAge
    {
        private float age = 0;
        private float numberOfUsers = 0;

        // Summ all ages and devide this summ on bumber of Users
        public float GetAverageAge(List<User> userList)
        {
            foreach (User user in userList)
            {
                age += user.GetAge();
                numberOfUsers++;
            }
            age /= numberOfUsers;
            return age;
        }
    }
}
