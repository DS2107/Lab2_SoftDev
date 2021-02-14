using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V8
{
    class ReportViewer
    {
        // свойство которому предается значение - кол-ва файлов .tmp
        private int BlockCount{get;set;}
        public void PrepareData()
        {
            FileService file = new FileService();
            BlockCount =  file.MergeTemporaryFiles("tmpFile");

        }
    }
}
