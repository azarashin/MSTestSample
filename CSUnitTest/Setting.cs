using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSUnitTest
{
    public class Setting
    {
        public const string ConfigFile = "test_setting.xml";

        public static Setting GetSetting()
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(Setting));
            System.IO.StreamReader sr = new System.IO.StreamReader(
                ConfigFile, new System.Text.UTF8Encoding(false));
            Setting obj = (Setting)serializer.Deserialize(sr);
            sr.Close();

            return obj; 
        }

        public string WebDriverUrl;
        public string BrowserType;
        public string TestTargetUrl; 

        public DriverOptions Option()
        {
            if(BrowserType == "chrome")
            {
                return new ChromeOptions();
            }
            if (BrowserType == "firefox")
            {
                return new FirefoxOptions();
            }
            if (BrowserType == "edge")
            {
                return new EdgeOptions();
            }
            if (BrowserType == "firefox")
            {
                return new OperaOptions();
            }
            return null; 
        }


        public Setting()
        {
            BrowserType = "firefox";
            WebDriverUrl = "http://localhost:4445/wd/hub";
            TestTargetUrl = "http://localhost"; 
        }

    }
}
