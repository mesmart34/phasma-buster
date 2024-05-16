using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data.Evidences;

public abstract class BaseEvidence
{
    public string Name { get; set; } = "Unknown";
    public EvidenceDescription? Description { get; set; }
    public EvidenceType Category { get; set; }
}