using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhasmaBuster.Pages;

namespace PhasmaBuster.Data.Common;

public enum EvidenceType
{
    [Display(Description=nameof(PhasmaBusterTranslation.STANDART))]
    Standard = 0,
    [Display(Description = nameof(PhasmaBusterTranslation.TELLS))]
    Tells = 1,
    [Display(Description = nameof(PhasmaBusterTranslation.BEHAVIOUR))]
    Behaviours = 2,
    [Display(Description = nameof(PhasmaBusterTranslation.ABILITIES))]
    Abilities = 3,
    [Display(Description = nameof(PhasmaBusterTranslation.HUNT_SANITY))]
    Hunt = 4,
    [Display(Description = nameof(PhasmaBusterTranslation.SPEED))]
    Speed = 5,
    [Display(Description = nameof(PhasmaBusterTranslation.BLINK))]
    Blink = 6
}