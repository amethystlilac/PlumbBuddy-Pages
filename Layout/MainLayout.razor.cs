namespace PlumbBuddyPages.Layout;

partial class MainLayout
{
    static MudTheme CreatePlumbBuddyFactoryTheme() =>
        new()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#00a2ffff",
                Tertiary = "#74c044ff",
                Warning = "#d98806ff"
            },
            PaletteDark = new PaletteDark()
            {
                Primary = "#00a2ffff",
                Tertiary = "#74c044ff",
                Warning = "#d98806ff"
            }
        };

    bool isDarkMode;
    bool isDrawerOpen;

    MudTheme Theme => 
        CreatePlumbBuddyFactoryTheme();

    void HandleMainMenuOnClick() =>
        isDrawerOpen = !isDrawerOpen;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        SetPreferredColorScheme(await JSRuntime.InvokeAsync<string>("getPreferredColorScheme"));
        await JSRuntime.InvokeVoidAsync("subscribeToPreferredColorSchemeChanges", DotNetObjectReference.Create(this));

        var lastInitialized = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "lastInitialized");
        await JSRuntime.InvokeVoidAsync("localStorage.setItem", "lastInitialized", DateTimeOffset.Now.ToString());
        if (string.IsNullOrWhiteSpace(lastInitialized))
            Snackbar.Add("We use cookies to improve your experience. By using this site you consent to these cookies.", Severity.Info, config =>
            {
                config.Icon = MaterialDesignIcons.Normal.Cookie;
                config.RequireInteraction = true;
            });
    }

    void SetPreferredColorScheme(string colorScheme) =>
        isDarkMode = colorScheme == "dark";

    [JSInvokable]
    public void UpdatePreferredColorScheme(string colorScheme)
    {
        SetPreferredColorScheme(colorScheme);
        StateHasChanged();
    }
}
