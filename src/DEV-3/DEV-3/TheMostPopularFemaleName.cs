using System.Linq;
using System.Collections.Generic;


namespace DEV_3
{
    // Find and Return all popular female names
    class TheMostPopularFemaleName
    {
        private int numberOfSame = 0;    // contains number of coincidences the name for current user
        private int[] countTheSame;    // contains all coincidences of the name
        private string theMostPopularFemName;  

        // Return string with popular femzle names
        public string getTheMostPopFemaleNAme(List<User> userList)
        {
            theMostPopularFemName = "";
            countTheSame = new int[userList.Count];
            int index = 0;

            // Count number of repeads
            foreach (User user in userList)
            {            
                numberOfSame = 0;
                foreach(User thesame in userList)
                {
                    if ((user.GetSex() == Sex.female) && (user.GetName()==thesame.GetName()))
                    {
                        numberOfSame++;
                    }
                }
                countTheSame[index] = numberOfSame;
                index++;
            }
            
            // Add to string the most popular female names
            for (int i = 0; i < userList.Count; i++)
            {
                if ((countTheSame[i]== countTheSame.Max()) && (countTheSame.Max()!= 0))
                {
                    theMostPopularFemName += userList.ElementAt(i).GetName();
                    theMostPopularFemName += "  ";
                }          
            }        
            return theMostPopularFemName;
        }
    }
}
