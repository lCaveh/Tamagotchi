using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TamagotchiSpace.Controllers;
using TamagotchiSpace.Models;
using System;

namespace Tamagotchi.Tests
{
    [TestClass]
    public class TamagotchiControllerTest
    {
        
        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            TamagotchiController controller = new TamagotchiController();

            //Act
            IActionResult view = controller.Create("pikachu");

            //Assert
            Assert.IsInstanceOfType(view, typeof(ViewResult));
        }

    }
}