﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bang.Tests.Features.InGame
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TourDunJoueurFeature : object, Xunit.IClassFixture<TourDunJoueurFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "BeginRound.feature"
#line hidden
        
        public TourDunJoueurFeature(TourDunJoueurFeature.FixtureData fixtureData, Bang_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("fr-FR"), "Features/InGame", "Tour d\'un joueur", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "playerName",
                        "characterName",
                        "role"});
            table1.AddRow(new string[] {
                        "Jean",
                        "Bart Cassidy",
                        "Schérif"});
            table1.AddRow(new string[] {
                        "Max",
                        "Rose Doolan",
                        "Renégat"});
            table1.AddRow(new string[] {
                        "Emilie",
                        "Willy le Kid",
                        "Hors-la-loi"});
            table1.AddRow(new string[] {
                        "Martin",
                        "Sam le Vautour",
                        "Hors-la-loi"});
#line 5
 testRunner.Given("une partie est créée avec ces joueurs", ((string)(null)), table1, "Sachant qu\'");
#line hidden
#line 11
 testRunner.And("tous les joueurs ont rejoint la partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et que ");
#line hidden
#line 12
 testRunner.When("c\'est au tour de \"Jean\", il pioche 2 cartes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line hidden
#line 13
 testRunner.Then("\"Jean\" possède 7 cartes en main", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Jouer une carte bleue")]
        [Xunit.TraitAttribute("FeatureTitle", "Tour d\'un joueur")]
        [Xunit.TraitAttribute("Description", "Jouer une carte bleue")]
        public void JouerUneCarteBleue()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Jouer une carte bleue", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 16
 testRunner.When("\"Jean\" joue une carte bleue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line hidden
#line 17
 testRunner.Then("\"Jean\" possède 6 cartes en main", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TourDunJoueurFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TourDunJoueurFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
