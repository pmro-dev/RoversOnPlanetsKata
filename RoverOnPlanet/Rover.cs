using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoversOnPlanetsKata
{
    public class Rover
    {
        private string direction;
        public string Direction { get => this.direction; set => this.direction = value; }

        private int positionX;
        private int positionY;
        public int PositionX { get => this.positionX; set => this.positionX = value; } 
        public int PositionY { get => this.positionY; set => this.positionY = value; }

        private Planet planet;
        private Map map;

        public Rover(Map map)
        {
            this.direction = "EAST";
            this.positionX = 0;
            this.positionY = 0;
            this.map = map;
        }
        public Rover(Planet planet)
        {
            this.positionX = 0;
            this.positionY = 0;
            this.planet = planet;
            this.map = planet.Map;
        }

        public string ReturnLastPosition()
        {
            string stringPosition = $"{direction.Substring(0, 1)}_{positionX}x{positionY}";
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
                        direction = "NORTH";
                        break;

                    case 'S':
                        direction = "SOUTH";
                        break;

                    case 'E':
                        direction = "EAST";
                        break;

                    case 'W':
                        direction = "WEST";
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
            switch (direction)
            {
                case "NORTH":
                    if (moveType == 'F')
                    {
                        if (positionY + 1 <= map.Grid.GetLength(1))
                        {
                            positionY++;
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
                        if (positionY - 1 >= 0)
                        {
                            positionY--;
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
                        if (positionY - 1 >= 0)
                        {
                            positionY--;
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
                        if (positionY + 1 <= map.Grid.GetLength(1))
                        {
                            positionY++;
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
                        if (positionX + 1 <= map.Grid.GetLength(0))
                        {
                            positionX++;
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
                        if (positionX - 1 >= 0)
                        {
                            positionX--;
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
                        if (positionX - 1 >= 0)
                        {
                            positionX--;
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
                        if (positionX + 1 <= map.Grid.GetLength(0))
                        {
                            positionX++;
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

