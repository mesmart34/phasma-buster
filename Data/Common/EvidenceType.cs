using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhasmaBuster.Data.Common;

public enum EvidenceType
{
    [Display(Description = "Стандарт")]
    Standart = 0,
    [Display(Description = "Особенности")]
    Tells = 1,
    [Display(Description = "Поведение")]
    Behaviours = 2,
    [Display(Description = "Способности")]
    Abilities = 3,
    [Display(Description = "Охота и рассудок")]
    Hunt = 4,
    [Display(Description = "Скорость")]
    Speed = 5
}