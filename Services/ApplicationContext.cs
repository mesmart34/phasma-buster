using System.Reflection;
using PhasmaBuster.Contracts;

namespace PhasmaBuster.Services;

public class ApplicationContext : IApplicationContext
{
    public string GetVersion()
    {
        var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

        if (assemblyVersion == null)
        {
            return "0.0.0";
        }

        return $"{assemblyVersion.Major}.{assemblyVersion.Minor}.{assemblyVersion.Build}";
    }
}