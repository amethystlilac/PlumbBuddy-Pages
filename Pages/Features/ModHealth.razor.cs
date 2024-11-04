namespace PlumbBuddyPages.Pages.Features;

partial class ModHealth
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Features", "/features", icon: MaterialDesignIcons.Normal.FeatureSearch),
        new("Mod Health", "/features/mod-health", icon: MaterialDesignIcons.Normal.BottleTonicPlus)
    ];
}
