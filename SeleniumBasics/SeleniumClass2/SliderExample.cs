using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics.SeleniumClass2
{
    public class SliderExample
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
            driver.Navigate().GoToUrl("https://jqueryui.com/resources/demos/slider/default.html");

            IWebElement slider=driver.FindElement(By.XPath("//div[@id='slider']//span"));
            //Actions action = new Actions(driver);

            //action.DragAndDropToOffset(slider, 600, 0).Perform();

            for(int i = 1; i <= 100; i++)
            {
                slider.SendKeys(Keys.ArrowRight);
            }



        }*/
    }
}
