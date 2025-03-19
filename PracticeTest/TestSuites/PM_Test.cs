using OpenQA.Selenium;

namespace PracticeTest.TestSuites
{
    [TestClass]
    public class UnitTest1
    {
        public static IWebDriver driver;
        [TestMethod]
        public void Method1()
        {
            // add the google 
            // need to add thelogin part logic 
              IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
          driver.Navigate().GoToUrl("https://www.Amazon.com");            
        }
		
        [TestMethod]
        public void TestMethod1()
        {
            // add the google 
            // need to add thelogin part logic 
              IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
          driver.Navigate().GoToUrl("https://www.Amazon.com");            
        }

        [TestMethod]
        public void SalesOrderCreation()
        {
            // add the google 
            // need to add thelogin part logic 
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.Amazon.com");

        }

	    
 [TestMethod]
   public void PurchaseOrder_Workflow()
   {
       // login to Legal Entity - UK10
       fO_Purchase.NavigateToUKEntity();
       // Navigating to All projects 
       fO_Purchase.NavigateToAllProjects();

       // Create new Purchase Order 
       fO_Purchase.CreatePurchaseOrderThroughProjectID(fO_Reusable);
   }
    }
}
