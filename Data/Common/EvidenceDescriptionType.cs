using System.ComponentModel;

namespace PhasmaBuster.Data.Common;

public enum EvidenceDescriptionType
{
    None = 0,
    [Description("Видео")]
    Video = 1,
    [Description("Аудио")]
    Audio = 2,
    [Description("Картинка")]
    Picture = 3
}