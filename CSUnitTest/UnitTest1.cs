using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote; 

namespace CSUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            using (IWebDriver driver = new RemoteWebDriver(firefoxOptions))
            {
                driver.Navigate().GoToUrl("https://www.bing.com/");
                driver.Quit(); 
            }
        }
    }
}
