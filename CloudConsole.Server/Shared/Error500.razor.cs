namespace CloudConsole.Server.Shared;

public sealed partial class Error500 : ComponentBase
{
    [Parameter]
    public Exception? Exception { get; set; }

    [Parameter]
    public EventCallback RecoverRequest { get; set; }
}
