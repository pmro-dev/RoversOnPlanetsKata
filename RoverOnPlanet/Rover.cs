using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoversOnPlanetsKata
{
    public class Rover
    {
        private char direction;
        public char Direction { get => this.direction; set => this.direction = value; }

        private int positionX;
        private int positionY;
        public int PositionX { get => this.positionX; set => this.positionX = value; } 
        public int PositionY { get => this.positionY; set => this.positionY = value; }

        private Planet planet;
        private Map map;

        public Rover(Planet planet)
        {
            this.direction = 'E';
            this.positionX = 0;
            this.positionY = 0;
            this.planet = planet;
            this.map = planet.Map;
        }

        public string ReturnLastPosition()
        {
            string stringPosition = $"{direction}_{positionX}x{positionY}";
            return stringPosition;
        }


        public void ExecuteCommands(string commands)
        {
            char[] charArray = commands.ToCharArray();

            foreach (char command in charArray)
            {
                switch (command)
                {
                    case 'F':
                        Move('F');
                        break;

                    case 'B':
                        Move('B');
                        break;

                    default: 
                        direction = command;
                        break;
                }
            }
        }


        public void Move(char moveType)
        {
            switch (direction)
            {
                case 'N':
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

                case 'S':
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

                case 'E':
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

                case 'W':
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

