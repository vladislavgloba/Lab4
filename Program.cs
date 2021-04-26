using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestareSoft4
{
    class Program
    {
        //creem un driver
        private static IWebDriver driver;

        
        static void Main(string[] args)
        {
            //creem un obiec ChromeDriver - pentru google chrome
            driver = new ChromeDriver();

            //apelam functia un transmitem site-ul, elementul search, si elementul din header
            siteSearch("https://www.google.com/", new Xpaths().googleXpath, new Xpaths().googleHeader);
            //siteSearch("https://www.youtube.com/", new Xpaths().youtubeXpath, new Xpaths().youtubeHeader);
            //siteSearch("https://www.amazon.com/", new Xpaths().amazonXpath, new Xpaths().amazonHeader);
            //siteSearch("https://www.ebay.com/", new Xpaths().ebayXpath, new Xpaths().ebayHeader);
        }
        
       
        //metoda Search care primeste 3 parametri: site - xpath(ce cautam) - xpath pentru header (un element din header)
        static void siteSearch(string siteUrl, string searchXpath, string headerXpath)
        {
            //marim fereastra
            driver.Manage().Window.Maximize();
            //accesam url-ul primit ca parametru
            driver.Navigate().GoToUrl(siteUrl);
            //cautam elementul unde urmeaza sa introducem cuvintul dorit
            var search = driver.FindElement(By.XPath(searchXpath));
            //facem click pe elementul gasit (search)
            search.Click();
            //introducem cuvintul
            search.SendKeys("computer");
            //tastam tasta enter
            search.SendKeys(Keys.Enter);

            //verificam daca exista elementul cautat in header
            if (driver.FindElement(By.XPath(headerXpath)) != null)
            {
                //daca e diferit de null, atunci elementul exista, a fost gasit
                Console.WriteLine("Header is displayed");
                Console.ReadLine();
            }
            else
            {
                //daca e null, elementul nu a fost gasit.
                Console.WriteLine("Header is not displayed");
                Console.ReadLine();
            }
        }
    }
}