using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace CSUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Setting setting = Setting.GetSetting(); 
            using (IWebDriver driver = new RemoteWebDriver(new Uri(setting.WebDriverUrl), setting.Option()))
            {
                driver.Navigate().GoToUrl(setting.TestTargetUrl);
                driver.Quit(); 
            }
        }
    }
}
