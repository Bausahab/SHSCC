using System.IO;
using System.Threading.Tasks;

namespace SHSCC
{
    public static class SHSCCTextDataOperationTasks
    {
        public static string OperationDate { get; private set; }
        public static Task<bool> DataExist()
        {
            return Task.FromResult(Directory.Exists(Properties.Settings.Default.DefaultDir));
        }

    }
}
