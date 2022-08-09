using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics.SeleniumClass2
{
    public class DoubleClick
    {
        /*static public void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.LeaveBrowserRunning = true;
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver(options);

            //maximize the browser
            driver.Manage().Window.Maximize();

            //Navigate to Wikipedia

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/simple_context_menu.html");

            IWebElement doubleCLickButton = driver.FindElement(By.XPath("//button[text()='Double-Click Me To See Alert']"));
            Actions action = new Actions(driver);

            action.DoubleClick(doubleCLickButton).Perform();

            IAlert alert=driver.SwitchTo().Alert();
            Console.WriteLine("Text Availble in the Alert--> " + alert.Text);
            Thread.Sleep(3000);
            alert.Accept();



        }*/
    }
}
