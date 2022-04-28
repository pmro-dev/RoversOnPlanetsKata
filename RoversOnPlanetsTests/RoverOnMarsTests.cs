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
            Map map = new Map();
            Rover rover = new Rover(map);

            Assert.AreEqual(rover.Direction, "EAST");
        }


        [TestCase("NORTH")]

        [Test]
        public void ChangingDirectionToNorth_ShouldChangeRoverDirectionToNorth(string newDirection)
        {
            Map map = new Map();
            Rover rover = new Rover(map);

            rover.Direction = newDirection;

            Assert.AreEqual(rover.Direction, newDirection);
        }

        [TestCase("NF")]

        [Test]
        public void SendingToRoverCommandsThatChangeDirectionToNorthAndMoveRoverForwardOneTime_ShouldSetRoverDirectionToNorthAndMoveRoverToThePositionGridEqualTo0x1(string commands)
        {
            Planet mars = new Planet(10, 10);
            Rover rover = new Rover(mars.Map);

            rover.ExecuteCommands(commands);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(rover.PositionX, 0);
                Assert.AreEqual(rover.PositionY, 1);
            });
        }


        [TestCase("NFFFFFFFFFFF")]

        [Test]
        public void SendingToRoverCommandsWhereSomeOfThemCouldOrderToMoveRoverOutOfMapGrid_ShouldThrowArgumentOutOfRangeExceptionAtPointWhenMoveCannotBeDone(string commands)
        {
            Planet mars = new Planet(10, 10);
            Rover rover = new Rover(mars.Map);

            Assert.Throws<ArgumentOutOfRangeException>(() => rover.ExecuteCommands(commands));
        }
    }
}