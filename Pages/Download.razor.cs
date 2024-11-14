namespace PlumbBuddyPages.Pages;

partial class Download
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Download", "/download", icon: MaterialDesignIcons.Normal.Download)
    ];
    bool isInitializationComplete;
    ReleaseAsset? macOSOptimalReleaseAsset;
    Release? optimalRelease;
    ReleaseAsset? windowsOptimalReleaseAsset;
    string os = string.Empty;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (firstRender)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            os = await JSRuntime.InvokeAsync<string>("getOperatingSystem");
            var releases = await new GitHubClient(new ProductHeaderValue("PlumbBuddy.app")).Repository.Release.GetAll("Llama-Logic", "PlumbBuddy");
            optimalRelease = releases
                .OrderBy(release => release.TagName switch
                {
                    string alphaReleaseTagName when alphaReleaseTagName.StartsWith("release/") => 0,
                    string alphaReleaseTagName when alphaReleaseTagName.StartsWith("release-preview/") => 1,
                    string alphaReleaseTagName when alphaReleaseTagName.StartsWith("release-beta/") => 2,
                    string alphaReleaseTagName when alphaReleaseTagName.StartsWith("release-alpha/") => 3,
                    _ => int.MaxValue
                })
                .ThenByDescending(release => release.PublishedAt ?? release.CreatedAt)
                .FirstOrDefault();
            windowsOptimalReleaseAsset = optimalRelease?.Assets.OrderBy(a => a.Name.Length).ThenBy(a => a.Name).FirstOrDefault(a => a.Name.EndsWith(".msix"));
            macOSOptimalReleaseAsset = optimalRelease?.Assets.OrderBy(a => a.Name.Length).ThenBy(a => a.Name).FirstOrDefault(a => a.Name.EndsWith(".zip"));
            isInitializationComplete = true;
            StateHasChanged();
        }
    }
}
