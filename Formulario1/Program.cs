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
            string email = "nathanvmag@gmail.com";
            string[] keys = new string []{ "a", "b", "c", "d", "e", "f", "g" };

            IWebDriver driver = new ChromeDriver("./");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            
            driver.Navigate().GoToUrl("https://resgata.typeform.com/to/OQlWEc?parceiro=xxxxx&campanha=xxxxx");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("stkv-text-4a8f52af-5a9b-4a99-a80a-c07722df2d77")).SendKeys(email);
            driver.FindElement(By.Id("stkv-text-4a8f52af-5a9b-4a99-a80a-c07722df2d77")).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.CssSelector("[data-qa='submit-button']")).Click();
            Thread.Sleep(1500);
            driver.Navigate().GoToUrl("https://resgata.typeform.com/to/Ee50tJ?email="+email);
            Thread.Sleep(3000);
            string nome = "Nathan";
            driver.FindElement(By.Id("CKHvXJ5L4JC1")).FindElement(By.TagName("input")).SendKeys(nome);
            driver.FindElement(By.Id("CKHvXJ5L4JC1")).FindElement(By.TagName("input")).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            string cpf = "18393782716";
            driver.FindElement(By.Id("ayTVWKRFOPvc")).FindElement(By.TagName("input")).SendKeys(cpf);
            driver.FindElement(By.Id("ayTVWKRFOPvc")).FindElement(By.TagName("input")).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            int code = 4;
            driver.FindElement(By.TagName("body")).SendKeys(keys[code]);
            Thread.Sleep(1000);
            if(code>2&&code<6)
            {
                string tem = "s";
                driver.FindElement(By.TagName("body")).SendKeys(tem);
                Thread.Sleep(500);

                if (tem=="s")
                {
                    driver.FindElement(By.Id("fYMJYQ2RMd4d")).FindElement(By.TagName("input")).SendKeys("2u312u3901u3");
                    driver.FindElement(By.Id("fYMJYQ2RMd4d")).FindElement(By.TagName("input")).SendKeys(Keys.Enter);
                    Thread.Sleep(500);                    
                }
            }
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='unfixed-footer']/div[3]/div[1]/div[1]")).Click();
            Thread.Sleep(500);
            //var cpf = "";
            driver.Navigate().GoToUrl("https://resgata.typeform.com/to/pA7BPm?email=" + email + "&cpf=" + cpf);
            Thread.Sleep(3000);
            string titu = "s";
          
            if(titu=="s")
            {
                driver.FindElement(By.Id("choice-3dc23ea9-1c47-4d9e-adb2-16961318b593-yes")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("block-7b0be0e8-2539-4985-954a-76c9634aa4b0")). FindElements(By.CssSelector("[data-qa='choice']"))[4].Click();

                Thread.Sleep(1500);
                driver.FindElement(By.Id("block-fce2150b-4b7f-44a7-877e-77fa74afb5d1")).FindElement( By.TagName("button")).SendKeys(Keys.Enter);

                Thread.Sleep(1500);
                driver.FindElement(By.Id("choice-81421ff5-b6ef-4e01-8a00-a335e93529ef-accept")).Click();
                Thread.Sleep(1500);
                driver.FindElement(By.Id("choice-6f6497ee-0667-4761-98c7-3baeeb3105ec-accept")).Click();
                Thread.Sleep(1500);

            }
            else
            {
                driver.FindElement(By.Id("choice-3dc23ea9-1c47-4d9e-adb2-16961318b593-no")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("stkv-text-3be19b11-3c01-4989-98ff-2dfd1338634e")).SendKeys("Nome titular");
                driver.FindElement(By.Id("stkv-text-3be19b11-3c01-4989-98ff-2dfd1338634e")).SendKeys(Keys.Enter);
                Thread.Sleep(1000);
                driver.FindElement(By.Id("stkv-text-74b597f0-02ff-44c7-b4ef-d3c1e5e3031d")).SendKeys("Nome titular");
                driver.FindElement(By.Id("stkv-text-74b597f0-02ff-44c7-b4ef-d3c1e5e3031d")).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

            }

            driver.FindElement(By.CssSelector("[data-qa='submit-button']")).Click();
            Thread.Sleep(1500);
            driver.Close();
            Console.WriteLine("Sucesso ao executar o preenchimento do formulário");


           
            Environment.Exit(0);



        }
    }
}
