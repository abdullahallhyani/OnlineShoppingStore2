using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class login
    {
        [Given(@"I lanunch the site")]
        public void GivenILanunchTheSite()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter the following detals")]
        public void GivenIEnterTheFollowingDetals(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click login boutton")]
        public void GivenIClickLoginBoutton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"go to dashebord")]
        public void ThenGoToDashebord()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
