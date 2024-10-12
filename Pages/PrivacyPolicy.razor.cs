namespace PlumbBuddyPages.Pages;

partial class PrivacyPolicy
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Privacy Policy", null, icon: MaterialDesignIcons.Normal.ShieldAccount)
    ];
    string markdown = string.Empty;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("PlumbBuddyPages.Resources.PrivacyPolicy.md");
        if (stream is not null)
        {
            using var reader = new StreamReader(stream);
            markdown = reader.ReadToEnd();
            StateHasChanged();
        }
    }
}
