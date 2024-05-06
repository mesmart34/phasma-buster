using System.Drawing;
using PhasmaBuster.Data.Common;
using PhasmaBuster.Data.Evidences;

namespace PhasmaBuster.Data;

public class Model
{
    public Dictionary<BaseEvidence, EvidenceState> FilterEvidences = new();

    public List<BaseEvidence> Evidences;
    
    public static StandartEvidence Emf5 = new StandartEvidence()
    {
        Name = "EMF5",
        Sequence = 0,
        Category = EvidenceType.Standart,
        Color = Color.Red
    };
    
    public static StandartEvidence Ultraviolet = new StandartEvidence()
    {
        Name = "Ультрафиолет",
        Sequence = 1,
        Category = EvidenceType.Standart,
        Color = Color.Khaki
    };
    
    public static StandartEvidence SpiritBox = new StandartEvidence()
    {
        Name = "Радиоприёмник",
        Sequence = 2,
        Category = EvidenceType.Standart,
        Color = Color.Orange
    };
    
    public static StandartEvidence Writing = new StandartEvidence()
    {
        Name = "Записи в блокноте",
        Sequence = 3,
        Category = EvidenceType.Standart,
        Color = Color.RoyalBlue
    };
    
    public static StandartEvidence Freezing = new StandartEvidence()
    {
        Name = "Минусовая температура",
        Sequence = 4,
        Category = EvidenceType.Standart,
        Color = Color.SkyBlue
    };
    
    public static StandartEvidence Dots = new StandartEvidence()
    {
        Name = "Лазерная проекция",
        Sequence = 5,
        Category = EvidenceType.Standart,
        Color = Color.Green
    };
    
    public static StandartEvidence GhostOrbs = new StandartEvidence()
    {
        Name = "GHOST_ORBS",
        Sequence = 6,
        Category = EvidenceType.Standart,
        Color = Color.Khaki
    };
    
    public static TellsEvidence BansheeScream = new ()
    {
        Name = "Крик в микрофон",
        Category = EvidenceType.Tells,
        Description = new EvidenceDescription()
        {
            Text = "Уникальный крик в направленный микрофон"
        }
    };
    
    public Model()
    {
        Evidences = new()
        {
            Emf5,
            Ultraviolet,
            SpiritBox,
            Freezing,
            GhostOrbs,
            Dots,
            
            BansheeScream
        };
    }

}