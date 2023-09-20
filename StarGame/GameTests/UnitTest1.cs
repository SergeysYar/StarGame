using StarGame;

namespace GameTests
{
    [TestClass]
    public class SpaceshipTests
    {
        [TestMethod]
        public void Spaceship_CanPassNebula_ReturnsTrueWhenConditionsMet()
        {
            // Arrange
            double hullStrength = 2;
            double mass = 30;
            double nebulaDensity = 2;
            ISpaceship spaceship = new Spaceship("Test Spaceship", hullStrength, mass);

            // Act
            bool canPassNebula = spaceship.CanPassNebula(nebulaDensity);

            // Assert
            Assert.IsTrue(canPassNebula);
        }

        [TestMethod]
        public void Spaceship_CanPassNebula_ReturnsFalseWhenConditionsNotMet()
        {
            // Arrange
            double hullStrength = 2;
            double mass = 10;
            double nebulaDensity = 5;
            ISpaceship spaceship = new Spaceship("Test Spaceship", hullStrength, mass);

            // Act
            bool canPassNebula = spaceship.CanPassNebula(nebulaDensity);

            // Assert
            Assert.IsFalse(canPassNebula);
        }
    }
    
}