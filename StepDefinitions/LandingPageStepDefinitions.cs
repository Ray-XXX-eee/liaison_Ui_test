using LiasonGroup_test.Pages;
using LiasonGroup_test.Hooks;
using LiasonGroup_test.utils;
using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace LiasonGroup_test.Steps;

/**
 * This class contains SpecFlow steps for user registration on the application.
 */
[Binding]
public sealed class LandingPageStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IPage _page;
    private readonly BasePage _basePage;
    private readonly Config? _config;

    public LandingPageStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _page = Hooks.Hooks.Page!;
        _basePage = new BasePage(_page);
        _config = Hooks.Hooks.Config!;
    }

    [Given(@"user navigates to the website")]
    public async Task goto_landing_page()
    {
        await _page.GotoAsync(_config!.url!);
        await _page.WaitForTimeoutAsync(3000);
    }


    [When(@"checks all header hyperlink options")]
    public async Task header_hyperlink_check()
    {
       await _basePage.VerifyHeaderHyperlinks();
    }


    [When(@"")]
    public async Task WhenTheUserClicksOnTheSignUpButton()
    {
        
    }

    [Then(@"")]
    public void ThenTheUserShouldBeRegisteredSuccessfully()
    {
       
    }
}