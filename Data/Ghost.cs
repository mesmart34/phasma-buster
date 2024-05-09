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
        return Evidences[evidence.Category].Contains(evidence);
    }

    public bool IsStandardEvidenceRequired(StandardEvidence evidence)
    {
        return RequiredStandardEvidences.Contains(evidence);
    }
}