using PhasmaBuster.Data.Common;
using PhasmaBuster.Data.Evidences;

namespace PhasmaBuster.Data;

public class Ghost
{
    public string? Name { get; set; }
    public string? IconName { get; set; }
    public HashSet<StandardEvidence> RequiredStandardEvidences { get; set; } = new();
    public Dictionary<EvidenceType, List<BaseEvidence>> Evidences = new();
    public SpeedEvidence? SpeedEvidence { get; set; }
    public SanityEvidence? SanityEvidence { get; set; }

    public bool HasEvidence(BaseEvidence evidence)
    {
        if (!Evidences.TryGetValue(evidence.Category, out var ev))
            return false;
        var result = ev.Any(x => x.Name == evidence.Name);
        return result;
    }

    public bool IsStandardEvidenceRequired(StandardEvidence evidence)
    {
        return RequiredStandardEvidences.Contains(evidence);
    }
}