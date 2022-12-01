

namespace SwagProject.Test
{
    public class Tests
    {
        LoginPage loginPage;
        ProductPage productPage;
        CardPage cardPage;

        [SetUp]

        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cardPage = new CardPage();
        }

        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_AddTwoProductinCart_ShouldDisplayedTwoProduct()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddBackPack.Click();
            productPage.AddTshirt.Click();

            Assert.That("2", Is.EqualTo(productPage.Cart.Text));
        }
        [Test]
        public void TC02_SortProductByPrice_ShouldSortByHighPrice()
        {
            //act
            loginPage.Login("standard_user", "secret_sauce");
            //Arrange
            productPage.SelectOprtion("Price (high to low)");
            //Assert
            Assert.That(productPage.SortByPrice.Displayed);
        }
        [Test]

        public void TC03_GoToAboutPage_ShouldRedactionToNewPage()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.MenuClick.Click();
            productPage.About.Click();
            Assert.That("https://saucelabs.com/", Is.EqualTo(WebDrivers.Instance.Url));
        }

        [Test]
        public void TC04_BuyProducts_ShouldBeFhinishedShopping()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddBackPack.Click();
            productPage.AddTshirt.Click();
            cardPage.ShoppingCardClick.Click();
            cardPage.CheckouButton.Click();
            cardPage.FirstName.SendKeys("Marko");
            cardPage.LastName.SendKeys("Manojlovic");
            cardPage.ZipCode.SendKeys("11000");
            cardPage.ContinueButton.Click();
            cardPage.Finish.Click();
            Assert.That("THANK YOU FOR YOUR ORDER", Is.EqualTo(cardPage.AssertFinish.Text)); 
            
        }
    }
}