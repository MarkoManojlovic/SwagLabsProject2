namespace SwagProject.Pages
{
    public class CardPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement ShoppingCardClick => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement CheckouButton => driver.FindElement(By.Id("checkout"));
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement ZipCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("continue"));
        public IWebElement Finish => driver.FindElement(By.Id("finish"));
        public IWebElement AssertFinish => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));
    }
}
