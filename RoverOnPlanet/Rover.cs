using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoversOnPlanetsKata
{
    public class Rover
    {
        public string Direction { get; set; }
        public int PositionX { get; set; } 
        public int PositionY { get; set; }

        public Rover()
        {
            this.Direction = "EAST";
            this.PositionX = 0;
            this.PositionY = 0;
        }

        public void ExecuteCommands(string commands)
        {
            char[] charArray = commands.ToCharArray();

            foreach (char command in charArray)
            {
                switch (command)
                {
                    case 'N':
                        Direction = "NORTH";
                        break;

                    case 'S':
                        Direction = "SOUTH";
                        break;

                    case 'E':
                        Direction = "EAST";
                        break;

                    case 'W':
                        Direction = "WEST";
                        break;

                    case 'F':
                        Move('F');
                        break;

                    case 'B':
                        Move('B');
                        break;
                }
            }
        }


        public void Move(char moveType)
        {
            switch (Direction)
            {
                case "NORTH":
                    if (moveType == 'F')
                    {
                        PositionY++;
                    }
                    else if (moveType == 'B')
                    {
                        PositionY--;
                    }
                    else
                    {
                        break;
                    }
                    break;

                case "SOUTH":
                    if (moveType == 'F')
                    {
                        PositionY--;
                    }
                    else if (moveType == 'B')
                    {
                        PositionY++;
                    }
                    else
                    {
                        break;
                    }
                    break;

                case "EAST":
                    if (moveType == 'F')
                    {
                        PositionX--;
                    }
                    else if (moveType == 'B')
                    {
                        PositionX++;
                    }
                    else
                    {
                        break;
                    }
                    break;

                case "WEST":
                    if (moveType == 'F')
                    {
                        PositionX++;
                    }
                    else if (moveType == 'B')
                    {
                        PositionX--;
                    }
                    else
                    {
                        break;
                    }
                    break;
            }
        }
    }
}
