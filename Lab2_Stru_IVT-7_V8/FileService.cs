using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V8
{
    public class FileService
    {
        public static void Main(string[] args)
        {
            FileService file = new FileService();
            _ = file.MergeTemporaryFiles("s");
        }
        public int MergeTemporaryFiles(string dir)
        {
            dir = "tmpFile";
            if (CheckPath(dir))
            {
                var LisFilesTmp = Directory.GetFiles(dir, "*.tmp").ToList();
                string backupString = "";
                int count_tmpFiles = 0;
                foreach (var file in LisFilesTmp)
                {
                    backupString = backupString + " " + Path.GetFileName(file);
                    File.Delete(file);
                    count_tmpFiles++;
                }
                File.WriteAllText("backupFile/backup.tmp", backupString);

                return count_tmpFiles;
            }
            else
            {
                throw new DirectoryNotFoundException("Не существующий каталог");
            }
        } // MergeTemporaryFiles

        private bool CheckPath(string dir)
        {
            if (Directory.Exists(dir))
                return true;
            else
                return false;
        }
    }
}
