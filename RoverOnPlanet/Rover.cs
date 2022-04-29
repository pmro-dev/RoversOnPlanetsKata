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
        private Map map;

        public Rover(Map map)
        {
            this.Direction = "EAST";
            this.PositionX = 0;
            this.PositionY = 0;
            this.map = map;
        }

        public string ReturnLastPosition()
        {
            string stringPosition = $"{Direction.Substring(0, 1)}_{PositionX}x{PositionY}";
            return stringPosition;
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
                        if (PositionY + 1 <= map.Grid.GetLength(1))
                        {
                            PositionY++;
                        }
                        else
                        {
                            Console.WriteLine("Sorry but we cannot move to this position, please change command");
                            throw new ArgumentOutOfRangeException();
                            break;
                        }
                    }
                    else if (moveType == 'B')
                    {
                        if (PositionY - 1 >= 0)
                        {
                            PositionY--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry but we cannot move to this position, please change command");
                            throw new ArgumentOutOfRangeException();
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                    break;

                case "SOUTH":
                    if (moveType == 'F')
                    {
                        if (PositionY - 1 >= 0)
                        {
                            PositionY--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry but we cannot move to this position, please change command");
                            throw new ArgumentOutOfRangeException();
                            break;
                        }
                    }
                    else if (moveType == 'B')
                    {
                        if (PositionY + 1 <= map.Grid.GetLength(1))
                        {
                            PositionY++;
                        }
                        else
                        {
                            Console.WriteLine("Sorry but we cannot move to this position, please change command");
                            throw new ArgumentOutOfRangeException();
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                    break;

                case "EAST":
                    if (moveType == 'F')
                    {
                        if (PositionX + 1 <= map.Grid.GetLength(0))
                        {
                            PositionX++;
                        }
                        else
                        {
                            Console.WriteLine("Sorry but we cannot move to this position, please change command");
                            throw new ArgumentOutOfRangeException();
                            break;
                        }
                    }
                    else if (moveType == 'B')
                    {
                        if (PositionX - 1 >= 0)
                        {
                            PositionX--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry but we cannot move to this position, please change command");
                            throw new ArgumentOutOfRangeException();
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                    break;

                case "WEST":
                    if (moveType == 'F')
                    {
                        if (PositionX - 1 >= 0)
                        {
                            PositionX--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry but we cannot move to this position, please change command");
                            throw new ArgumentOutOfRangeException();
                            break;
                        }
                    }
                    else if (moveType == 'B')
                    {
                        if (PositionX + 1 <= map.Grid.GetLength(0))
                        {
                            PositionX++;
                        }
                        else
                        {
                            Console.WriteLine("Sorry but we cannot move to this position, please change command");
                            throw new ArgumentOutOfRangeException();
                            break;
                        }
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

