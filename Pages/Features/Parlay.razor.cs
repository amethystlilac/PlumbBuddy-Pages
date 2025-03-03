namespace PlumbBuddyPages.Pages.Features;

partial class Parlay
{

    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Features", "/features", icon: MaterialDesignIcons.Normal.FeatureSearch),
        new("Parlay", "/features/parlay", icon: MaterialDesignIcons.Normal.TranslateVariant)
    ];
}
