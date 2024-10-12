namespace PlumbBuddyPages.Pages.Features;

partial class Catalog
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Features", "/features", icon: MaterialDesignIcons.Normal.FeatureSearch),
        new("Catalog", "/features/catalog", icon: MaterialDesignIcons.Normal.Book)
    ];
}
