using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumBasics.SeleniumClass2
{
    public class WindowHandling
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
            driver.Navigate().GoToUrl("https://demo.guru99.com/popup.php");


            string parentWindowID=driver.CurrentWindowHandle;
            Console.WriteLine("Parent Window ID--> " + parentWindowID);

            driver.FindElement(By.LinkText("Click Here")).Click();
            List<String> lists=driver.WindowHandles.ToList() ;
            driver.SwitchTo().Window(lists[1]);
           // string secondWindowId = "";

            foreach(string win in lists)
            {
                if (!win.Equals(parentWindowID)){
                    secondWindowId = win;
                    driver.SwitchTo().Window(win);
                    break;

                }
            }


            driver.FindElement(By.Name("emailid")).SendKeys("learnautomation.easily@gmail.com");
            driver.FindElement(By.Name("btnLogin")).Click();
            driver.Close();
            driver.SwitchTo().Window(parentWindowID);
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Click Here")).Click();



        }*/
    }
}
