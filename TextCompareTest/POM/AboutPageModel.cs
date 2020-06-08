using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCompareTest.POM
{
    public class AboutPageModel
    {
        public By compareTextLink = By.XPath("/html/body/div[3]/div[2]/div[1]/a");
        public By feedbackLink = By.LinkText("feedback");
        public By aboutText = By.XPath("/html/body/div[2]/div[2]");
    }
}
