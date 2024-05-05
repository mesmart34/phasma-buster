using PhasmaBuster.Common.Contracts;

namespace PhasmaBuster.Common;

public class HiddenEvidence : IEvidence
{
    public string? Name { get; set; } = "Unknown";
    public bool Mark { get; set; }
    public string Description { get; set; } = "Unknown";
}