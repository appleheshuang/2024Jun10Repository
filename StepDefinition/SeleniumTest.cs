using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

[Binding]
public class SpecflowFiles
{
  [Given("Open Google Webpage")]
        public void Selenium0527_002()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Url = "https://www.google.com/";
        var searchbox= driver.FindElement(By.Id("APjFqb"));
        WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));
        wait.Until(d=>searchbox.Displayed);
        Console.WriteLine("Google Home Page launched");
        driver.Quit();
        }

  [Given("Open Baidu Webpage")]
        public void Selenium0527_003()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.baidu.com/");
        driver.Quit();
        }

      [Given("Appium0529 First Test")]
        public void Appium0529()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Url="https://www.baidu.com/";
        DefaultWait<IWebDriver> fluentwait=new DefaultWait<IWebDriver>(driver);
        fluentwait.Timeout=TimeSpan.FromSeconds(10);
        fluentwait.PollingInterval=TimeSpan.FromMilliseconds(300);
        fluentwait.IgnoreExceptionTypes(typeof(ElementNotInteractableException));

        IWebElement seachbox = fluentwait.Until(dom => dom.FindElement(By.XPath("//input[@id='kw']")));
        seachbox.SendKeys("test");
        fluentwait.Until(dom => dom.FindElement(By.Id("su"))).Click();
        fluentwait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        fluentwait.Until(dom => dom.FindElement(By.XPath("//div[@id='tsn_inner']/div[2]")).Displayed);
        fluentwait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@id='tsn_inner']/div[2]")));
        
        // driver.Quit();
        }
}
      