using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics.SeleniumClass2
{
    public class MouseHover
    {

       /* static public void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.LeaveBrowserRunning = true;
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver(options);

            //maximize the browser
            driver.Manage().Window.Maximize();

            //Navigate to Wikipedia

            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.way2automation.com/");

           IWebElement allCourses= driver.FindElement(By.XPath("(//span[text()='All Courses'])[1]"));

            Actions action = new Actions(driver);
    
            action.MoveToElement(allCourses).Perform();
            driver.FindElement(By.XPath("//*[text()='Lifetime Membership']")).Click();
         

        }*/


    }
}
