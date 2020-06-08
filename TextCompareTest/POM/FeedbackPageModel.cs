using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCompareTest.POM
{
    public class FeedbackPageModel
    {
        public By messageField = By.Id("id_message");
        public By emailField = By.Id("id_email_address");
        public By sendFeedbackButton = By.Id("sendFeedbackButton");
        public By compareTextLink = By.XPath("/html/body/div[3]/div[2]/div[1]/a");
        public By aboutLink = By.LinkText("about");
        public By feedbackResultText = By.ClassName("messageForUser");
    }
}
