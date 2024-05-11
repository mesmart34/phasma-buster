using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using PhasmaBuster.Data;
using PhasmaBuster.Data.Common;
using PhasmaBuster.Data.Evidences;
using Radzen;

namespace PhasmaBuster.Pages;

public partial class Home
{
    private readonly Model _model = new();
    private bool _sidebar1Expanded = true;
    
    [Inject] 
    private NavigationManager NavigationManager { get; set; } = null!;
    
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
    public TooltipService TooltipService { get; set; } = null!;
    
    [Inject]
    public IJSRuntime Js { get; set; } = null!;
    
    [Inject] 
    private IStringLocalizer<PhasmaBusterTranslation> Localization { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        await LoadCulture();
        await base.OnInitializedAsync();
    }

    private void SelectEvidence(BaseEvidence evidence)
    {
        _model.FilterEvidences[evidence] =
            (EvidenceState)((int)(_model.FilterEvidences[evidence] + 1) % Enum.GetValues<EvidenceState>().Length);
    }

    private bool IsVisible(Ghost ghost)
    {
        var visible = true;

        foreach (var evidence in _model.FilterEvidences.Where(x => x.Value == EvidenceState.Selected)
                     .Select(x => x.Key))
        {
            visible &= ghost.HasEvidence(evidence);
        }

        foreach (var evidence in _model.FilterEvidences.Where(x => x.Value == EvidenceState.Forbidden)
                     .Select(x => x.Key))
        {
            visible &= !ghost.HasEvidence(evidence);
        }

        ;
        return visible;
    }

    private string GetEvidenceCssClass(BaseEvidence evidence)
    {
        switch (_model.FilterEvidences[evidence])
        {
            case EvidenceState.Selected:
                return "text-decoration-underline";
            case EvidenceState.Forbidden:
                return "text-decoration-line-through";
            default:
                return string.Empty;
        }
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
