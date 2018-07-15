using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.IO;


namespace ConsoleApp3
{
    class Class30
    {
        IWebDriver driver;

        [SetUp]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
        }

        public void GoToUrl(string url)
        {
            this.driver.Url = url;
        }

   



    

    //[Test]
    //public void SeleniumEasyTC001()
    //{
    //    GoToUrl("http://www.seleniumeasy.com/test/basic-checkbox-demo.html");
    //    Thread.Sleep(3000);

    //    IWebElement Checkbox = driver.FindElement(By.Id("isAgeSelected"));
    //    Checkbox.Click();
    //    Thread.Sleep(2000);
    //    IWebElement Message = driver.FindElement(By.XPath("//div[contains(.,'Check box is checked') and @id='txtAge']"));
    //    bool chek1 = Message.Displayed;
    //    string result = Convert.ToString(chek1);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "Message is displayed. " + result + Environment.NewLine);

    //    IWebElement gender = driver.FindElement(By.XPath("//input[@name='optradio' and @value='Female']"));
    //    IWebElement GetValue = driver.FindElement(By.XPath("//button[contains(text(),'Get Checked')]"));
    //    GetValue.Click();
    //    string result1 = gender.GetAtt("value");

    //    IWebElement Message1 = driver.FindElement(By.XPath("//p[contains(.,'Radio')]"));
    //    bool chek2 = Message1.Displayed;
    //    string result2 = Convert.ToString(chek2);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "Radio button " + result1 + "is displayed. " + result2 + Environment.NewLine);


    //    bool chek1 = QALink.Displayed;
    //    string result = Convert.ToString(chek1);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC001 Step 001 - Quality Assurance(QA) link is displayed. " + result + Environment.NewLine);

    //    bool chek2 = QALink.Enabled;
    //    result = Convert.ToString(chek2);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC001 Step 002 - Quality Assurance(QA) link is enabled. " + result + Environment.NewLine);
    //}

    //[Test]
    //public void QATodorovTC002()
    //{
    //    GoToUrl("http://qa.todorowww.net/register");
    //    Thread.Sleep(3000);

    //    IWebElement LogLink = driver.FindElement(By.LinkText("Login"));

    //    bool chek1 = LogLink.Displayed & LogLink.Enabled;
    //    string result = Convert.ToString(chek1);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC002 Step 001 - Login link is displayed and enabled. " + result + Environment.NewLine);

    //    LogLink.Click();

    //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    //    IWebElement Account = wait.Until<IWebElement>(d => d.FindElement(By.LinkText("Create account")));

    //    bool chek2 = Account.Displayed;
    //    result = Convert.ToString(chek2);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC002 Step 002 - Login link is opening right page. " + result + Environment.NewLine);
    //    driver.Navigate().Back();
    //}

    //     [Test]
    //public void QATodorovTC003()
    //{
    //    GoToUrl("http://qa.todorowww.net/register");
    //    Thread.Sleep(3000);

    //    IWebElement NameLabel =driver.FindElement(By.XPath("//div[contains(text(),'Ime')]"));
    //    bool chek1 = NameLabel.Displayed;
    //    string result = Convert.ToString(chek1);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC003 Step 001 - Name Label is displayed. " + result + Environment.NewLine);

    //    IWebElement NameField = driver.FindElement(By.XPath("//input[@name='ime']"));
    //    bool chek2 = NameField.Displayed & NameField.Enabled;
    //    result = Convert.ToString(chek2);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC003 Step 002 - Name Field is displayed and enabled. " + result + Environment.NewLine);

    //    string InNameField = "Petar";
    //    NameField.SendKeys(InNameField);
    //    string OutNameField = NameField.GetAttribute("value");
    //    bool chek3;
    //    if (InNameField == OutNameField)
    //    {
    //        chek3 = true;
    //    }
    //    else
    //    {
    //        chek3 = false;
    //    }
    //    result = Convert.ToString(chek3);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC003 Step 003 - Entered text in Name Field is displayed. " + result + Environment.NewLine);


    //    IWebElement SurnameLabel = driver.FindElement(By.XPath("//div[@class='col-sm-2' and contains(text(),'Prezime')]"));
    //    IWebElement SurnameField = driver.FindElement(By.Name("prezime"));
    //    IWebElement UserNameLabel = driver.FindElement(By.XPath("//div[@class='col-sm-2' and contains(text(),'Koris')]"));
    //    IWebElement UserNameField = driver.FindElement(By.XPath("//input[@name='korisnicko']"));
    //    IWebElement PasswordLabel = driver.FindElement(By.XPath("//input[@id='password']//preceding::div[contains(text(),'Lozinka')]"));
    //    IWebElement PasswordField = driver.FindElement(By.XPath("//input[@id='password']"));
    //    IWebElement PassAgainLabel = driver.FindElement(By.XPath("//div[contains(text(),'druga')]"));
    //    IWebElement PassAgainField = driver.FindElement(By.XPath("//input[@id='passwordAgain']"));

    //    SurnameField.SendKeys("Petrovic");
    //    UserNameField.SendKeys("Pera Peric");
    //    PasswordField.SendKeys("Bilokoja!");
    //    PassAgainField.SendKeys("Bilokoja!");

    //    string OutPasswordField = PasswordField.GetAttribute("value");
    //    string OutPassAgainField = PassAgainField.GetAttribute("value");
    //    bool chek4;

    //    if (OutPasswordField == OutPassAgainField)
    //    {
    //        chek4 = true;
    //    }
    //    else
    //    {
    //        chek4 = false;
    //    }

    //    result = Convert.ToString(chek4);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC003 Step 010 - The same password is displayed in two fields: Password Field and Confirming Password Field. " + result + Environment.NewLine);

    //    IWebElement PolLabel = driver.FindElement(By.XPath("//div[contains(text(),'Pol')]"));
    //    IWebElement PolM = driver.FindElement(By.XPath("//input[@id='pol_m']"));
    //    PolM.Click();
    //    bool chek5 = PolM.Displayed & PolM.Selected;
    //    result = Convert.ToString(chek5);
    //    System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "TC003 Step 0015 - Pol m option is displayed and selected. " + result + Environment.NewLine);

    //    IList<IWebElement> CheckBoxSalata = driver.FindElements(By.Name("volim[]"));
    //    int Size = CheckBoxSalata.Count;
    //    for (int i = 0; i < Size; i++)
    //    {
    //        string Value = CheckBoxSalata.ElementAt(i).GetAttribute("value");

    //        if (Value.Equals("paradajz"))
    //        {
    //            CheckBoxSalata.ElementAt(i).Click();
    //            break;
    //        }

    //    }


    //IWebElement PassSd = driver.FindElement(By.XPath("//input[@id='passwordOptional']"));
    //IWebElement Grad = driver.FindElement(By.Name("grad"));
    //IWebElement Zemlja = driver.FindElement(By.XPath("//select[@name='zemlja']/option[@value='rs']"));
    //IWebElement BojaOciju = driver.FindElement(By.XPath("//input[@id='eyecolor']"));
    //IWebElement BojaKose = driver.FindElement(By.Id("haircolor"));
    //IWebElement Visina = driver.FindElement(By.XPath("//select[@id='visina']/option[@value='160-170']"));
    //IWebElement Tezina = driver.FindElement(By.XPath("//select[@id='tezina']/option[@value='60-80']"));
    //IWebElement KratakUvod = driver.FindElement(By.XPath("//textarea[@id='intro']"));
    //IWebElement OMeni = driver.FindElement(By.XPath("//textarea[@id='aboutme']"));
    //IWebElement Kontakt = driver.FindElement(By.XPath("//input[@value='tel']"));
    //IWebElement Letovanje = driver.FindElement(By.XPath("//select[@name='summer']"));
    //SelectElement oSelect = new SelectElement(Letovanje);
    //oSelect.SelectByValue("pt");
    //IWebElement Register = driver.FindElement(By.XPath("//input[@name='register']"));
    //IWebElement Resetuj = driver.FindElement(By.Name("reset"));

    //string InBojaOciju = "braon";
    //string InBojaKose = "braon";
    //string InKratakUvod = "Mislim, sta reci...";
    //string InOMeni = "Sve se vec zna";

    //BojaOciju.SendKeys(InBojaOciju);
    //BojaKose.SendKeys(InBojaKose);
    //Visina.Click();
    //Tezina.Click();
    //KratakUvod.SendKeys(InKratakUvod);
    //OMeni.SendKeys(InOMeni);
    //Kontakt.Click();


    //Thread.Sleep(3000);





    //bool chek9 = Register.Displayed;
    //result = Convert.ToString(chek9);
    //System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "Button Register is on site" + result + Environment.NewLine);

    //bool chek10 = Resetuj.Displayed;
    //result = Convert.ToString(chek1);
    //System.IO.File.AppendAllText("C:\\Users\\Djuric\\Desktop\\QA kurs - Mira\\Selenium log\\LogSelenium.txt", "Button Reset is displayed" + result + Environment.NewLine);


    //    string InPassSd = "Tyui";
    //    string InGrad = "Beograd"; 


    //    PassSd.SendKeys(InPassSd);
    //    Grad.SendKeys(InGrad);
    //    Zemlja.Click();





    [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }



    }
}
