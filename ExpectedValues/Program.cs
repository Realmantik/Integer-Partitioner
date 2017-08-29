using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ExpectedValues
{
    //http://oeis.org/A000041
    class Program
    {
        static List<double> values = new List<double>();
        static List<double> diff = new List<double>();
        static List<double> val1 = new List<double>() { 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 56, 77, 101, 135, 176, 231, 297, 385, 490, 627, 792, 1002,
            1255, 1575, 1958, 2436, 3010, 3718, 4565, 5604, 6842, 8349, 10143, 12310, 14883, 17977, 21637, 26015, 31185, 37338, 44583, 53174, 63261,
            75175, 89134, 105558, 124754, 147273, 173525, 204226, 239943, 281589, 329931, 386155, 451276, 526823, 614154, 715220, 831820, 966467,
            1121505, 1300156, 1505499, 1741630, 2012558, 2323520, 2679689, 3087735, 3554345, 4087968, 4697205, 5392783, 6185689, 7089500, 8118264,
            9289091, 10619863, 12132164, 13848650, 15796476, 18004327, 20506255, 23338469, 26543660, 30167357, 34262962, 38887673, 44108109, 49995925,
            56634173, 64112359, 72533807, 82010177, 92669720, 104651419, 118114304, 133230930, 150198136, 169229875, 190569292 };
        static void Main(string[] args)
        {
            func1();
            /*
            func2();
            func3();
            func4();
            func5();
            func6();
            */
            Console.ReadLine();
        }

        private static void func1()
        {
            for (int i = 27; i < 50; i++)
            {
                var t = 309042.3 * Math.Exp(-(i + 1 - 71.53907) * (i - 71.53907) / (2 * 14.63014 * 14.63014));//аппроксимированная функция по значениям, уже вычисленным
                //values.Add(t);
                Console.WriteLine(t+"\t"+i);
            }
            File.WriteAllText("Expected values.json", JsonConvert.SerializeObject(values));
        }
        private static void func2()
        {
            diff.Clear();
            double diff_percent_sum=0.0;
            double percent;
            values.Clear();
            for (int i = 0; i < 26; i++)
            {
                var t = 309042.3 * Math.Exp(-(i+1 - 71.53907)*(i - 71.53907) / (2 * 14.63014 * 14.63014));
                values.Add(t);
                diff.Add(Math.Abs(t - val1[i]));
                percent= diff[i]/(val1[i]  / 100.0) ;
                diff_percent_sum += percent;
                Console.WriteLine("{0:f8}"+"\t"+"{2:f8}"+"\t"+ "{1}"+"\t"+"{3}"+"%", diff[i],val1[i],t,percent);
            }
            Console.WriteLine("Средний процент отклонения от точных значений: "+diff_percent_sum/26.0);
            

        }
        private static void func3()
        {
            diff.Clear();
            double diff_percent_sum = 0.0;
            double percent;
            values.Clear();
            for (int i = 0; i < 26; i++)
            {
                //y = 712931*e^(-(x - 78.79072)^2/(2*15.66472^2))
                var t = 712931 * Math.Exp(-(i+1 - 78.79072)*(i+1 - 78.79072) / (2 * 15.66472 * 15.66472));
                values.Add(t);
                diff.Add(Math.Abs(t - val1[i]));
                percent = diff[i] / (val1[i] / 100.0);
                diff_percent_sum += percent;
                Console.WriteLine("{0:f8}" + "\t" + "{2:f8}" + "\t" + "{1}" + "\t" + "{3}" + "%", diff[i], val1[i], t, percent);
            }
            Console.WriteLine("Средний процент отклонения от точных значений: " + diff_percent_sum / 26.0);
        }
        private static void func4()
        {
            diff.Clear();
            double diff_percent_sum = 0.0;
            double percent;
            values.Clear();
            for (int i = 0; i < 26; i++)
            {
                var t = -36.58108 + 7.881128 * Math.Exp(+0.2215343 * (i + 1));
                values.Add(t);
                diff.Add(Math.Abs(t - val1[i]));
                percent = diff[i] / (val1[i] / 100.0);
                diff_percent_sum += percent;
                Console.WriteLine("{0:f8}" + "\t" + "{2:f8}" + "\t" + "{1}" + "\t" + "{3}" + "%", diff[i], val1[i], t, percent);
            }
            Console.WriteLine("Средний процент отклонения от точных значений: " + diff_percent_sum / 26.0);
        }
        private static void func5()
        {
            diff.Clear();
            double diff_percent_sum = 0.0;
            double percent;
            values.Clear();
            for (int i = 0; i < 26; i++)
            {
                var t = -31.33537 + 7.245483 * Math.Exp(+0.2251762 * (i + 1));
                values.Add(t);
                diff.Add(Math.Abs(t - val1[i]));
                percent = diff[i] / (val1[i] / 100.0);
                diff_percent_sum += percent;
                Console.WriteLine("{0:f8}" + "\t" + "{2:f8}" + "\t" + "{1}" + "\t" + "{3}" + "%", diff[i], val1[i], t, percent);
            }
            Console.WriteLine("Средний процент отклонения от точных значений: " + diff_percent_sum / 26.0);
        }
        private static void func6()
        {
            diff.Clear();
            double diff_percent_sum = 0.0;
            double percent;
            values.Clear();
            for (int i = 0; i < 26; i++)
            {
                var t = -25.64414 + 6.65938 * Math.Exp(+0.2288598 * (i + 1));
                values.Add(t);
                diff.Add(Math.Abs(t - val1[i]));
                percent = diff[i] / (val1[i] / 100.0);
                diff_percent_sum += percent;
                Console.WriteLine("{0:f8}" + "\t" + "{2:f8}" + "\t" + "{1}" + "\t" + "{3}" + "%", diff[i], val1[i], t, percent);
            }
            Console.WriteLine("Средний процент отклонения от точных значений: " + diff_percent_sum / 26.0);
        }
    }
}
