using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using DierentuinGroep6.Controllers;
using DierentuinGroep6.Models;

namespace DierentuinGroep6.Tests
{
    [TestFixture]
    public class AnimalsControllerTests
    {
        private AnimalsController _controller;

        [SetUp]
        public void SetUp()
        {
            // Maak de controller aan zonder afhankelijkheden
            _controller = new AnimalsController();
        }

        [Test]
        public void Create_Post_ValidModel_ReturnsRedirectToActionResult()
        {
            // Arrange
            var animal = new Animal("Lion", "Panthera leo", "Zebra", 100.0, Size.Large, DietaryClass.Carnivore, ActivityPattern.Diurnal, SecurityLevel.Medium);
            _controller.ModelState.Clear(); // Zorg ervoor dat ModelState niet gefaald is

            // Act
            var result = _controller.Create(animal);

            // Assert
            var redirectResult = result as RedirectToActionResult;
            Assert.IsNotNull(redirectResult); // Verwacht een RedirectToActionResult
            Assert.AreEqual("Index", redirectResult?.ActionName); // Controleer of het naar "Index" wordt geredirect
        }

        [Test]
        public void Create_Post_InvalidModel_ReturnsViewResult()
        {
            // Arrange
            var animal = new Animal("") // Maak een invalid dier object (bijv. zonder naam)
            {
                Species = "Unknown",
                Prey = "Unknown",
                SpaceRequirement = 50.0,
                Size = Size.Medium,
                DietaryClass = DietaryClass.Omnivore,
                ActivityPattern = ActivityPattern.Nocturnal,
                SecurityRequirement = SecurityLevel.Low
            };
            _controller.ModelState.AddModelError("Name", "Name is required"); // Voeg een fout toe aan ModelState

            // Act
            var result = _controller.Create(animal);

            // Assert
            Assert.IsInstanceOf<ViewResult>(result); // Verwacht een ViewResult
        }
    }
}
