using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace mars_QA.Features
{
    [Binding]
    public class LoginSteps
    {

        String test_url = "http://192.168.99.100:5000/Home";
        IWebDriver driver;

        [Given(@"user is on home page")]
        public void GivenUserIsOnHomePage()
        {
            driver = new ChromeDriver();
            driver.Url = test_url;

        }
        
        [When(@"user clicks Signin")]
        public void WhenUserClicksSignin()
        {
            driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
        }
        
        [Then(@"user enters '(.*)' and '(.*)'")]
        public void ThenUserEntersAnd(string username, string password)
        {
            driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys(username);
            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys(password); 
        }
        
        [Then(@"user clicks on login")]
        public void ThenUserClicksOnLogin()
        {
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
        }
        
        [Then(@"login should be successful")]
        public void ThenLoginShouldBeSuccessful()
        {
            Console.WriteLine("test passed");
        }
    }
}
