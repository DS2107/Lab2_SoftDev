using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V.Tests.Classes_1_.DataAccessObjects
{
    class MockFileService : IFileService
    {
        public int count_tmpFiles { get; set; }

        public int MergeTemporaryFiles(string dir)
        {
           

                count_tmpFiles++;
            
            return 0;
        }
    }
}
