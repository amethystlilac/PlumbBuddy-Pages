namespace PlumbBuddyPages.Pages.Features;

partial class Home
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Features", "/features", icon: MaterialDesignIcons.Normal.FeatureSearch)
    ];
}
