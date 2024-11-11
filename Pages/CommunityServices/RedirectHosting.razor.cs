namespace PlumbBuddyPages.Pages.CommunityServices;

partial class RedirectHosting
{
    const string markdown =
        """
        This page displays redirect links, intended for creators to use in their Llama Logic mod manifests, to ensure that the manifests contain stable links.

        Please note that some of these links may lead to adult or otherwise sensitive content.

        If you’d like to use a redirect link in your own manifest, you have two options.

        ##### Option 1: Discord
        1. [Join the PlumbBuddy Discord Server](https://discord.gg/XKbMEEfRde). You’ll need to agree to the rules and take the Creator role.
        2. Come to the `#resources_and_templates` channel, in the `MOD CREATOR AREA` category. Create a thread by clicking the spool of thread at the top.
        3. Copy the Mod URL redirect request form template and fill in your information. You can see examples below.
        4. Wait for us to see your thread. We may have further questions, or your next notification may be that we have actioned your request.
        5. Once we’ve completed the process, the thread will be closed. If you need to update your information, please open a new thread.

        ##### Option 2: Github
        1. There are two identical files that need to be updated, listed as the links below. They are kept in [the GitHub repository for this website](https://github.com/Llama-Logic/PlumbBuddy-Pages). The easiest way to do that is to fork the repo, alter those files, and submit a pull request. To see how to do that, you can [review this video](https://youtu.be/bdb0JQ-j6U4?t=214).
        2. Please keep the entries in alphabetical order, by owner (creator) name, starting after ModGuard. Use the redirects already listed as examples. Format is important.
        3. Submit your pull request. You may be asked for more information or to make changes. Please subscribe to notifications on the pull request and watch the email associated with your Github account to avoid having it denied due to non-responsiveness.

        ###### `redirects.yml` Locations
        """;

    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Community Services", "/community-services", icon: MaterialDesignIcons.Normal.Offer),
        new("Redirect Hosting", "/community-services/redirect-hosting", icon: MaterialDesignIcons.Normal.Share)
    ];
    IReadOnlyDictionary<string, Uri>? redirects;
    string redirectsSearchText = string.Empty;

    bool IncludeRedirect(KeyValuePair<string, Uri> keyValuePair)
    {
        if (string.IsNullOrWhiteSpace(redirectsSearchText))
            return true;
        if (keyValuePair.Key.Contains(redirectsSearchText, StringComparison.OrdinalIgnoreCase))
            return true;
        if (keyValuePair.Value.ToString().Contains(redirectsSearchText, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

    protected override async Task OnInitializedAsync()
    {
        redirects = await HttpClient.GetFromYamlAsync<Dictionary<string, Uri>>("community-data/redirects.yml");
    }
}
