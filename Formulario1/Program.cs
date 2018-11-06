using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Formulario1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("./");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://resgata.typeform.com/to/F7Ou7H");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("[data-qa='start-button']")).Click();
            Thread.Sleep(500);

            driver.FindElement(By.Id("stkv-text-d36105a6-8dff-4417-b54c-1e036c1f5634")).SendKeys("Nathan");
            driver.FindElement(By.Id("stkv-text-d36105a6-8dff-4417-b54c-1e036c1f5634")).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.Id("stkv-text-272f73c7-1ed1-408e-bce3-8a7a0f76e1cd")).SendKeys("111111111111");
            driver.FindElement(By.Id("stkv-text-272f73c7-1ed1-408e-bce3-8a7a0f76e1cd")).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.Id("choice-20fe8834-25f0-4e32-aa2b-22bf8040003d-yes")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("choice-98a13788-f0e1-4eee-84e2-033f085baf01")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id='unfixedFooter']/div[1]/div/div/div/div/div/button")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector("[data-qa='start-button']")).Click();
            Thread.Sleep(500);
            driver.FindElements(By.CssSelector("[data-qa='opinion-scale-step']"))[4].Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("[data-qa='submit-button']")).Click();
            Thread.Sleep(3000);
            string resu = driver.FindElement(By.XPath("//*[@id='root']/div/div[3]/div/div/div/div/div[1]/h1")).GetAttribute("innerHTML"); 
            driver.Close();


            Console.WriteLine("O resultado do formulário é "+resu);

            Environment.Exit(0);



        }
    }
}
