using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

IWebDriver driver = new ChromeDriver(); 
By destinationFieldXPath = By.XPath("//input[@id='destination']");
By reverseButtonXPath = By.XPath("//div[@data-test-id='swap-places']");

driver.Navigate().GoToUrl("https://www.aviasales.by");
driver.Manage().Window.Maximize();

IWebElement destinationField = driver.FindElement(destinationFieldXPath);
IWebElement reverseButton = driver.FindElement(reverseButtonXPath);

destinationField.SendKeys("Omsk");
Thread.Sleep(300);
reverseButton.Click();