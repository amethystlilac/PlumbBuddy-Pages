namespace PlumbBuddyPages.Pages;

partial class Download
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Download", null, icon: MaterialDesignIcons.Normal.Download)
    ];
    string os = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        os = await JSRuntime.InvokeAsync<string>("getOperatingSystem");
        StateHasChanged();
    }
}
