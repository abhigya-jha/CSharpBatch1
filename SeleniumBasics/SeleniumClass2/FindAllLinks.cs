using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics.SeleniumClass2
{
    public class FindAllLinks
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
           

            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");

           ReadOnlyCollection<IWebElement> link=driver.FindElements(By.TagName("a"));

          foreach(IWebElement elem in link)
            {
                //Console.WriteLine("Link Text--> "+elem.Text);
                if (elem.Text.Equals("Wikipedia"))
                {
                    elem.Click();
                }
            }
        }*/
    }
}
