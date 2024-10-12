namespace PlumbBuddyPages.Pages;

partial class TermsOfUse
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Terms of Use", null, icon: MaterialDesignIcons.Normal.FileSign)
    ];
    string markdown = string.Empty;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("PlumbBuddyPages.Resources.TermsOfUse.md");
        if (stream is not null)
        {
            using var reader = new StreamReader(stream);
            markdown = reader.ReadToEnd();
            StateHasChanged();
        }
    }
}
