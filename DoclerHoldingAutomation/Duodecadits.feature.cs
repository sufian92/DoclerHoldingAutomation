﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DoclerHoldingAutomation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Duodecadits Functionality")]
    public partial class DuodecaditsFunctionalityFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Duodecadits.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Duodecadits Functionality", "\tIn order to do my job\r\n\tAs a User\r\n\tI want duodecadits.com web application to fu" +
                    "nction properly", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The title of every page in the application is \"UI Testing Site\"")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void TheTitleOfEveryPageInTheApplicationIsUITestingSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The title of every page in the application is \"UI Testing Site\"", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I navigate to each page in the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("the title of each page should be \"UI Testing Site\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Company logo is present  in each page")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void TheCompanyLogoIsPresentInEachPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Company logo is present  in each page", new string[] {
                        "mytag"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I navigate to each page in the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("the company logo must be present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clicking the home button redirects to the home page")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ClickingTheHomeButtonRedirectsToTheHomePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking the home button redirects to the home page", new string[] {
                        "mytag"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When("I Click on the Home button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("I am redirected to the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clicking the home button turns the home button active")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ClickingTheHomeButtonTurnsTheHomeButtonActive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking the home button turns the home button active", new string[] {
                        "mytag"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.When("I Click on the Home button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("the home button becomes active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clicking the form button redirects to the form page")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ClickingTheFormButtonRedirectsToTheFormPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking the form button redirects to the form page", new string[] {
                        "mytag"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When("I Click on the Form button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("I am redirected to the Form page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clicking the form button turns the form button active")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ClickingTheFormButtonTurnsTheFormButtonActive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking the form button turns the form button active", new string[] {
                        "mytag"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When("I Click on the Form button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("the Form button becomes active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clicking the error button gives an 404 HTTP response code")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ClickingTheErrorButtonGivesAn404HTTPResponseCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking the error button gives an 404 HTTP response code", new string[] {
                        "mytag"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.When("I Click on the Error button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("i get a 404 HTTP response code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clicking the UI Testong button redirects to the home page")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ClickingTheUITestongButtonRedirectsToTheHomePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking the UI Testong button redirects to the home page", new string[] {
                        "mytag"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.When("I Click on the UI Testing button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("I am redirected to the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The header of the Home Page should be Correct")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void TheHeaderOfTheHomePageShouldBeCorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The header of the Home Page should be Correct", new string[] {
                        "mytag"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.When("I Click on the Home button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("the header of the page should be \"Welcome to the Docler Holding QA Department\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The content message of the Home Page should be Correct")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void TheContentMessageOfTheHomePageShouldBeCorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The content message of the Home Page should be Correct", new string[] {
                        "mytag"});
#line 61
this.ScenarioSetup(scenarioInfo);
#line 62
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
 testRunner.When("I Click on the Home button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("the content message of the page should be \"This site is dedicated to perform some" +
                    " exercises and demonstrate automated web testing.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Form page contains one input box and one submit button")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void FormPageContainsOneInputBoxAndOneSubmitButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Form page contains one input box and one submit button", new string[] {
                        "mytag"});
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
 testRunner.When("I Click on the Form button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("the form page opens and contains one input box and one submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Submiting the form in the form page redirects to the hello page which shows the c" +
            "orrect output")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void SubmitingTheFormInTheFormPageRedirectsToTheHelloPageWhichShowsTheCorrectOutput()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Submiting the form in the form page redirects to the hello page which shows the c" +
                    "orrect output", new string[] {
                        "mytag"});
#line 73
this.ScenarioSetup(scenarioInfo);
#line 74
 testRunner.Given("I Navigated to \"http://uitest.duodecadits.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
 testRunner.When("i submit the form with a name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("the hello page appears and it contains the name i submitted along side a hello me" +
                    "ssage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion