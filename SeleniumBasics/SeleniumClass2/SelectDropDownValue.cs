using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;



namespace SeleniumBasics.SeleniumClass2
{
    public class SelectDropDownValue
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

            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.FindElement(By.XPath("//a[text()='Create New Account']")).Click();


            //Thread.Sleep(5000);

            


            //finding the elemenet for  day dropdown
            IWebElement dayDropDown=driver.FindElement(By.Id("day"));

            //finding the element for month dropdown
            IWebElement monthDropDown = driver.FindElement(By.Id("month"));

            //finding the element for year dropdown
            IWebElement yearDropDown = driver.FindElement(By.Id("year"));

            SelectElement daySelect = new SelectElement(dayDropDown);
            SelectElement monthSelect = new SelectElement(monthDropDown);
            SelectElement yearSelect = new SelectElement(yearDropDown);


            //daySelect.SelectByText("15");
            // monthSelect.SelectByText("Jan");
            // yearSelect.SelectByText("1988");

            daySelect.SelectByValue("18");
            monthSelect.SelectByValue("8");
            yearSelect.SelectByValue("2007");

            driver.FindElement(By.XPath("//label[text()='Male']")).Click();

        }*/
    }
}
