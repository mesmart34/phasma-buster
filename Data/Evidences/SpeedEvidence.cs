using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public class SpeedEvidence : MultiValueEvidence
{
    public SpeedEvidence()
    {
        Category = EvidenceType.Speed;
    }
}