using System;
using System.Collections;

namespace DEV_12
{
    /// <summary>
    /// Parse from input string params of need format
    /// </summary>
    public class Parser
    {
        public ArrayList GetParams(string inputData)
        {
            inputData = inputData.Trim(' ');
            ArrayList list = new ArrayList();

            string[] param = inputData.Split(' ');

            colour fieldColour = (colour)Enum.Parse(typeof(colour), param[0]);
            list.Add(fieldColour);

            Coordinate coordinateNeed = new Coordinate(param[1][0],ushort.Parse(param[1][1].ToString()));
            list.Add(coordinateNeed);

            Coordinate coordinateCurrent = new Coordinate(param[2][0], ushort.Parse(param[2][1].ToString()));
            list.Add(coordinateCurrent);
            return list;
        }
    }
}
