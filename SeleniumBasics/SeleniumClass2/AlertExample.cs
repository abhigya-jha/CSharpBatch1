using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics.SeleniumClass2
{
    public class AlertExample
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
            driver.Navigate().GoToUrl("http://www.leafground.com/pages/Alert.html");

            driver.FindElement(By.XPath("//button[text()='Prompt Box']")).Click();

            IAlert alert=driver.SwitchTo().Alert();
            Thread.Sleep(6000);
            alert.SendKeys("Rahul Arora");
            
            alert.Accept();
            IWebElement result = driver.FindElement(By.Id("result"));
            Console.WriteLine("Result---> " + result.Text);


        }*/
    }
}
