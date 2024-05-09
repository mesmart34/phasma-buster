using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public class TellsEvidence : BaseEvidence
{
    public TellsEvidence()
    {
        Category = EvidenceType.Tells;
    }
}