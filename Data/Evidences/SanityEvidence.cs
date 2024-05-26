using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public class SanityEvidence : MultiValueEvidence
{
    public SanityEvidence()
    {
        Category = EvidenceType.Hunt;
    }
}