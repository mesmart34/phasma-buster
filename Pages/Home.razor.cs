using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using PhasmaBuster.Data;

namespace PhasmaBuster.Pages;

public partial class Home
{
    private readonly Model _model = new();
    private static readonly CultureInfo[] CultureInfos = {
        new("ru-RU"),
        new("en-US"),
    };
    private readonly Dictionary<string, string> _cultureDict =
        new()
        {
            { "en-US", "English" },
            { "ru-RU", "Русский" }
        };
    private CultureInfo _culture = CultureInfos[1];
    
    [Inject] 
    private IStringLocalizer<PhasmaBusterTranslation> Localization { get; set; } = null!;

    [Inject] 
    private IJSRuntime Js { get; set; } = null!;

    [Inject] 
    private NavigationManager NavigationManager { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        var a = Localization["EMF5"];
        await LoadCulture();
        
        await base.OnInitializedAsync();
    }

    private async Task LoadCulture()
    {
        var result = await Js.InvokeAsync<string>("blazorCulture.get");
        _culture = CultureInfos.FirstOrDefault(x => x.Name == result) ?? CultureInfos[0];
    }
    
    private async Task ChangeCulture(CultureInfo cultureInfo)
    {
        await Js.InvokeVoidAsync("blazorCulture.set", cultureInfo.Name);
        NavigationManager.NavigateTo(NavigationManager.Uri, forceLoad: true);
    }
}
