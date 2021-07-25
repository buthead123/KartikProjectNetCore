using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using KartikSeleniumNunitCore.Pages;
using KartikSeleniumNunitCore.Driver;

namespace KartikSeleniumNunitCore
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");

            /*ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.*/
            Driver = new ChromeDriver(@"c:/_drivers/");
            Driver.Navigate().GoToUrl("https://lov-myride.com");
        }

        [Test]
        public void Test1()
        {
            //CustomControl customControl = new CustomControl();
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "yes");

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}