using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using PhasmaBuster.Common;
using PhasmaBuster.Data;
using PhasmaBuster.Data.Common;
using Radzen;

namespace PhasmaBuster.Pages;

public partial class Home
{
    private Model _model = new();
    private Ghost? _currentGhost;
    private string _sidePanelStyle = string.Empty;
    private bool _isRightSideBarOpen = false;

    [Inject] 
    private NavigationManager NavigationManager { get; set; } = null!;
    
    [Inject]
    private PhasmaSignsProvider PhasmaSignsProvider { get; set; } = null!;

    [Inject] 
    public TooltipService TooltipService { get; set; } = null!;
    
    [Inject]
    public IJSRuntime Js { get; set; } = null!;
    
    [Inject] 
    private IStringLocalizer<PhasmaBusterTranslation> Localization { get; set; } = null!;
    

    protected override async Task OnInitializedAsync()
    {
        PhasmaSignsProvider.PhasmaSignChanged += OnPhasmaSignChanged;
        await base.OnInitializedAsync();
    }

    private void OnPhasmaSignChanged(Model model)
    {
        _model = model;
        StateHasChanged();
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
        
        return visible;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await Js.InvokeVoidAsync("setButtonsLikeWindows");

        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task CloseNav()
    {
        if (_isRightSideBarOpen)
        {
            await Js.InvokeVoidAsync("closeNav");
        }

        _isRightSideBarOpen = false;
    }
    
    private async Task OpenNav()
    {
        if (!_isRightSideBarOpen)
        {
            await Js.InvokeVoidAsync("openNav");
        }

        _isRightSideBarOpen = true;
    }
}
