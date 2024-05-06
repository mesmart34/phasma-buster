using PhasmaBuster.Data.Evidences;

namespace PhasmaBuster.Data;

public class Ghost
{
    public string? Name { get; set; }
    public string? IconName { get; set; }
    public List<StandartEvidence> StandartEvidences { get; set; } = new();
    public List<TellsEvidence> TellsEvidences { get; set; } = new();
    public List<BehaviourEvidence> BehaviourEvidences { get; set; } = new();
    public SpeedEvidence? SpeedEvidence { get; set; }
    public SanityEvidence? SanityEvidence { get; set; }
}