using System;
using System.IO;

namespace PersonalDomain.Infrastructure.FileWriter
{
    public static class FileWriter
    {
        public static void WriteFile(String path, String content, Boolean isReadOnly)
        {
            if (IsFilePathReadOnly(path))
                File.SetAttributes(path, FileAttributes.Normal);

            File.WriteAllText(path, content);
            File.SetAttributes(path, isReadOnly ? FileAttributes.ReadOnly : FileAttributes.Normal);
        }

        public static Boolean IsFilePathReadOnly(String path)
        {
            if (!File.Exists(path))
                return false;

            var fileAttributes = File.GetAttributes(path);
            return fileAttributes.HasFlag(FileAttributes.ReadOnly);
        }
    }
}
