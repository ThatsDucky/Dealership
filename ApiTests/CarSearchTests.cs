using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebApi.Controllers;
using WebApi.Models;

namespace ApiTests
{
    [TestClass]
    public class CarSearchTests
    {
        [TestMethod]
        public void SearchInventory_NoParams_ReturnsAllCars()
        {
            // arrange
            var controller = new CarController();

            // act
            var okObject = controller.SearchInventory().Result as OkObjectResult;

            var result = okObject.Value as List<Car>;

            // assert
            Assert.IsTrue(result.Count == 9);
        }

        [TestMethod]
        public void SearchInventory_ByColorRed_ReturnsOnlyRedCars()
        {
            // arrange
            var controller = new CarController();
            string color = "red";

            // act
            var okObject = controller.SearchInventory(color).Result as OkObjectResult;

            var result = okObject.Value as List<Car>;

            // assert
            foreach (Car car in result)
            {
                Assert.IsTrue(car.Color == "Red");
            }
        }

        [TestMethod]
        public void SearchInventory_HasSunroof_ReturnsCarsWithSunroof()
        {
            // arrange
            var controller = new CarController();
            bool hasSunroof = true;

            // act
            var okObject = controller.SearchInventory(null, hasSunroof).Result as OkObjectResult;

            var result = okObject.Value as List<Car>;

            // assert
            foreach (Car car in result)
            {
                Assert.IsTrue(car.HasSunroof);
            }
        }

        [TestMethod]
        public void SearchInventory_IsFourWheelDrive_ReturnsFourWheelers()
        {
            // arrange
            var controller = new CarController();
            bool isFourWheelDrive = true;

            // act
            var okObject = controller.SearchInventory(null, null, isFourWheelDrive).Result as OkObjectResult;

            var result = okObject.Value as List<Car>;

            // assert
            foreach (Car car in result)
            {
                Assert.IsTrue(car.IsFourWheelDrive);
            }
        }

        [TestMethod]
        public void SearchInventory_HasLowMiles_ReturnsLowMilage()
        {
            // arrange
            var controller = new CarController();
            bool hasLowMiles = true;

            // act
            var okObject = controller.SearchInventory(null, null, null, hasLowMiles).Result as OkObjectResult;

            var result = okObject.Value as List<Car>;

            // assert
            foreach (Car car in result)
            {
                Assert.IsTrue(car.HasLowMiles);
            }
        }

        [TestMethod]
        public void SearchInventory_HasPowerWindows_ReturnsPowerWindows()
        {
            // arrange
            var controller = new CarController();
            bool hasPowerWindows = true;

            // act
            var okObject = controller.SearchInventory(null, null, null, null, hasPowerWindows).Result as OkObjectResult;

            var result = okObject.Value as List<Car>;

            // assert
            foreach (Car car in result)
            {
                Assert.IsTrue(car.HasPowerWindows);
            }
        }

        [TestMethod]
        public void SearchInventory_HasNavigation_ReturnsNavigation()
        {
            // arrange
            var controller = new CarController();
            bool hasNavigation = true;

            // act
            var okObject = controller.SearchInventory(null, null, null, null, null, hasNavigation).Result as OkObjectResult;

            var result = okObject.Value as List<Car>;

            // assert
            foreach (Car car in result)
            {
                Assert.IsTrue(car.HasNavigation);
            }
        }

        [TestMethod]
        public void SearchInventory_HasHeatedSeats_ReturnsHeatedSeats()
        {
            // arrange
            var controller = new CarController();
            bool hasHeatedSeats = true;

            // act
            var okObject = controller.SearchInventory(null, null, null, null, null, null, hasHeatedSeats).Result as OkObjectResult;

            var result = okObject.Value as List<Car>;

            // assert
            foreach (Car car in result)
            {
                Assert.IsTrue(car.HasHeatedSeats);
            }
        }
    }
}
