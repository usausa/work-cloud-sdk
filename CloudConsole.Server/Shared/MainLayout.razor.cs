namespace CloudConsole.Server.Shared;

public sealed partial class MainLayout : IMenuSectionCallback
{
    private ErrorBoundary? errorBoundary;

    private RenderFragment? menu;

    private bool drawerOpen = true;

    [Inject]
    public IDialogService DialogService { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    protected override void OnParametersSet()
    {
        errorBoundary?.Recover();
    }

    public void SetMenu(RenderFragment? value)
    {
        menu = value;
        StateHasChanged();
    }

    private void DrawerToggle()
    {
        drawerOpen = !drawerOpen;
    }
}
