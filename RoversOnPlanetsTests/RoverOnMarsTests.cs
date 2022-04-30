using NUnit.Framework;
using RoversOnPlanetsKata;
using System;

namespace RoversOnPlanetsTests
{
    public class Tests
    {
        Planet mars;
        Rover rover;

        [SetUp]
        public void Setup()
        {
            mars = new Planet(10, 10);
            rover = new Rover(mars);
        }

        [Test]
        public void NewMarsPlanet_ShouldHasVariablesWithDefaultValues()
        {
            Planet mars = new Planet();

            Assert.AreEqual(mars.HorizontalSize, 10);
            Assert.AreEqual(mars.VerticalSize, 10);
        }

        [TestCase(10, 10, 10, 10)]

        [Test] 
        //BEFORE MODULE 4 NewMarsPlanetWithVerticalAndHorizontalValuesEachEqualTo10_ShouldHasGridOfSizeEqualTo10x10
        public void CreatingNewPlanetWithVerticalAndHorizontalSpecificValues_ShouldCreateMapGridForThisPlanetInSizeEqualToProvidedVerticalAndHorizontalValuesForPlanet(int horizontalSize, int verticalSize, int expectedMapGridHorizontalSize, int expectedMapGridVerticalSize)
        {
            mars = new Planet(horizontalSize, verticalSize);
            Assert.AreEqual(mars.Map.Grid.GetLength(0), expectedMapGridHorizontalSize);
            Assert.AreEqual(mars.Map.Grid.GetLength(1), expectedMapGridVerticalSize);
        }


        [TestCase('E')]
        [Test] 
        // BEFORE MODULE 4 RoverDefaultDirection_ShouldBeEast
        public void CreatedDefaultRover_ShouldHasDefaultDirection(char expectedDirection)
        {
            Planet planet = new Planet();
            Rover rover = new Rover(planet);

            Assert.AreEqual(rover.Direction, expectedDirection);
        }


        [TestCase('N')]
        [Test] 
        //BEFORE MODULE 4 ChangingDirectionToNorth_ShouldChangeRoverDirectionToNorth
        public void CreatingDefaultRoverAndPlanetThenAttemptionToChangeRoverDirection_ShouldChangeRoverDirectionToNewOne(char newDirection)
        {
            Planet mars = new Planet();
            Rover rover = new Rover(mars);

            rover.Direction = newDirection;

            Assert.AreEqual(rover.Direction, newDirection);
        }

        [TestCase("NF")]

        [Test]
        public void SendingToRoverCommandsThatChangeDirectionToNorthAndMoveRoverForwardOneTime_ShouldSetRoverDirectionToNorthAndMoveRoverToThePositionGridEqualTo0x1(string commands)
        {

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
            Assert.Throws<ArgumentOutOfRangeException>(() => rover.ExecuteCommands(commands));
        }


        [TestCase("NFFEFFFSBB")]

        [Test]
        public void AfterCommandsExecutionRover_ShouldSendBackInformationAboutHisLastDirectionAndPositionOnTheMapGrid(string commands)
        {
            rover.ExecuteCommands(commands);

            Assert.AreEqual("S_3x4", rover.ReturnLastPosition());
        }


        [TestCase("G")]

        [Test]
        public void TryingExecutionANotRecognitionalCharCommand_ShouldThrowArgumentException(string commands)
        {
            Assert.Throws<ArgumentException>(() => rover.ExecuteCommands(commands));
        }
    }
}