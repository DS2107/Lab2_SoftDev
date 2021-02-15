/*
2
Написать тесты и собственную заглушку для решения задачи, в соответствии с
вариантом. Внедрение зависимости произвести в сеттере. Протестировать как
состояние (написать стаб), так и поведение (написать мок).
 
1-3
В Production Code написать класс Signal со свойством double[] Samples и методом
FullRectify(), который вызывает метод SortAndFilter() класса ArrayProcessor (см. задание
3-3 из л/р №1) и записывает результат в массив Samples. Также метод записывает
сумму, разность и среднее арифметическое в три строки в файл results.log. Если такой
файл уже существует, то создать файл results(1).log; если файл results(1).log существует, то
создать results(2).log и т.д. Самостоятельно продумать структуру теста и реализовать его.
 
 */


using Lab2_Stru_IVT_7_V.Tests.Classes_2_.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stru_IVT_7_V.Tests.Classes_2_
{
    public class Signal : ISignal
    {
       public double[] Samples { get; set; }


        public Signal(IArrayProcessor arrayProcessor, double[] array)
        {
            SetSamples(arrayProcessor, array);
        }

        public void SetSamples(IArrayProcessor arrayProcessor, double[] array)
        {
            Samples = arrayProcessor.SortAndFilter(array);
        }
        public void FullRectify()
        {
            double sum = CalculateSum();
            double diff = CalculateDiff();
            double average = CalculateAverage(sum);
            WriteToFile(sum, diff, average);
        }
        public void WriteToFile(double sum, double diff, double average)
        {
            for (int i = 0; i < Samples.Length; i++)
            {
                if (!File.Exists("results(" + i + ").txt"))
                {
                    using (StreamWriter sw = new StreamWriter("results(" + i + ").txt", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(sum);
                        sw.WriteLine(diff);
                        sw.WriteLine(average);
                    }
                    break;
                }
            }
        }

        public double CalculateSum()
        {
            double sum = 0;

            for (int i = 0; i < Samples.Length; i++)
            {
                sum += Samples[i];
            }

            return sum;
        }

        public double CalculateDiff()
        {
            double diff = Samples[0];

            for (int i = 1; i < Samples.Length; i++)
            {
                diff -= Samples[i];
            }

            return diff;
        }

        public double CalculateAverage(double sum)
        {
            double average = sum / Samples.Length;

            return Math.Round(average, 2);
        }

    }
}
