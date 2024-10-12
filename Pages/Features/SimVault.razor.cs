namespace PlumbBuddyPages.Pages.Features;

partial class SimVault
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Features", "/features", icon: MaterialDesignIcons.Normal.FeatureSearch),
        new("SimVault", "/features/simvault", icon: MaterialDesignIcons.Normal.ArchiveSync)
    ];
}
