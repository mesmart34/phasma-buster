using System.ComponentModel.DataAnnotations;

namespace PhasmaBuster.Data.Common;

public static class EnumExtension
{
    public static string GetCaption(this Enum value)
    {
        var type = value.GetType();

        var name = Enum.GetName(type, value);
        if (name == null)
        {
            return value.ToString();
        }

        var field = type.GetField(name);
        if (field == null)
        {
            return value.ToString();
        }

        if (Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attr)
        {
            return attr?.Description ?? value.ToString();
        }

        return value.ToString();
    }
}