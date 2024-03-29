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
        public void NewPlanet_ShouldHasVariablesWithDefaultValues()
        {
            Planet planet = new Planet();

            Assert.AreEqual(planet.HorizontalSize, 10);
            Assert.AreEqual(planet.VerticalSize, 10);
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
        public void CreatingRoverAndPlanetWithDefaultValuesForEachThenAttemptToChangeRoverDirection_ShouldChangeRoverDirectionToNewOneExpected(char newDirection)
        {
            Planet mars = new Planet();
            Rover rover = new Rover(mars);

            rover.Direction = newDirection;

            Assert.AreEqual(rover.Direction, newDirection);
        }


        [TestCase("NF", 0 , 1)]
        [Test] 
        // BEFORE MODULE 4 SendingToRoverCommandsThatChangeDirectionToNorthAndMoveRoverForwardOneTime_ShouldSetRoverDirectionToNorthAndMoveRoverToThePositionGridEqualTo0x1
        public void AttemptionToExecuteCommandsLineThatChangeRoverDirectionAndOrderToMakeMove_ShouldExecuteCommandsWithoutErrorsThatMeansChangeRoverDirectionAndMoveItToPositionAsIsExpected(string commands, int expectedPositionX, int expectedPositionY)
        {
            rover.ExecuteCommands(commands);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(rover.PositionX, expectedPositionX);
                Assert.AreEqual(rover.PositionY, expectedPositionY);
            });
        }


        [TestCase("NFFFFFFFFFFF")]
        [Test] 
        // BEFORE MODULE 4 SendingToRoverCommandsWhereSomeOfThemCouldOrderToMoveRoverOutOfMapGrid_ShouldThrowArgumentOutOfRangeExceptionAtPointWhenMoveCannotBeDone
        public void AttemptionToExecuteCommandsWhichIncludeOrderToMoveRoverOnPositionOutOfMapGrid_ShouldMoveRoverToTheAchievablePositionAndThrowArgumentOutOfRangeExceptionAtPointWhenNextMoveCannotBeDoneBecauseOfMapGridBorder(string commands)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => rover.ExecuteCommands(commands));
        }


        [TestCase("NFFEFFFSBB", "S_3x4")]
        [Test] 
        // BEFORE MODULE 4 AfterCommandsExecutionRover_ShouldSendBackInformationAboutHisLastDirectionAndPositionOnTheMapGrid
        public void AfterCommandsExecutionByRover_WeShouldBeAbleToCheckTheLastPositionOfTheRover_WhichShouldBeExpectablePositionBasedOnProvidedCommandsButFormatedInSpecificPositionMessage(string commands, string expectedLastPositionMessage)
        {
            rover.ExecuteCommands(commands);

            Assert.AreEqual(expectedLastPositionMessage, rover.ReturnLastPosition());
        }


        [TestCase("G")]
        [Test] 
        // BEFORE MODULE 4 TryingExecutionANotRecognitionalCharCommand_ShouldThrowArgumentException
        public void AttemptionToExecuteCommandsLineByRoverWithUndefinedCommand_ShouldThrowArgumentException(string commands)
        {
            Assert.Throws<ArgumentException>(() => rover.ExecuteCommands(commands));
        }
    }
}