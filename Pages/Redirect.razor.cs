namespace PlumbBuddyPages.Pages;

partial class Redirect
{
    class PackDescription
    {
        public required string EnglishName { get; set; }
        public required string EaStub { get; set; }
        public required string SteamStub { get; set; }
    }

    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Redirect", "/redirect", icon: MaterialDesignIcons.Normal.Share)
    ];
    bool loadingRedirects;
    bool loadingRedirectsFailed;
    bool noRedirect;
    Dictionary<string, StringValues>? queryString;
    bool redirecting;
    Uri? redirectLocation;
    bool redirectNotFound;
    bool tooManyRedirects;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        queryString = QueryHelpers.ParseQuery(new Uri(NavigationManager.Uri).Query);
        if (!queryString.ContainsKey("to") && !queryString.ContainsKey("purchase-pack"))
        {
            noRedirect = true;
            return;
        }
        if (queryString.TryGetValue("to", out var redirectNames) && redirectNames.Count is > 1 || queryString.TryGetValue("purchase-pack", out var purchasePackCodes) && purchasePackCodes.Count is > 1)
        {
            tooManyRedirects = true;
            return;
        }
        loadingRedirects = true;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (firstRender && !noRedirect && !tooManyRedirects && queryString is not null)
        {
            if (queryString.TryGetValue("purchase-pack", out var purchasePackCodes) && purchasePackCodes.Count is 1)
            {
                Dictionary<string, PackDescription>? packDescriptionByPackCode = null;
                try
                {
                    packDescriptionByPackCode = await HttpClient.GetFromYamlAsync<Dictionary<string, PackDescription>>("community-data/packs.yml");
                }
                catch
                {
                }
                loadingRedirects = false;
                if (packDescriptionByPackCode is null)
                {
                    loadingRedirectsFailed = true;
                    StateHasChanged();
                    return;
                }
                if (!packDescriptionByPackCode.TryGetValue(purchasePackCodes[0] ?? string.Empty, out var packDescription))
                {
                    redirectNotFound = true;
                    StateHasChanged();
                    return;
                }
                redirectLocation = (!queryString.TryGetValue("from", out var fromValues) || fromValues.Count is 0 ? "ea" : fromValues[0]) switch
                {
                    "ea" => new Uri($"https://www.ea.com/games/the-sims/the-sims-4/store/addons/{packDescription.EaStub}", UriKind.Absolute),
                    "steam" => new Uri($"https://store.steampowered.com/app/{packDescription.SteamStub}", UriKind.Absolute),
                    _ => null
                };
            }
            else if (queryString.TryGetValue("to", out var redirectNames))
            {
                Dictionary<string, Uri>? redirects = null;
                try
                {
                    redirects = await HttpClient.GetFromYamlAsync<Dictionary<string, Uri>>("community-data/redirects.yml");
                }
                catch
                {
                }
                loadingRedirects = false;
                if (redirects is null)
                {
                    loadingRedirectsFailed = true;
                    StateHasChanged();
                    return;
                }
                if (!redirects.TryGetValue(redirectNames[0] ?? string.Empty, out redirectLocation))
                {
                    redirectNotFound = true;
                    StateHasChanged();
                    return;
                }
            }
            if (redirectLocation is null)
            {
                redirectNotFound = true;
                StateHasChanged();
                return;
            }
            redirecting = true;
            StateHasChanged();
            await JSRuntime.InvokeVoidAsync("redirectToExternalUrl", redirectLocation.ToString(), 3000);
        }
    }
}
