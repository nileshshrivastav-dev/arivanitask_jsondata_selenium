using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;

namespace arivanitask.PageObjects
{
    public class PageModel
    {
        private IWebDriver driver;
       
        [FindsBy(How = How.Name, Using = "name")]
        public IWebElement Name { get; set; }
       
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Email { get; set; }
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "male")]
        public IWebElement Gender { get; set; }
        [FindsBy(How =How.Name,Using ="quali")]
        public IWebElement quali { get; set; }
        [FindsBy(How = How.Name, Using = "dob")]
        public IWebElement dob { get; set; }
        [FindsBy(How = How.Name, Using = "pic")]
        public IWebElement pic { get; set; }
        [FindsBy(How = How.Name, Using = "address")]
        public IWebElement address { get; set; }
        [FindsBy(How =How.Name,Using ="city")]
        public IWebElement city { get; set; }
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement btn { get; set; }
        [FindsBy(How = How.Id, Using = "del_4")]
        public IWebElement element { get; set; }
        [FindsBy(How = How.Id, Using = "del_4")]
        public IWebElement delete { get; set; }
        [FindsBy(How = How.Id, Using = "edit_4")]
        public IWebElement edit { get; set; } 
        [FindsBy(How = How.Id, Using = "editbtn")]
        public IWebElement editbtn { get; set; }
      
    }
}
