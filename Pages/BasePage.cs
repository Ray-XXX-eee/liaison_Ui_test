using LiasonGroup_test.Utils;
using Microsoft.Playwright;
using static System.Net.Mime.MediaTypeNames;

namespace LiasonGroup_test.Pages;

/**
 * Class representing the header and footer of the application.
 */
public class BasePage : PageObject

{
    public BasePage(IPage page) : base(page)
    {
    }

    // Common Header Left Locators for elements on the page
    private readonly string header_workforce_link = "(//a[contains(@href, 'liaison-workforce')])[1]";
    private readonly string header_financial_link = "(//a[contains(@href, 'liaison-financial')])[1]";
    private readonly string header_care_link = "(//a[contains(@href, 'liaison-care')])[1]";
    private readonly string header_tempre_link = "(//a[contains(@href, 'tempre')])[1]";


    // Common Header Right Locators for elements on the page
    private readonly string header_newsInsight_link = " //div[class='flex-shrink-0']>a[href*=news-insights-events]";
    private readonly string header_contacts_link = "//div[class='flex-shrink-0']>a[href*=financial]";
    //Hovers 
    private readonly string header_aboutUs_hover = " a[href*='about-group/']:has-text('About us')";
    //private readonly string header_ICS_hover = " //div[class='flex-shrink-0']>a[href*=financial]";



    // Methods to interact with page elements
    public async Task VerifyHeaderHyperlinks()
    {
        await WaitForElementAttached(this.header_workforce_link);
        await WaitForElementAttached(this.header_financial_link);
        await WaitForElementAttached(this.header_financial_link);
        await WaitForElementAttached(this.header_care_link);

        // Future enhancement : Could've tried to open in a new window and verify 
    }

}