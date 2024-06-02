using System.Drawing;
using PhasmaBuster.Data.Common;

namespace PhasmaBuster.Data;

public class Evidence
{
    public string? Name { get; set; }
    public string? IconName { get; set; }
    public Color? Color { get; set; }
    public EvidenceDescription? Description { get; set; }
    public EvidenceType Category { get; set; }
}