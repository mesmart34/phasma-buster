using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public class BehaviourEvidence : BaseEvidence
{
    public BehaviourEvidence()
    {
        Category = EvidenceType.Behaviours;
    }
}