using NUnit.Framework;
using RoversOnPlanetsKata;

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

        
    }
}