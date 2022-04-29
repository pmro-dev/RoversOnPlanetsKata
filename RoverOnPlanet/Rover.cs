﻿using System;
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


       private void MoveOnXToPlusSide()
        {
            if (positionX + 1 <= map.Grid.GetLength(0))
            {
                positionX++;
            }
            else
            {
                CanNotMakeMove(null);
            }
        }
        private void MoveOnXToMinusSide()
        {
            if (positionX - 1 >= 0)
            {
                positionX--;
            }
            else
            {
                CanNotMakeMove(null);
            }
        }
        private void MoveOnYToPlusSide()
        {
            if (positionY + 1 <= map.Grid.GetLength(1))
            {
                positionY++;
            }
            else
            {
                CanNotMakeMove(null);
            }
        }
        private void MoveOnYToMinusSide()
        {
            if (positionY - 1 >= 0)
            {
                positionY--;
            }
            else
            {
                CanNotMakeMove(null);
            }
        }


        private void CanNotMakeMove(string? additionalInfo)
        {
            Console.WriteLine($"Sorry but we cannot move to this position, please change command. {additionalInfo}");
            throw new ArgumentOutOfRangeException();
        }


        public void Move(char moveType)
        {
            switch (direction)
            {
                case 'N':
                    if (moveType == 'F')
                    {
                        MoveOnYToPlusSide();
                        break;
                    }
                    else if (moveType == 'B')
                    {
                        MoveOnYToMinusSide();
                        break;
                    }
                    else
                    {
                        break;
                    }

                case 'S':
                    if (moveType == 'F')
                    {
                        MoveOnYToMinusSide();
                        break;
                    }
                    else if (moveType == 'B')
                    {
                        MoveOnYToPlusSide();
                        break;
                    }
                    else
                    {
                        break;
                    }

                case 'E':
                    if (moveType == 'F')
                    {
                        MoveOnXToPlusSide();
                        break;
                    }
                    else if (moveType == 'B')
                    {
                        MoveOnXToMinusSide();
                        break;
                    }
                    else
                    {
                        break;
                    }

                case 'W':
                    if (moveType == 'F')
                    {
                        MoveOnXToMinusSide();
                        break;
                    }
                    else if (moveType == 'B')
                    {
                        MoveOnXToPlusSide();
                        break;
                    }
                    else
                    {
                        break;
                    }
            }
        }
    }
}

