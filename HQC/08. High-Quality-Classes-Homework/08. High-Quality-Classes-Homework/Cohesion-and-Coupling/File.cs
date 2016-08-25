namespace CohesionAndCoupling
{
    using System;

    public class File
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = LastDotIndexFinder(fileName);
            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = LastDotIndexFinder(fileName);
            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }

        private static int LastDotIndexFinder(string path)
        {
            int indexOfLastDot = path.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException();
            }

            return indexOfLastDot;
        }
    }
}