using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public class SpeedEvidence : BaseEvidence
{
    public List<SpeedEvidenceValue> Values { get; set; } = new();

    public SpeedEvidence()
    {
        Category = EvidenceType.Speed;
    }
}