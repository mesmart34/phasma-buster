using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public class SanityEvidence : BaseEvidence
{
    public decimal Value { get; set; }

    public SanityEvidence()
    {
        Category = EvidenceType.Hunt;
    }
}