using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebScraping_NET_Selenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Web Scraping with .NET and Selenium!");

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"https://www.google.com");

            //var inputSearch = driver.FindElement(By.Name(@"q"));

            var inputSearch = driver.FindElement(By.CssSelector(@".gLFyf.gsfi"));

            inputSearch.SendKeys(@"rcr750 youtube");

            inputSearch.Submit();

            var titles = driver.FindElements(By.XPath(@"//div[@role='heading']"));

            foreach (var item in titles)
            {
                Console.WriteLine(item.Text);
            }

            var first = driver.FindElement(By.ClassName(@"yuRUbf"));
            var link = first.FindElement(By.TagName(@"a"));
            driver.Navigate().GoToUrl(link.GetAttribute(@"href"));

            //var btn = driver.FindElement(By.XPath("//*[@id=\"subscribe-button\"]/ytd-button-renderer/a"));
              var btn = driver.FindElement(By.XPath("//*[@id=\"subscribe-button\"]/ytd-button-renderer/a"));
            btn.Click();
        }
    }
}
