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

    [Inject] 
    public TooltipService TooltipService { get; set; } = null!;
    
    [Inject]
    public IJSRuntime Js { get; set; } = null!;
    
    [Inject] 
    private IStringLocalizer<PhasmaBusterTranslation> Localization { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
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
}
