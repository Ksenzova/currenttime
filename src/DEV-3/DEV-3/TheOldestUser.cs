using System.Collections.Generic;

namespace DEV_3
{
    class TheOldestUser
    {
        private short maxAge = 0;
        private List<User> theOlDestUsers = new List<User>();

        // Find the oldest User and return it
        public List<User> GetTheOldestUser(List<User> userList)
        {
            foreach(User user in userList)
            {
                if (user.GetAge() > maxAge)
                {
                    maxAge = user.GetAge();
                }
            }
            foreach (User user in userList)
            {
                if (user.GetAge() == maxAge)
                {
                    theOlDestUsers.Add(user);
                }
            }
            return theOlDestUsers;
        }
    }
}
