using Microsoft.OData.Edm;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using TextCompareTest.POM;

namespace TextCompareTest.Steps
{
    public static class BaseDriver
    {
        public static IWebDriver driver;
        public static MainPageModel mainModel;
        public static AboutPageModel aboutModel;
        public static FeedbackPageModel feedbackModel;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver("C:\\SERA\\PHOTO");
                
            }
            return driver;
        }
        public static MainPageModel GetMainPageModel()
        {
            return new MainPageModel();
        }
        public static FeedbackPageModel GetFeedbackPageModel()
        {
            return new FeedbackPageModel();
        }
        public static AboutPageModel GetAboutPageModel()
        {
            return new AboutPageModel();
        }
        public static void RemoveDriver()
        {
            driver = null;
        }
    }
}
