using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace IntegerPartitioner
{
    public partial class Form1 : Form
    {
        int totalFractionsCounter;
        static List<String> fractions = new List<String>();
        static Dictionary<int, string> calcFractionsCount = new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GetFractions(int a, string s, int lastElement)
        {
            string tmp;
            int ai = a;
            for (int i = 1; i < a; i++)
            {
                if (lastElement >= ai - 1)
                {
                    tmp = s + "+" + (ai - 1).ToString();
                    if (ai > i)
                    {
                        fractions.Add(tmp + "+" + i.ToString());//условие, чтобы не было копий разложений
                        totalFractionsCounter++;
                    }
                    if (i > 1) GetFractions(i, tmp, ai - 1);
                }
                ai--;
            }
        }

        private void GetFractions(int a)
        {
            totalFractionsCounter++;
            if (a < 1) return;
            fractions.Add(a.ToString());
            int ai = a;

            for (int i = 1; i < a; i++)
            {
                if (ai > i)
                {
                    fractions.Add((ai - 1).ToString() + "+" + i.ToString());//условие, чтобы не было копий разложений
                    totalFractionsCounter++;
                }
                if (a >= ai - 1)
                {
                    if (ai - 1 >= i)
                    {
                        GetFractions(i, (ai - 1).ToString(), i);
                    }
                    else
                    {
                        GetFractions(i, (ai - 1).ToString(), ai - 1);
                    }
                }
                ai--;
            }
        }

        //Просто подсчитываем количество разбиений без составления списка таких разбиений
        private void GetFractionsCount(int a)
        {
            totalFractionsCounter++;
            if (a < 1) return;
            int ai = a;

            for (int i = 1; i < a; i++)
            {
                if (ai > i) totalFractionsCounter++;
                if (a >= ai - 1)
                {
                    if (ai - 1 >= i)
                    {
                        GetFractionsCount(i, i);
                    }
                    else
                    {
                        GetFractionsCount(i, ai - 1);
                    }
                }
                ai--;
            }
        }

        //Просто подсчитываем количество разбиений без составления списка таких разбиений
        private void GetFractionsCount(int a, int lastElement)
        {
            int ai = a;
            for (int i = 1; i < a; i++)
            {
                if (lastElement >= ai - 1)
                {
                    if (ai > i)
                    {
                        totalFractionsCounter++;
                    }
                    if (i > 1) GetFractionsCount(i, ai - 1);
                }
                ai--;
            }
        }

        private void Display(ref List<String> l)
        {
            int l_count = l.Count;
            for (int i = 0; i < l.Count-7; i+=8)
            {
                //outputBox.AppendText(Environment.NewLine);
                //outputBox.AppendText(l[i]);

                //bottle neck
                outputBox.AppendText(Environment.NewLine+l[i]
                                    +Environment.NewLine+l[i+1]
                                    +Environment.NewLine+l[i+2]
                                    +Environment.NewLine+l[i+3]
                                    +Environment.NewLine+l[i+4]
                                    +Environment.NewLine+l[i+5]
                                    +Environment.NewLine+l[i+6]
                                    +Environment.NewLine+l[i+7]);
                l_count-= 8;
                Application.DoEvents();   //Прокачка сообщений Windows, чтобы не было ошибок и не тормозил UI
            }

            if (l_count != 0)
            {
                for (int i = l.Count-l_count; i < l.Count; i++)
                {
                    outputBox.AppendText(Environment.NewLine);
                    outputBox.AppendText(l[i]);
                    Application.DoEvents();
                }
            }
        }

        private void getFractionsCountMenu_Click(object sender, EventArgs e)
        {
            var b=int.TryParse(inputBox.Text, out int n);
            if (!b)
            {
                MessageBox.Show("Введите число от 1 до 10000!");
                return;
            }
            menuCommands.Enabled = false;
            outputBox.Clear();
            //int n;

            bool contains = calcFractionsCount.ContainsKey(n);
            if (contains)
            {
                outputBox.AppendText("Число разложений для N=" + inputBox.Text + ": " + calcFractionsCount[n]);
                outputBox.AppendText(Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Введите число от 1 до 10000!");
            }
            menuCommands.Enabled = true;
        }

        private async void getFractionsMenu_Click(object sender, EventArgs e)
        {
            var b=int.TryParse(inputBox.Text, out int n);
            if (!b)
            {
                MessageBox.Show("Введите число от 1 до 10000!");
                return;
            }
            totalFractionsCounter = 0;
            menuCommands.Enabled = false;
            outputBox.Clear();
            //int n = int.Parse(inputBox.Text);
            Stopwatch sw = new Stopwatch();
            //Stopwatch sw2 = new Stopwatch();
            sw.Start();
            await Task.Run(() => GetFractions(n));
            TimeSpan ts = sw.Elapsed;
            //sw2.Start();
            Display(ref fractions);
            TimeSpan ts2 = sw.Elapsed;
            sw.Stop();
            outputBox.AppendText(Environment.NewLine);
            outputBox.AppendText("Количество вариантов: " + totalFractionsCounter.ToString());
            outputBox.AppendText(Environment.NewLine);
            string elapsedTime = String.Format("{0} минут {1} секунд затрачено на метод GetFractions.", ts.Minutes, ts.Seconds);
            outputBox.AppendText(elapsedTime + Environment.NewLine);
            string elapsedTime2 = String.Format("{0} минут {1} секунд затрачено на метод Display.", ts2.Minutes, ts2.Seconds);
            outputBox.AppendText(elapsedTime2 + Environment.NewLine);
            menuCommands.Enabled = true;
            ClearMemory();
        }

        private async void getAndSaveToJSONFile_Click(object sender, EventArgs e)
        {
            var b=int.TryParse(inputBox.Text, out int n);
            if (!b)
            {
                MessageBox.Show("Введите число от 1 до 10000!");
                return;
            }
            var  path = Environment.CurrentDirectory;
            totalFractionsCounter = 0;
            outputBox.Clear();
            //int n = int.Parse(inputBox.Text);
            menuCommands.Enabled = false;
            await Task.Run(() => GetFractions(n));
            var filename = "Fractions-" + inputBox.Text + ".json";
            File.WriteAllText(filename, JsonConvert.SerializeObject(fractions));
            ClearMemory();
            MessageBox.Show("Варианты разложения числа на суммы меньших его записаны в файл "+path+@"\"+filename);
            menuCommands.Enabled = true;
        }

        private void ClearMemory()
        {
            fractions.Clear();
            fractions.Capacity = 0;
            GC.Collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var s = Encoding.UTF8.GetString(Resource1._10000_fractions);
            calcFractionsCount = JsonConvert.DeserializeObject<Dictionary<int, string>>(s);
            //outputBox.Lines.
        }
    }
}
