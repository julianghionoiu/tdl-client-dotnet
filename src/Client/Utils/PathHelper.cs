using System.IO;

namespace TDL.Client.Utils
{
    public static class PathHelper
    {
        private const string SolutionFileName = "tdl.sln";

        public static string RepositoryPath { get; }

        static PathHelper()
        {
            var exeDirectoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            RepositoryPath = GetRepositoryPath(exeDirectoryPath) ?? exeDirectoryPath;
        }

        private static string GetRepositoryPath(string path)
        {
            var currentDirectory = new DirectoryInfo(path);
            do
            {
                if (File.Exists(Path.Combine(currentDirectory.FullName, SolutionFileName)))
                {
                    return currentDirectory.FullName;
                }

                currentDirectory = currentDirectory.Parent;
            }
            while (currentDirectory != null);

            return null;
        }
    }
}
