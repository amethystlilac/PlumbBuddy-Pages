namespace PlumbBuddyPages.Layout;

partial class MainLayout
{
    static MudTheme CreatePlumbBuddyFactoryTheme() =>
        new()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#00cfefff",
                Tertiary = "#74c044ff"
            },
            PaletteDark = new PaletteDark()
            {
                Primary = "#00cfefff",
                Tertiary = "#74c044ff"
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
            Snackbar.Add("We use cookies to improve your experience. If you don't consent, we'll kindly direct you to the EU's website to file your complaint. 🍪", Severity.Info, config =>
            {
                config.Action = "Complain";
                config.Onclick = snackbar =>
                {
                    NavigationManager.NavigateTo("https://www.edpb.europa.eu/about-edpb/about-edpb/members_en");
                    return Task.CompletedTask;
                };
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
