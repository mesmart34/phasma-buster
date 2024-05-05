using PhasmaBuster.Common.Contracts;

namespace PhasmaBuster.Common;

public class Ghost
{
    public string Name { get; set; } = null!;
    public string? IconName { get; set; }
    public decimal Speed { get; set; }
    public decimal? MaxSpeed { get; set; }
    public decimal SanityLevelToStartHunt { get; set; }
    
    public List<IEvidence> Evidences { get; set; } = new();

    public bool HasEvidence(IEvidence evidence)
    {
        return Evidences.Any(x => x == evidence);
    }
}