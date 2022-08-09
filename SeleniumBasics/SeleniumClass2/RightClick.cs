using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics.SeleniumClass2
{
    public class RightClick
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

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://deluxe-menu.com/popup-mode-sample.html");

            IWebElement img=driver.FindElement(By.XPath("(//p//img)[2]"));
            Actions action = new Actions(driver);

            action.ContextClick(img).Perform();//ContextClick=RightCLick
            driver.FindElement(By.XPath("//td[text()='Contact Us']")).Click();



        }*/
    }
}
