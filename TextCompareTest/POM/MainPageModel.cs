using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCompareTest.POM
{
    public class MainPageModel
    {
        public By mainLabel = By.Id("logo");
        public By editTextButton = By.XPath("/html/body/div[2]/form/div/table/tbody/tr/td[1]/button[1]");
        public By switchTextButton = By.Id("switchButton");
        public By compareButton = By.XPath("/html/body/div[2]/form/div/table/tbody/tr/td[2]/button/div");
        public By clearAllButton = By.ClassName("clearButton");
        public By inputTextLeft = By.Id("inputText1");
        public By inputTextRight = By.Id("inputText2");
        public By aboutLink = By.XPath("/html/body/div[3]/div[2]/div[1]/a");
        public By feedbackLink = By.XPath("/html/body/div[3]/div[2]/div[2]/a");
        public By lowercaseButton = By.Id("toLowerCaseButton");
        public By sortLinesButton = By.Id("sortLinesButton");
        public By replaceLineBreaksButton = By.Id("replaceLineBreaks");
        public By removeExcessWhiteSpaceButton = By.Id("removeExcessWhiteSpace");
        public By emailComparisonButton = By.Id("emailComparisonButton");
        public By emailAddressField = By.Id("emailAddressField");
        public By sendButton = By.Id("sendComparisonButton");
        public By comperisonSentText = By.ClassName("messageForUser");
        public By leftComparedField = By.XPath("/html/body/div[2]/table/tbody/tr/td[3]/pre/span");
        public By rightComparedField = By.XPath("/html/body/div[2]/table/tbody/tr/td[6]/pre/span");
        public By emptyFieldsCompareMessage = By.XPath("/html/body/div[2]/span");
    }
}
