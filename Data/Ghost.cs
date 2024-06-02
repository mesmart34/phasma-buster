using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data;

public class Ghost
{
    public string? Name { get; set; }
    public string? IconName { get; set; }
    public HashSet<Evidence> RequiredStandardEvidences { get; set; } = new();
    public Dictionary<EvidenceType, List<Evidence>> Evidences = new();
    public List<decimal> SpeedValues { get; set; } = new();
    public List<decimal> SanityValues { get; set; } = new();

    public bool HasEvidence(Evidence evidence)
    {
        if (!Evidences.TryGetValue(evidence.Category, out var ev))
            return false;
        var result = ev.Any(x => x.Name == evidence.Name);
        return result;
    }

    public bool IsStandardEvidenceRequired(Evidence evidence)
    {
        return RequiredStandardEvidences.Contains(evidence);
    }
}