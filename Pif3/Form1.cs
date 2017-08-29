using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pif3
{
    public partial class Form1 : Form
    {
        SortedSet<uint> pif_s = new SortedSet<uint>();
        List<String> quadrix = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTriples();
            outputBox.AppendText(pif_s.Count.ToString() + "  Элементов в массиве.");

            File.WriteAllText(Application.StartupPath + "Pythagorean triples.json", JsonConvert.SerializeObject(pif_s));
        }

        private void GetTriples()
        {
            for (uint i = 2; i <= 23170; i++)
            {
                uint a = i * i - (i - 1) * (i - 1);
                uint b = 2 * i * (i - 1);
                uint c = i * i + (i - 1) * (i - 1);
                pif_s.Add(a);
                pif_s.Add(b);
                pif_s.Add(c);
                progBar.PerformStep();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //progBar.Step = 2;
            //var progress = new Progress<int>(s => progBar.Value = s);
            //var progress = new Progress<String>(s=> outputBox.AppendText(s));
            
            //await Task.Run(()=>Check(progress)).ConfigureAwait(false);
            Check3();
            //Display();
        }

        private void Check3()
        {
            GetTriples();
            int tmp = 1;
            foreach (var i in pif_s)
            {
                foreach (var j in pif_s)
                {
                    foreach (var k in pif_s)
                    {
                        foreach (var l in pif_s)
                        {
                            if ((j != k) && (i != l) && (k != l) && (i != j) && (j != l) && (i != k) && (i * i + k * k == j * j + l * l))
                            {
                                outputBox.AppendText(i.ToString() + "+" + j.ToString() + "+" + k.ToString() + "+" + l.ToString());
                                outputBox.AppendText(Environment.NewLine);
                            }
                        }
                    }
                }
                outputBox.AppendText((tmp++).ToString());
                outputBox.AppendText(Environment.NewLine);
            }
        
        }
        private void Check2()
        {
            GetTriples();
            for (uint i = 2; i < 11585; i++)
            {
                for (uint j = 2; j < 11585; j++)
                {
                    for (uint k = 2; k < 11585; k++)
                    {
                        for (uint l = 2; l < 11585; l++)
                        {
                            if (pif_s.Contains(i)&& pif_s.Contains(j)&& pif_s.Contains(k)&& pif_s.Contains(l))
                            {
                                outputBox.AppendText("+");
                                if (i * i + k * k == j * j + l * l)
                                {
                                    outputBox.AppendText(i.ToString() + "+" + j.ToString() + "+" + k.ToString() + "+" + l.ToString());
                                    outputBox.AppendText(Environment.NewLine);
                                    Application.DoEvents();
                                }
                                //p.Report(i.ToString() + "+" + j.ToString() + "+" + k.ToString() + "+" + l.ToString());

                                //quadrix.Add(i.ToString() + "+" + j.ToString() + "+" + k.ToString() + "+" + l.ToString());

                            }
                        }
                    }
                }
            }
        }

        private void Check()
        {
            for (int i = 2; i < 11585; i++)
            {
                for (int j = 2; j < 11585; j++)
                {
                    for (int k = 2; k < 11585; k++)
                    {
                        for (int l = 2; l < 11585; l++)
                        {
                            if ((j!=k)&&(i!=l)&&(k!=l)&&(i!=j)&&(j!=l)&&(i!=k)&&(i * i + k * k == j * j + l * l))
                            {
                                //p.Report(i.ToString() + "+" + j.ToString() + "+" + k.ToString() + "+" + l.ToString());

                                //quadrix.Add(i.ToString() + "+" + j.ToString() + "+" + k.ToString() + "+" + l.ToString());
                                outputBox.AppendText(i.ToString() + "+" + j.ToString() + "+" + k.ToString() + "+" + l.ToString());
                                outputBox.AppendText(Environment.NewLine);
                                Application.DoEvents();
                            }
                        }
                    }
                }
            }
        }

        private void Display()
        {
            foreach (var s in quadrix)
            {
                outputBox.AppendText(s);
                outputBox.AppendText(Environment.NewLine);
                Application.DoEvents();
            }
        }
    }
}