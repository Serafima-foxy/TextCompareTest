using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TextCompareTest.POM;

namespace TextCompareTest.Steps
{
    [Binding]
    public class MainPageSteps
    {
        public IWebDriver driver;
        public static MainPageModel mainModel;
        public static AboutPageModel aboutModel;
        public static FeedbackPageModel feedbackModel;
        [Given(@"the site is opened in the Google Chrome")]
        public void GivenTheSiteIsOpenedInTheGoogleChrome()
        {
            mainModel = BaseDriver.GetMainPageModel();
            aboutModel = BaseDriver.GetAboutPageModel();
            feedbackModel = BaseDriver.GetFeedbackPageModel();
            driver = BaseDriver.GetDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.Url = "https://text-compare.com/";
        }
        [When(@"I click on Edit Text button")]
        public void WhenIClickOnEditTextButton()
        {
            IWebElement button;
            button = driver.FindElement(mainModel.editTextButton);
            button.Click();
        }

        [When(@"I click Compare button")]
        public void WhenIClickCompareButton()
        {
            IWebElement button;
            button = driver.FindElement(mainModel.compareButton);
            button.Click();
        }

        [When(@"I click Switch Texts button")]
        public void WhenIClickSwitchTextsButton()
        {
            IWebElement button;
            button = driver.FindElement(mainModel.switchTextButton);
            button.Click();
        }

        [When(@"I click Clear All button")]
        public void WhenIClickClearAllButton()
        {
            IWebElement button;
            button = driver.FindElement(mainModel.clearAllButton);
            button.Click();
        }

        [When(@"I click Email This Comparisong button")]
        public void WhenIClickEmailThisComparisongButton()
        {
            IWebElement button;
            button = driver.FindElement(mainModel.emailComparisonButton);
            button.Click();
        }

        [When(@"I click Send It button")]
        public void WhenIClickSendItButton()
        {
            IWebElement button;
            button = driver.FindElement(mainModel.sendButton);
            button.Click();
        }

        [When(@"I click Feedback link")]
        public void WhenIClickFeedbackLink()
        {
            IWebElement button;
            button = driver.FindElement(mainModel.feedbackLink);
            button.Click(); ;
        }

        [When(@"I click Send Feedback button")]
        public void WhenIClickSendFeedbackButton()
        {
            IWebElement button;
            button = driver.FindElement(feedbackModel.sendFeedbackButton);
            button.Click();
        }

        [When(@"I click About link")]
        public void WhenIClickAboutLink()
        {
            IWebElement button;
            button = driver.FindElement(mainModel.aboutLink);
            button.Click();
        }

        [When(@"I enter (.*) in the left input field")]
        public void WhenIEnterInTheLeftInputField(string enteredText)
        {
            IWebElement text = null;
            switch(enteredText)
            {
                case "Paste one version of a text here.":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "here.\npaste one version\nof a text":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Paste one version    of a text here.":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Hello, world!":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "123 456 7890":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "!№;%:?*()_ += -@#$^&   /Привет":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Hello 123":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Hello?":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "123$%^  789":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Text in left field":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Some text":
                    text = driver.FindElement(mainModel.inputTextLeft);
                    break;
            }
            text.SendKeys(enteredText);
        }

        [When(@"I enter (.*) in the right input field")]
        public void WhenIEnterInTheRightInputField(string enteredText)
        {
            IWebElement text = null;
            switch (enteredText)
            {
                case "Hello, Ann!":
                    text = driver.FindElement(mainModel.inputTextRight);
                    break;
                case "1233 456 7890":
                    text = driver.FindElement(mainModel.inputTextRight);
                    break;
                case "!№;%:?*()_ += -@#$^&Привет":
                    text = driver.FindElement(mainModel.inputTextRight);
                    break;
                case "Hello 123":
                    text = driver.FindElement(mainModel.inputTextRight);
                    break;
                case "Hello?":
                    text = driver.FindElement(mainModel.inputTextRight);
                    break;
                case "123456  789":
                    text = driver.FindElement(mainModel.inputTextRight);
                    break;
                case "Text in right field":
                    text = driver.FindElement(mainModel.inputTextRight);
                    break;
                case "Another text":
                    text = driver.FindElement(mainModel.inputTextRight);
                    break;
            }
            text.SendKeys(enteredText);
        }

        [When(@"I enter Email for send comparion results")]
        public void WhenIEnterEmailForSendCoprarionResults()
        {
            string email = "annazabolotnia@gmail.com";
            IWebElement emailField;
            emailField = driver.FindElement(mainModel.emailAddressField);
            emailField.SendKeys(email);
        }

        [When(@"I enter Email in the feedback page")]
        public void WhenIEnterEmailInTheFeedbackPage()
        {
            string email = "annazabolotnia@gmail.com";
            IWebElement emailField;
            emailField = driver.FindElement(feedbackModel.emailField);
            emailField.SendKeys(email);
        }

        [When(@"I enter Very comfortable tool in message field")]
        public void WhenIEnterVeryComfortableToolInMessageField()
        {
            string message = "Very comfortable tool";
            IWebElement emailField;
            emailField = driver.FindElement(feedbackModel.messageField);
            emailField.SendKeys(message);
        }


        [When(@"I click (.*) in Edit Text button")]
        public void WhenIClickInEditTextButton(string optionButton)
        {
            IWebElement option = null;
            switch (optionButton)
            {
                case "To lowercase":
                    option = driver.FindElement(mainModel.lowercaseButton);
                    break;
                case "Sort lines":
                    option = driver.FindElement(mainModel.sortLinesButton);
                    break;
                case "Replace line breaks with spaces":
                    option = driver.FindElement(mainModel.replaceLineBreaksButton);
                    break;
                case "Remove excess white space":
                    option = driver.FindElement(mainModel.removeExcessWhiteSpaceButton);
                    break;
            }
            option.Click();
        }

        [Then(@"the (.*) should be on the screen")]
        public void ThenTheShouldBeOnTheScreen(string result)
        {
            IWebElement actRes = null;
            switch (result)
            {
                case "No text to compare makes my life easy! Cheers ;-)":
                    actRes = driver.FindElement(mainModel.emptyFieldsCompareMessage);
                    break;
                case "paste one version of a text here.":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "paste one version\nof a text\nhere.":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "here. paste one version of a text":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Paste one version of a text here.":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Hello, world!":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "123 456 7890":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "!№;%:?*()_ += -@#$^&   /Привет":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Hello, Ann!":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "1233 456 7890":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "!№;%:?*()_ += -@#$^&Привет":
                    actRes = driver.FindElement(mainModel.inputTextLeft);
                    break;
                case "Your comparison has been sent!":
                    actRes = driver.FindElement(mainModel.comperisonSentText);
                    break;
                case "Your feedback has been sent! Thanks!":
                    actRes = driver.FindElement(feedbackModel.feedbackResultText);
                    break;
                case "Text Compare! does not save or share " +
                "the text you compare. If you have sensitive " +
                "information to compare, however, " +
                "it is still recommended to use an offline tool.":
                    actRes = driver.FindElement(aboutModel.aboutText);
                    break;
            }
            Assert.AreEqual(result, actRes.Text);
        }
        [Then(@"the (.*) is following")]
        public void ThenTheIsFollowing(string result)
        {
            IWebElement res_left;
            IWebElement res_right;
            switch (result)
            {
                case "Same texts":
                    res_left = driver.FindElement(mainModel.leftComparedField);
                    res_right = driver.FindElement(mainModel.rightComparedField);
                    Assert.AreEqual(res_left.Text, res_right.Text);
                    break;
                case "Different texts":
                    res_left = driver.FindElement(mainModel.leftComparedField);
                    res_right = driver.FindElement(mainModel.rightComparedField);
                    Assert.AreNotEqual(res_left.Text, res_right.Text);
                    break;
            }
        }

        [Then(@"the (.*) should be on the left input field")]
        public void ThenTheShouldBeOnTheLeftInputField(string result)
        {
            IWebElement res_left;
            switch (result)
            {
                case "Text in right field":
                    res_left = driver.FindElement(mainModel.inputTextLeft);
                    Assert.AreEqual(result, res_left.Text);
                    break;
                case " ":
                    res_left = driver.FindElement(mainModel.inputTextLeft);
                    Assert.AreEqual(result, res_left.Text);
                    break;
            }
        }

        [Then(@"the (.*) should be on the right input field")]
        public void ThenTheShouldBeOnTheRightInputField(string result)
        {
            IWebElement res_right;
            switch (result)
            {
                case "Text in left field":
                    res_right = driver.FindElement(mainModel.inputTextRight);
                    Assert.AreEqual(result, res_right.Text);
                    break;
                case " ":
                    res_right = driver.FindElement(mainModel.inputTextRight);
                    Assert.AreEqual(result, res_right.Text);
                    break;
            }
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                BaseDriver.RemoveDriver();
            }
        }

    }
}
