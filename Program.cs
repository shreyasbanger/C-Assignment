using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Runtime.Intrinsics.Arm;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
namespace SeleniumAssignment
{
   public class AutomationDriver
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radio1, radio2, radio3;
        IWebElement textBox;
        IWebElement dropdown;
        IWebElement checkbox1,checkbox2,checkbox3;
        IWebElement text;
        public void ExerciseOne(int n)
        {
            Console.WriteLine("Exercise1:");
            switch (n)
            {
                case 1:
                    radio1 = driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(2) > input"));
                    radio1.Click();
                    if (radio1.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 1 Button is clicked");
                    }
                    else
                    {
                        Console.WriteLine("Radio 1 button is not clicked");
                    }
                    break;
                case 2:
                    radio2 = driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(3) > input"));
                    radio2.Click();
                    if (radio2.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 2 Button is clicked");
                    }
                    else
                    {
                        Console.WriteLine("Radio 2 button is not clicked");
                    }
                    break;
                case 3:
                    radio3 = driver.FindElement(By.CssSelector("#radio-btn-example > fieldset > label:nth-child(4) > input"));
                    radio3.Click();
                    if (radio3.GetAttribute("checked") == "true")
                    {
                        Console.WriteLine("Radio 3 Button is clicked");
                    }
                    else
                    {
                        Console.WriteLine("Radio 3 button is not clicked");
                    }
                    break;
            }
        }
        public void ExerciseTwo()
        {
            Console.WriteLine("Exercise2:");
            textBox = driver.FindElement(By.Id("autocomplete"));
            textBox.SendKeys("United States");
            Console.WriteLine("United states is entered");
        }
        public void ExerciseThree()
        {
            Console.WriteLine("Exercise3:");
            dropdown = driver.FindElement(By.Name("dropdown-class-example"));
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByValue("option1");
            Console.WriteLine("Option1 is selected");
            Thread.Sleep(1000);
            selectElement.SelectByValue("option2");
            Console.WriteLine("Option2 is selected");
            Thread.Sleep(1000);
            selectElement.SelectByValue("option3");
            Console.WriteLine("Option3 is selected");
            Thread.Sleep(1000);
        }
        public void ExerciseFour()
        {
            Console.WriteLine("Exercise 4:");
            checkbox1 = driver.FindElement(By.Id("checkBoxOption1"));
            checkbox1.Click();
            if (checkbox1.GetAttribute("checked") == "true")
        {
                Console.WriteLine("Option 1 checkbox has been selected");
            }
            else
            {
                Console.WriteLine("Option 1 checkbox has not been selected");
            }
            Thread.Sleep(1000);
            checkbox1.Click();
            checkbox2 = driver.FindElement(By.Id("checkBoxOption2"));
            checkbox2.Click();
            if (checkbox2.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Option 2 checkbox has been selected");
            }
            else
            {
                Console.WriteLine("Option 2 checkbox has not been selected");
            }
            Thread.Sleep(1000);
            checkbox2.Click();
            checkbox3 = driver.FindElement(By.Id("checkBoxOption3"));
            checkbox3.Click();
            if (checkbox3.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Option 3 checkbox has been selected");
            }
            else
            {
                Console.WriteLine("Option 3 checkbox has not been selected");
            }
            Thread.Sleep(1000);
            checkbox3.Click();
        }
        public void ExerciseFourPointOne()
        {
            Console.WriteLine("Exercise 4.1:");
            checkbox1 = driver.FindElement(By.Id("checkBoxOption1"));
            checkbox1.Click();
            checkbox2 = driver.FindElement(By.Id("checkBoxOption2"));
            checkbox2.Click();
            checkbox3 = driver.FindElement(By.Id("checkBoxOption3"));
            checkbox3.Click();
            if ((checkbox1.GetAttribute("checked") == "true") && (checkbox2.GetAttribute("checked") == "true") && (checkbox3.GetAttribute("checked") == "true"))
            {
                Console.WriteLine("All the Checkbox have been selected");
            }
            else
            {
                Console.WriteLine("All the Checkbox have not been selected");
            }
    }
        public void ExerciseFourPointTwo()
        {
            Console.WriteLine("Exercise 4.2:");
            checkbox1 = driver.FindElement(By.Id("checkBoxOption1"));
            checkbox1.Click();
            checkbox2 = driver.FindElement(By.Id("checkBoxOption2"));
            checkbox2.Click();
            checkbox3 = driver.FindElement(By.Id("checkBoxOption3"));
            checkbox3.Click();
            if ((checkbox1.GetAttribute("checked") == "true") && (checkbox2.GetAttribute("checked") == "true") && (checkbox3.GetAttribute("checked") == "true"))
            {
                Console.WriteLine("All the Checkbox have  been selected");
            }
            else
            {
                Console.WriteLine("All the Checkbox have  been dselected");
            }
        }
        public void ExerciseFive()
        {
            Console.WriteLine("Exercise5:");
            driver.FindElement(By.Id("openwindow")).Click();
            Thread.Sleep(4000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(" Window has popped up on the screen");
        }
        public void ExerciseSix()
        {
            Console.WriteLine("Exercise6:");
            driver.FindElement(By.Id("opentab")).Click();
            Thread.Sleep(4000);
            var tabs = driver.WindowHandles;
            driver.SwitchTo().Window(tabs[1]).Close();
            driver.SwitchTo().Window(tabs[0]);
            Console.WriteLine("You'r on the new page within a new tab in your web browser");
        }
        public void ExerciseSeven()
        {
            text = driver.FindElement(By.Id("name"));
            text.SendKeys("Shreyas");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("alertbtn")).Submit();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
        }
        public void ExerciseEight()
        {
            Console.WriteLine("Exercise8:");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; 
            js.ExecuteScript(String.Format("window.scrollTo({0}, {1})", 400, 627));
        }
        public void ExerciseNine()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(String.Format("window.scrollTo({0}, {1})", 400,1000));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(1000);
            IWebElement hover = driver.FindElement(By.Id("mousehover"));
            IWebElement top = driver.FindElement(By.XPath("/html/body/div[4]/div/fieldset/div/div/a[1]")); 
            Actions action = new Actions(driver); 
            action.MoveToElement(hover).Perform();
            Thread.Sleep(1000);
            action.MoveToElement(top).Perform();
            top.Click();
        }
        static void Main(string[] args)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.qaclickacademy.com/practice.php");
            AutomationDriver o = new AutomationDriver();
            o.ExerciseOne(1);
            Thread.Sleep(1000);
            o.ExerciseOne(2);
            Thread.Sleep(1000);
            o.ExerciseOne(3);
            Thread.Sleep(1000);
            o.ExerciseTwo();
            Thread.Sleep(1000);
            o.ExerciseThree();
            Thread.Sleep(1000);
            o.ExerciseFour();
            Thread.Sleep(1000);
            o.ExerciseFourPointOne();
            Thread.Sleep(1000);
            o.ExerciseFourPointTwo();
            Thread.Sleep(1000);
            o.ExerciseFive();
            Thread.Sleep(1000);
            o.ExerciseSix();
            Thread.Sleep(1000);
            o.ExerciseSeven();
            Thread.Sleep(1000);
            o.ExerciseEight();
            Thread.Sleep(1000);
            o.ExerciseNine();
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
