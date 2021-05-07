using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestFramework.BDD
{
    [Binding]
    public class ProceedToCheckout
    {
        ProductSelectionSteps _productSelection = new ProductSelectionSteps();
        AP_Website _website = new AP_Website("chrome");
        

        [Given(@"I am on the tshirt page")]
        public void GivenIAmOnTheTshirtPage()
        {
            _productSelection.WhenIAddTheProductToTheCart();
        }
        
        
    }
}
