using JewelleryStore.Common;
using System.IO;

namespace JewelleryStore.Data
{
    public class DataSource
    {
        public static string CredentialData
        {
            get
            {
                return File.ReadAllText($"{ DirectoryPath.AssemblyDirectory}\\Repository\\CustomerCredentials.json");
            }
        }
    }
}
