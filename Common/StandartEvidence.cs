using PhasmaBuster.Common.Contracts;

namespace PhasmaBuster.Common;

public class StandartEvidence : IEvidence
{
    public string? Name { get; set; }
    public bool Mark { get; set; }
    public string? IconName { get; set; }
    public int Sequence { get; set; }
}