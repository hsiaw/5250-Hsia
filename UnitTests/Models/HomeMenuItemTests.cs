﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    class HomeMenuItemTests
    {
        [Test]
        public void HomeMenuItem_Constructor_Valid_Default_Should_Pass()
        {
            //Arrange
            //Act
            var result = new HomeMenuItem();
            //Reset
            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeMenuItem_Set_Get_Valid_Default_Should_Pass()
        {
            //Arrange
            //Act
            var result = new HomeMenuItem();
            result.Id = MenuItemType.About;
            result.Title = "Title";

            //Reset

            //Assert
            Assert.AreEqual("Title", result.Title);
            Assert.AreEqual(MenuItemType.About, result.Id);
        }

       
    }
}
