using NUnit.Framework;
using RoversOnPlanetsKata;
using System;

namespace RoversOnPlanetsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewMarsPlanet_ShouldHasVariablesWithDefaultValues()
        {
            Planet mars = new Planet();

            Assert.AreEqual(mars.HorizontalSize, 10);
            Assert.AreEqual(mars.VerticalSize, 10);
        }

        [Test]
        public void NewMarsPlanetWithVerticalAndHorizontalValuesEachEqualTo10_ShouldHasGridOfSizeEqualTo10x10()
        {
            Planet mars = new Planet(10, 10);

            Assert.AreEqual(mars.Map.Grid.GetLength(0), 10);
            Assert.AreEqual(mars.Map.Grid.GetLength(1), 10);
        }

        [Test]
        public void RoverDefaultDirection_ShouldBeEast()
        {
            Rover rover = new Rover();

            Assert.AreEqual(rover.Direction, "EAST");
        }


        [TestCase("NORTH")]

        [Test]
        public void ChangingDirectionToNorth_ShouldChangeRoverDirectionToNorth(string newDirection)
        {
            Rover rover = new Rover();

            rover.Direction = newDirection;

            Assert.AreEqual(rover.Direction, newDirection);
        }

        [TestCase("NF")]

        [Test]
        public void SendingToRoverCommandsThatChangeDirectionToNorthAndMoveRoverForwardOneTime_ShouldSetRoverDirectionToNorthAndMoveRoverToThePositionGridEqualTo0x1(string commands)
        {
            Rover rover = new Rover();
            Planet mars = new Planet(10, 10);

            rover.ExecuteCommands(commands);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(rover.PositionX, 0);
                Assert.AreEqual(rover.PositionY, 1);
            });
        }


        [TestCase("NFFFFFFFFFFF")]

        [Test]
        public void SendingToRoverCommandsWithMoreMovesForwardThanMapGridSize_ShouldThrowArgumentOutOfRangeException(string commands)
        {
            Rover rover = new Rover();
            Planet mars = new Planet(10, 10);

            Assert.Throws<ArgumentOutOfRangeException>(() => rover.ExecuteCommands(commands));
        }
    }
}