namespace PlumbBuddyPages.Pages.Features;

partial class ManifestEditor
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("Features", "/features", icon: MaterialDesignIcons.Normal.FeatureSearch),
        new("Manifest Editor", "/features/manifest-editor", icon: MaterialDesignIcons.Normal.TagEdit)
    ];

    readonly string scaffoldingMarkdown =
        """
        * The name of your mod
        * Whether you marked that file as required
        * What the component name of that file was
        * What your hashing level was when you last updated the manifest
        * How to find other files in your mod on your computer
        """;
}
