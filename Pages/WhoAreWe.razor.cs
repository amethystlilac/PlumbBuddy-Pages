namespace PlumbBuddyPages.Pages;

partial class WhoAreWe
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Who Are We?", "/who-are-we", icon: MaterialDesignIcons.Normal.AccountQuestion)
    ];
}
