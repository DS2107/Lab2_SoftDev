/*
1  Написать тесты и собственную заглушку для решения задачи, в соответствии с
вариантом (приложение А). Внедрение зависимости произвести в конструкторе.
Протестировать как состояние (написать стаб), так и поведение (написать мок).
 
 1-1   В Production Code написать класс FileService с методом int MergeTemporaryFiles(string
dir). В данном методе класс обращается к директории dir и компонует из всех файлов с
расширением .tmp в данной директории один файл backup.tmp (простой
конкатенацией), после чего удаляет все учтенные файлы. Метод возвращает количество
учтенных файлов; если передан путь несуществующего каталога, должно быть брошено
исключение. Данный метод должен вызываться, в свою очередь, из метода
PrepareData() класса ReportViewer. Этот метод должен сразу прекратить выполнение,
если количество учтенных файлов было равно нулю; иначе – присвоить свойству
BlockCount класса ReportViewer это количество. Протестировать все ситуации.

 
 */


using Lab2_Stru_IVT_7_V.Tests.Classes_1_.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V.Tests
{
    class ReportViewer
    {

        // свойство которому предается значение - кол-ва файлов .tmp
        public int BlockCount{get;set;}

        // Обращаемся к интерфейсу
        private IFileService service;

       // конструктор без параметров который вызывает метод с поддержкой файловой системы 
        public ReportViewer()
        {
            service = new FileService();
        }

        // Конструктор с параметрами, который вызывает stub - заглушку
        public ReportViewer(IFileService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Присваеваем значение 
        /// </summary>
        /// <returns></returns>
        public bool PrepareData()
        {
             if (service.MergeTemporaryFiles("tmpfile")!=0)
            {
                BlockCount = service.MergeTemporaryFiles("tmpFile");
                return true;
            }
            else
            {
                return false;
            }
                    
        }

       
    }
}
