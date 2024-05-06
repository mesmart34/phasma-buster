using System.Drawing;

namespace PhasmaBuster.Data.Evidences;

public class StandartEvidence : BaseEvidence
{
    public string? IconName { get; set; }
    public bool Required { get; set; }
    public int Sequence { get; set; }
    public Color Color { get; set; }
}