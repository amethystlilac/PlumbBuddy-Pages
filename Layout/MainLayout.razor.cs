namespace PlumbBuddy_Pages.Layout;

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
