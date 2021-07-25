using KartikSeleniumNunitCore.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartikSeleniumNunitCore.Pages
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(String controlName, string value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath("honkyponky"));
            Console.WriteLine("yes");
        }
    }
}
