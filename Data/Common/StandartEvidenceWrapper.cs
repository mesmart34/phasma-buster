using PhasmaBuster.Data.Evidences;

namespace PhasmaBuster.Data.Common;

public class StandartEvidenceWrapper
{
    public StandardEvidence StandardEvidence { get; set; }
    public bool IsRequired { get; set; }

    public StandartEvidenceWrapper(StandardEvidence standardEvidence, bool isRequired = false)
    {
        StandardEvidence = standardEvidence;
        IsRequired = isRequired;
    }
}