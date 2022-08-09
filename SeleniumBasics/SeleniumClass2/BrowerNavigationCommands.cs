using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics.SeleniumClass2
{
    public class BrowerNavigationCommands
    {
        /*public static void Main(string[] args)
        {
            //launch Chrome Browser
            ChromeOptions options = new ChromeOptions();
            options.LeaveBrowserRunning = true;
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver(options);

            //maximize the browser
            driver.Manage().Window.Maximize();

            //Navigate to Facebook.com
            
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            //Thread.Sleep(2000);
            //get the title of the current page
            string title=driver.Title;
            //string s = "abc";
            Console.WriteLine("Current Page Title-> "+title);

            //close
            // driver.Close();

            //quit
            //driver.Quit();


            //GoToUrl();

            //click on the back button of the browser
            driver.Navigate().Back();

            //click on the forward button of the browser
            driver.Navigate().Forward();

            //Refresh your browser
           driver.Navigate().Refresh();
         


        }*/
    }
}
