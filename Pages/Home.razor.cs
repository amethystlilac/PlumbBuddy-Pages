namespace PlumbBuddyPages.Pages;

partial class Home
{
    string currentVersion = "Checking";

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (firstRender)
        {
            var releases = await new GitHubClient(new ProductHeaderValue("PlumbBuddy.app")).Repository.Release.GetAll("Llama-Logic", "PlumbBuddy");
            var currentMostStableRelease = releases
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
            currentVersion = currentMostStableRelease?.TagName[(currentMostStableRelease.TagName.IndexOf("/") + 1)..] ?? "Unknown";
            StateHasChanged();
        }
    }
}
