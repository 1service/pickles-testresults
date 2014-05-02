﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecRun
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Scenario Outlines", Description="Here we demonstrate how we deal with scenario outlines", SourceFile="ScenarioOutlines.feature", SourceLine=0)]
    public partial class ScenarioOutlinesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScenarioOutlines.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenario Outlines", "Here we demonstrate how we deal with scenario outlines", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        public virtual void ThisIsAScenarioOutlineWhereAllScenariosPass(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline where all scenarios pass", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 8
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where all scenarios pass, pass_1", Description="\nThis means the entire scenario outline passes.", SourceLine=11)]
        public virtual void ThisIsAScenarioOutlineWhereAllScenariosPass_Pass_1()
        {
            this.ThisIsAScenarioOutlineWhereAllScenariosPass("pass_1", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where all scenarios pass, pass_2", Description="\nThis means the entire scenario outline passes.", SourceLine=12)]
        public virtual void ThisIsAScenarioOutlineWhereAllScenariosPass_Pass_2()
        {
            this.ThisIsAScenarioOutlineWhereAllScenariosPass("pass_2", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where all scenarios pass, pass_3", Description="\nThis means the entire scenario outline passes.", SourceLine=13)]
        public virtual void ThisIsAScenarioOutlineWhereAllScenariosPass_Pass_3()
        {
            this.ThisIsAScenarioOutlineWhereAllScenariosPass("pass_3", ((string[])(null)));
        }
        
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioIsInconclusive(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline where one scenario is inconclusive", exampleTags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 21
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where one scenario is inconclusive, pass_1", Description="\nThis means the entire scenario outline is inconclusive.", SourceLine=24)]
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioIsInconclusive_Pass_1()
        {
            this.ThisIsAScenarioOutlineWhereOneScenarioIsInconclusive("pass_1", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where one scenario is inconclusive, pass_2", Description="\nThis means the entire scenario outline is inconclusive.", SourceLine=25)]
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioIsInconclusive_Pass_2()
        {
            this.ThisIsAScenarioOutlineWhereOneScenarioIsInconclusive("pass_2", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where one scenario is inconclusive, inconclusive_1", Description="\nThis means the entire scenario outline is inconclusive.", SourceLine=26)]
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioIsInconclusive_Inconclusive_1()
        {
            this.ThisIsAScenarioOutlineWhereOneScenarioIsInconclusive("inconclusive_1", ((string[])(null)));
        }
        
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioFails(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline where one scenario fails", exampleTags);
#line 30
this.ScenarioSetup(scenarioInfo);
#line 34
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where one scenario fails, pass_1", Description="\nThis means the entire scenario outline fails.", SourceLine=37)]
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioFails_Pass_1()
        {
            this.ThisIsAScenarioOutlineWhereOneScenarioFails("pass_1", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where one scenario fails, pass_2", Description="\nThis means the entire scenario outline fails.", SourceLine=38)]
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioFails_Pass_2()
        {
            this.ThisIsAScenarioOutlineWhereOneScenarioFails("pass_2", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline where one scenario fails, fail_1", Description="\nThis means the entire scenario outline fails.", SourceLine=39)]
        public virtual void ThisIsAScenarioOutlineWhereOneScenarioFails_Fail_1()
        {
            this.ThisIsAScenarioOutlineWhereOneScenarioFails("fail_1", ((string[])(null)));
        }
        
        public virtual void AndWeCanGoTotallyBonkersWithMultipleExampleSections_(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("And we can go totally bonkers with multiple example sections.", exampleTags);
#line 43
this.ScenarioSetup(scenarioInfo);
#line 45
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("And we can go totally bonkers with multiple example sections., Examples 1, pass_1" +
            "", SourceLine=48)]
        public virtual void AndWeCanGoTotallyBonkersWithMultipleExampleSections__ExampleSet0_Pass_1()
        {
            this.AndWeCanGoTotallyBonkersWithMultipleExampleSections_("pass_1", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("And we can go totally bonkers with multiple example sections., Examples 1, pass_2" +
            "", SourceLine=49)]
        public virtual void AndWeCanGoTotallyBonkersWithMultipleExampleSections__ExampleSet0_Pass_2()
        {
            this.AndWeCanGoTotallyBonkersWithMultipleExampleSections_("pass_2", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("And we can go totally bonkers with multiple example sections., Examples 2, inconc" +
            "lusive_1", SourceLine=53)]
        public virtual void AndWeCanGoTotallyBonkersWithMultipleExampleSections__ExampleSet1_Inconclusive_1()
        {
            this.AndWeCanGoTotallyBonkersWithMultipleExampleSections_("inconclusive_1", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("And we can go totally bonkers with multiple example sections., Examples 2, inconc" +
            "lusive_2", SourceLine=54)]
        public virtual void AndWeCanGoTotallyBonkersWithMultipleExampleSections__ExampleSet1_Inconclusive_2()
        {
            this.AndWeCanGoTotallyBonkersWithMultipleExampleSections_("inconclusive_2", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("And we can go totally bonkers with multiple example sections., Examples 3, fail_1" +
            "", SourceLine=58)]
        public virtual void AndWeCanGoTotallyBonkersWithMultipleExampleSections__ExampleSet2_Fail_1()
        {
            this.AndWeCanGoTotallyBonkersWithMultipleExampleSections_("fail_1", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("And we can go totally bonkers with multiple example sections., Examples 3, fail_2" +
            "", SourceLine=59)]
        public virtual void AndWeCanGoTotallyBonkersWithMultipleExampleSections__ExampleSet2_Fail_2()
        {
            this.AndWeCanGoTotallyBonkersWithMultipleExampleSections_("fail_2", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
