using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Drawing.Imaging; // This is needed for ScreenshotImageFormat



class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
	driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Navigate().GoToUrl("https://primeng.org/dropdown");
	System.Threading.Thread.Sleep(1000);
        IWebElement element = driver.FindElement(By.XPath("/html/body/app-root/app-main/div/div[2]/div/ng-component/app-doc/div/div/div[1]/div/app-docsection/section[2]/dropdown-basic-demo/div/p-dropdown/div/span"));
	element.Click();
	IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        IWebElement element1 = driver.FindElement(By.XPath("//span[text()='Rome']"));
        Actions actions = new Actions(driver);
        actions.MoveToElement(element1).Perform();
	System.Threading.Thread.Sleep(1000);
	element1.Click();
        js.ExecuteScript("arguments[0].scrollIntoView(true);", element1);
	System.Threading.Thread.Sleep(3000);
        driver.Quit();


    }
}
