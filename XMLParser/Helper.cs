using System;
using System.IO;
using System.Reflection;

namespace XMLParser
{
    public static class Helper
    {
        internal static DirectoryInfo GetExecutingAssemblyPath()
        {
            return new DirectoryInfo(
                Path.GetDirectoryName(
                    Uri.UnescapeDataString(
                        new UriBuilder(Assembly.GetExecutingAssembly().Location).Path)));
        }
    }
}
