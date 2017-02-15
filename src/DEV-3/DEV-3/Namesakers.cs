using System.Collections.Generic;


namespace DEV_3
{
    //Find Users with same Surnames
    class Namesakers
    {
        private int numberOfTheSame = 0;
        private List<User> namesakers = new List<User>();

        // Find for Users with the same Surnames
        // Write these Users to other List
        // Return List with Namesakers
        public List<User> GetNamesakers(List<User> userList)
        {
            namesakers.Clear();    
            foreach (User user in userList)
            {
                numberOfTheSame = 0;
                foreach(User thesameUser in userList)
                {
                    if (user.GetSurname() == thesameUser.GetSurname())
                    {
                        numberOfTheSame++;
                    }   
                }
                if(numberOfTheSame > 1)
                {
                    namesakers.Add(user);
                }
            }
            return namesakers;
        }
    }
}
