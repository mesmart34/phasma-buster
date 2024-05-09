using System.Drawing;
using PhasmaBuster.Data.Common;
using PhasmaBuster.Data.Evidences;
using PhasmaBuster.Pages;

namespace PhasmaBuster.Data;

public class Model
{
    public readonly Dictionary<BaseEvidence, EvidenceState> FilterEvidences = new();

    public readonly List<BaseEvidence> Evidences;
    public readonly List<Ghost> Ghosts;

    #region StandartEvidence

    private static readonly StandardEvidence Emf5 = new StandardEvidence()
    {
        Name = PhasmaBusterTranslation.EMF5,
        Sequence = 0,
        Category = EvidenceType.Standart,
        Color = Color.Red,
        IconName = "radar"
    };

    private static readonly StandardEvidence Ultraviolet = new()
    {
        Name = PhasmaBusterTranslation.ULTRAVIOLET,
        Sequence = 1,
        Category = EvidenceType.Standart,
        Color = Color.Khaki,
        IconName = "fingerprint"
    };

    private static readonly StandardEvidence SpiritBox = new()
    {
        Name = PhasmaBusterTranslation.SPIRIT_BOX,
        Sequence = 2,
        Category = EvidenceType.Standart,
        Color = Color.Orange,
        IconName = "radio"
    };

    private static readonly StandardEvidence Writing = new()
    {
        Name = PhasmaBusterTranslation.WRITING,
        Sequence = 3,
        Category = EvidenceType.Standart,
        Color = Color.RoyalBlue,
        IconName = "note_alt"
    };

    private static readonly StandardEvidence Freezing = new()
    {
        Name = PhasmaBusterTranslation.FREEZING,
        Sequence = 4,
        Category = EvidenceType.Standart,
        Color = Color.SkyBlue,
        IconName = "ac_unit"
    };

    private static readonly StandardEvidence Dots = new()
    {
        Name = PhasmaBusterTranslation.DOTS,
        Sequence = 5,
        Category = EvidenceType.Standart,
        Color = Color.Green,
        IconName = "blur_on"
    };
    
    private static readonly StandardEvidence GhostOrbs = new()
    {
        Name = PhasmaBusterTranslation.GHOST_ORBS,
        Sequence = 6,
        Category = EvidenceType.Standart,
        Color = Color.Khaki,
        IconName = "auto_awesome"
    };

    #endregion

    #region TellsEvidence

    private static readonly TellsEvidence BansheeScream = new ()
    {
        Name = PhasmaBusterTranslation.PARABOLIC_MIC_SCREAM,
        Category = EvidenceType.Tells,
        Description = new EvidenceDescription()
        {
            Text = PhasmaBusterTranslation.PARABOLIC_MIC_SCREAM_DSCR,
            FilePath = "banchee_scream.mp3",
            EvidenceDescriptionType = EvidenceDescriptionType.Audio
        }
    };
    
    private static readonly TellsEvidence SaltFootprint = new ()
    {
        Name = PhasmaBusterTranslation.SALT_FOOTPRINTS,
        Category = EvidenceType.Tells,
        Description = new EvidenceDescription()
        {
            Text = PhasmaBusterTranslation.SALT_FOOTPRINTS_DSCR
        }
    };

    #endregion

    #region Ghosts

    private static readonly Ghost Banshee = new()
    {
        Name = PhasmaBusterTranslation.BANSHEE,
        RequiredStandardEvidences = new (),
        Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
        {
            {
                EvidenceType.Standart, 
                new ()
                {
                    Ultraviolet,
                    GhostOrbs,
                    Dots
                }
            },
            {
                EvidenceType.Tells, 
                new ()
                {
                    BansheeScream
                }
            }
        },
        SanityEvidence = new SanityEvidence()
        {
            Value = 50.0m
        },
        SpeedEvidence = new ()
        {
            Name = "Скорость",
            Values = new List<SpeedEvidenceValue>()
            {
                new()
                {
                    Sequence = 0,
                    Value = 1.7m
                }
            },
            Description = new EvidenceDescription()
            {
                EvidenceDescriptionType = EvidenceDescriptionType.Audio,
                FilePath = "1.7_steps.mp3"
            }
        }
    };
    
    private static readonly Ghost Wraith = new()
    {
        Name = PhasmaBusterTranslation.WRAITH,
        Evidences = new Dictionary<EvidenceType, List<BaseEvidence>>()
        {
            {
                EvidenceType.Standart, 
                new ()
                {
                    Emf5,
                    SpiritBox,
                    Dots
                }
            },
            {
                EvidenceType.Tells, 
                new ()
                {
                    SaltFootprint
                }
            }
        },
        SanityEvidence = new SanityEvidence()
        {
            Value = 50.0m
        },
        SpeedEvidence = new ()
        {
            Name = "Скорость",
            Values = new List<SpeedEvidenceValue>()
            {
                new()
                {
                    Sequence = 0,
                    Value = 1.7m
                }
            },
            Description = new EvidenceDescription()
            {
                EvidenceDescriptionType = EvidenceDescriptionType.Audio,
                FilePath = "1.7_steps.mp3"
            }
        }
    };

    #endregion
    
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
            Writing,
            
            BansheeScream,
            SaltFootprint
        };

        Ghosts = new()
        {
            Banshee,
            Wraith
        };

        foreach (var baseEvidence in Evidences)
        {
            FilterEvidences.Add(baseEvidence, EvidenceState.Idle);
        }
    }

}