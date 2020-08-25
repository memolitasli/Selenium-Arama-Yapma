using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {

            string[] aranan_kelime_listesi ={
           "google da aratılacak",
           "anahtar kelimeler"


        };
            string[] firmaisimleri =
              {
                "google aramasında",
                "bulunması istenilen adresler",
                
            };




           
          
              while (true)
             {
           
           

              for(int i = 0; i < aranan_kelime_listesi.Length; i++)
             {
                    IWebDriver driver = new ChromeDriver();

                    driver.Navigate().GoToUrl("https://www.google.com.tr/");

                    IWebElement element = driver.FindElement(By.Name("q"));
                    Random rnd = new Random();
                  
                    element.SendKeys(aranan_kelime_listesi[i]);
                    element.SendKeys(Keys.Enter);
                    for (int j = 0; j < firmaisimleri.Length; j++)
                    {
                        IWebElement e2 = e2 = driver.FindElement(By.PartialLinkText(firmaisimleri[j]));
                        e2.Click();
                        Thread.Sleep(rnd.Next(1000,10000) + 40000); //sitede beklemesini istediğim süre 40 - 50 sn arasında

                        driver.Navigate().Back();// geri gel 
                        
                    }
                    driver.Manage().Cookies.DeleteAllCookies(); // cookieleri sildim
                    driver.Close(); // driveri kapatıyorum bu sayede ilk for döngüsünde tekrar driver açıp yeni arama yapabilirim
              }
             
        


        }
          


        }
       
    }
}



