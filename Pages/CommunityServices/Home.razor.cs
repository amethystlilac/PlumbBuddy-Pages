namespace PlumbBuddyPages.Pages.CommunityServices;

partial class Home
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Community Services", "/community-services", icon: MaterialDesignIcons.Normal.Offer)
    ];
}
