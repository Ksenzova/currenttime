using System;

namespace DEV_12
{
    /// <summary>
    /// Calculate number of steps need draught to reach need coordinate
    /// </summary>
    class Counter
    {
        private Coordinate coordinateNeed;
        private Draught draught;
        public Counter(Coordinate coordinateNeed, Draught draught)
        {
            this.coordinateNeed = coordinateNeed;
            this.draught = draught;
        }
        
        /// <summary>
        /// Calculate number of steps to reach need coordinate
        /// if it is not possible throw Exeption
        /// </summary>
        /// <returns>number of steps</returns>
        public int GetNumberOfSteps()
        {
            int steps= 0;
            // If the cordinates are not the same
            while(coordinateNeed !=draught.CoordinateCurrent)
            {
                // calculate if it is possible to reach need coordinate
                // accoding that white draught can move only up  and black can move only down
                int temp = draught.Colour == colour.white ? coordinateNeed.Y - draught.CoordinateCurrent.Y :  draught.CoordinateCurrent.Y-coordinateNeed.Y;
                if (temp<=0)
                {
                    throw new Exception("Could not achieve the field");
                }
                // move right
                if (coordinateNeed.ConvertXToInt() > draught.CoordinateCurrent.ConvertXToInt())
                {
                    draught.MoveRight(); 
                    steps++;
                }
                else
                {
                    // move left
                    if (coordinateNeed.ConvertXToInt() < draught.CoordinateCurrent.ConvertXToInt())
                    {
                        draught.MoveLeft();
                        steps++;
                    }
                    else
                    {
                        //  move left if coordinatea are one about the other if it is possible
                        if(draught.CoordinateCurrent.ConvertXToInt()>1 || draught.CoordinateCurrent.ConvertXToInt() == 8)
                        {
                            draught.MoveLeft();
                            steps++;
                        }
                        else
                        {                          
                            draught.MoveRight();
                            steps++;
                        }
                    }
                }

            }
            return steps;          
        }       
    }
}

