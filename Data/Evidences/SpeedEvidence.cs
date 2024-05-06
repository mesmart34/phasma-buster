using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public class SpeedEvidence : HiddenEvidence
{
    public List<SpeedEvidenceValue> Values { get; set; } = new();
}