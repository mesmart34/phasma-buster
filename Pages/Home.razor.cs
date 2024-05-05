using PhasmaBuster.Common;
using PhasmaBuster.Common.Contracts;
using Radzen;
namespace PhasmaBuster.Pages;

public partial class Home
{
    private Data _data = new();
    private HashSet<IEvidence> _evidencesMarked = new();

    protected override Task OnInitializedAsync()
    {
        var a = 5;
        return base.OnInitializedAsync();
    }

    private Task OnEvidenceMark(StandartEvidence evidence, bool value)
    {
        if (value)
        {
            _evidencesMarked.Add(evidence);
        }
        else
        {
            _evidencesMarked.Remove(evidence);
        }
        StateHasChanged();
        return Task.CompletedTask;
    }
}