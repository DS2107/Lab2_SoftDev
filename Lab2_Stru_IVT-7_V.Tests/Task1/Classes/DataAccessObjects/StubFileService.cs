using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V.Tests.Classes_1_.DataAccessObjects
{
    class StubFileService : IFileService
    {
        public int MergeTemporaryFiles(string dir)
        {          
           
                List<string> list = new List<string>();
                list.Add("file1.tmp");
                list.Add("file2.tmp");
                list.Add("file3.tmp");
                list.Add("main.tmp");
                string backupString = "";
                int count_tmpFiles = 0;
                foreach (var item in list)
                {
                    backupString = backupString + " " + item;
                   
                    count_tmpFiles++;
                }
               // File.WriteAllText("backupFile/backup.tmp", backupString);

                return count_tmpFiles;
           
        } // MergeTemporaryFiles

   
    }
}
