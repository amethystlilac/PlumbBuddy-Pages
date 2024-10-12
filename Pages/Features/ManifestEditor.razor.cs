namespace PlumbBuddyPages.Pages.Features;

partial class ManifestEditor
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Features", "/features", icon: MaterialDesignIcons.Normal.FeatureSearch),
        new("Manifest Editor", "/features/manifest-editor", icon: MaterialDesignIcons.Normal.TagEdit)
    ];
}
