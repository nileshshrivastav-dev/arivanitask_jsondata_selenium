
using arivanitask.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System.Xml.Linq;

using NLog.Internal;
using System.Collections.Specialized;
using System.Text.Json;


namespace arivanitask
{
    public class Tests
    {
       
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            //var baseUrl = ConfigurationRoot["AppSettings:BaseUrl"]
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
            driver.Navigate().GoToUrl(Configuration.BaseUrl);
           // driver.Navigate().GoToUrl("AppSettings:BaseUrl");
            var pagemodel = new PageModel();
            
            PageFactory.InitElements(driver, pagemodel);
            pagemodel.Name.SendKeys(Configuration.Name);
            pagemodel.Email.SendKeys(Configuration.Email);
            pagemodel.Password.SendKeys(Configuration.password);
            pagemodel.Gender.Click();
            pagemodel.quali.Click();
            pagemodel.dob.SendKeys(Configuration.Dob);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            System.Threading.Thread.Sleep(1000);
            pagemodel.pic.SendKeys(Configuration.pic);
            pagemodel.address.SendKeys(Configuration.address);
            pagemodel.city.SendKeys(Configuration.city);
            System.Threading.Thread.Sleep(1000);
            
            pagemodel.btn.Click();
            
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl(Configuration.BaseUrl);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", pagemodel.element);
            System.Threading.Thread.Sleep(5000);
            pagemodel.delete.Click();
           
            System.Threading.Thread.Sleep(3000);
           
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", pagemodel.element);
            System.Threading.Thread.Sleep(2000);
            pagemodel.edit.Click();
            System.Threading.Thread.Sleep(000);
            pagemodel.city.SendKeys(Configuration.ucity);
            pagemodel.Password.Clear();
            pagemodel.Password.SendKeys(Configuration.upassword);
            pagemodel.pic.SendKeys(Configuration.upic);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", pagemodel.editbtn);
            System.Threading.Thread.Sleep(2000);
            pagemodel.editbtn.Click();
            
            System.Threading.Thread.Sleep(2000);
           
            driver.Quit();
        }
       
    }
}