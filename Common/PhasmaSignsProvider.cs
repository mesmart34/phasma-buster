using PhasmaBuster.Data;

namespace PhasmaBuster.Common;

public delegate void PhasmaSignsChangeHandler(Model message);

public class PhasmaSignsProvider
{
    public event PhasmaSignsChangeHandler? PhasmaSignChanged;

    public async Task OnPhasmaSignChange(Model model)
    {
        await Task.Yield();
        
        _ = Task.Run(() => PhasmaSignChanged?.Invoke(model));
    }
}