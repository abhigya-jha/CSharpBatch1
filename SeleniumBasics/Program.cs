using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics
{
    class Program
    {
      /*  static void Main(string[] args)
        {
          

            //launch Chrome Browser
             ChromeOptions options = new ChromeOptions();
             options.LeaveBrowserRunning = true;
             new DriverManager().SetUpDriver(new ChromeConfig());
             IWebDriver driver = new ChromeDriver(options);

             //maximize the browser
             driver.Manage().Window.Maximize();

             //Navigate to Facebook.com
             driver.Url = "https://www.facebook.com/";
             //driver.Navigate().GoToUrl("https://www.facebook.com/")


             //Enter email
             //first find email field
             //IWebElement email=driver.FindElement(By.Id("email"));
             //then enter the email
             //email.SendKeys("abc@gmail.com");
             driver.FindElement(By.Id("email")).SendKeys("abc@gmail.com");

             //Enter password
             driver.FindElement(By.Id("pass")).SendKeys("jhsdfjkh123123");

             //click on Login button
             driver.FindElement(By.Name("login")).Click();

        }*/
    }
}
