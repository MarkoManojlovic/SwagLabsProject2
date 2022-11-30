﻿using OpenQA.Selenium;
using SwagProject.Driver;

namespace SwagProject.Pages
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));

        public void Login(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }
    }
}
