namespace PlumbBuddyPages.Pages;

partial class Redirect
{
    bool loadingRedirects;
    bool loadingRedirectsFailed;
    bool noRedirect;
    bool redirecting;
    string redirectLocation = string.Empty;
    bool redirectNotFound;
    bool tooManyRedirects;
    StringValues redirectNames;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        if (!QueryHelpers.ParseQuery(new Uri(NavigationManager.Uri).Query).TryGetValue("to", out redirectNames))
        {
            noRedirect = true;
            return;
        }
        if (redirectNames.Count > 1)
        {
            tooManyRedirects = true;
            return;
        }
        loadingRedirects = true;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (firstRender && !noRedirect && !tooManyRedirects)
        {
            Dictionary<string, string>? redirects = null;
            try
            {
                redirects = await HttpClient.GetFromJsonAsync<Dictionary<string, string>>("community-data/redirects.json");
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
            if (!redirects.TryGetValue(redirectNames[0] ?? string.Empty, out redirectLocation!) || string.IsNullOrWhiteSpace(redirectLocation))
            {
                redirectNotFound = true;
                StateHasChanged();
                return;
            }
            redirecting = true;
            StateHasChanged();
            await JSRuntime.InvokeVoidAsync("redirectToExternalUrl", redirectLocation, 3000);
        }
    }
}
