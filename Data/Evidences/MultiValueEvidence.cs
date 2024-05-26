using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public class MultiValueEvidence : BaseEvidence
{
    public List<MultiValue> Values { get; set; } = new();

    public MultiValueEvidence()
    {
        Category = EvidenceType.Speed;
    }
}