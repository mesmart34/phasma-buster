using System.ComponentModel.DataAnnotations;
using System.Drawing;
using PhasmaBuster.Data.Common;
using PhasmaBuster.Pages;

namespace PhasmaBuster.Data.Evidences;

public class StandardEvidence : BaseEvidence
{
    public string? IconName { get; set; }
    public int Sequence { get; set; }
    public Color Color { get; set; }

    public StandardEvidence()
    {
        Category = EvidenceType.Standart;
    }
}