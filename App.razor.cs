namespace PlumbBuddyPages;

partial class App
{
    readonly IReadOnlyList<BreadcrumbItem> breadcrumbs =
    [
        new("PlumbBuddy.app", "/", icon: MaterialDesignIcons.Normal.Web),
        new("HTTP 404 — Not Found", null, true, MaterialDesignIcons.Normal.FileCancel)
    ];
    string haiku404 =
        """
        > Llama lost its way,
        > Plumbob flickers, page not found—
        > Mods wait patiently.
        """;
}
