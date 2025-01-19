namespace PlumbBuddyPages.Pages.Features;

partial class Archivist
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Features", "/features", icon: MaterialDesignIcons.Normal.FeatureSearch),
        new("Archivist", "/features/archivist", icon: MaterialDesignIcons.Normal.ArchiveClock)
    ];
}
