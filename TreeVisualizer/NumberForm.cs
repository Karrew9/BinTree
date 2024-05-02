using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TreeVisualizer
{
    public partial class NumberForm : Form
    {
        public NumberForm()
        {
            InitializeComponent();
        }

        private void grafButton_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            chart1.Series["Series1"].ChartType = SeriesChartType.Line;
            int[] a = new int[4];
            Random rnd = new Random();
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                int num = rnd.Next(1, 51);
                while (a.Contains(num))
                    num = rnd.Next(1, 51);
                a.SetValue(num, i);
            }
            Array.Sort(a);
            for (int i = 1; i <= a[3]; i++)
            {
                if (a.Contains(i))
                {
                    if (count == 0 || count == 3)
                    {
                        chart1.Series["Series1"].Points.AddXY(i, 0);
                        count++;
                        continue;
                    }
                    if (count == 1 || count == 2)
                    {
                        chart1.Series["Series1"].Points.AddXY(i, 1);
                        count++;
                        continue;
                    }
                }
            }
            textBox1.Text = "";
            for (int i = 0; i < a.Length; i++)
            {
                textBox1.Text += a[i].ToString() + " ";
            }
            // Настройка вида графика
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "u(x)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> res = new List<int>();
            string[] X = textBox2.Text.Split(' ');
            richTextBox1.Clear();
            textBox3.Clear();
            for (int i = 0; i < X.Length; i++)
            {
                int F = Function(int.Parse(X[i]));
                res.Add(F);
                textBox3.Text += F.ToString() + " ";
            }
        }
        public int Function(int x)
        {
            string[] a = textBox1.Text.Split(' ');
            List<double> ts = new List<double>();
            List<int> c = new List<int>();
            double add;
            int F = -1;
            for (int i = x; i < x + 5; i++)
            {
                if (int.Parse(a[0]) <= i && i < int.Parse(a[1]))
                {
                    add = (i - Convert.ToDouble(a[0])) / (Convert.ToDouble(a[1]) - Convert.ToDouble(a[0]));
                    double con = Math.Round(Convert.ToDouble(add), 1);
                    ts.Add(con);
                    c.Add(i);
                    richTextBox1.AppendText(i.ToString() + " " + con.ToString() + "\n");
                    continue;
                }
                if (int.Parse(a[1]) <= i && i < int.Parse(a[2]))
                {
                    add = 1;
                    double con = Math.Round(Convert.ToDouble(add), 1);
                    ts.Add(con);
                    c.Add(i);
                    richTextBox1.AppendText(i.ToString() + " " + con.ToString() + "\n");
                    continue;
                }
                if (int.Parse(a[2]) <= i && i < int.Parse(a[3]))
                {
                    add = (Convert.ToDouble(a[3]) - i) / (Convert.ToDouble(a[3]) - Convert.ToDouble(a[2]));
                    double con = Math.Round(Convert.ToDouble(add), 1);
                    ts.Add(con);
                    c.Add(i);
                    richTextBox1.AppendText(i.ToString() + " " + con.ToString() + "\n");
                    continue;
                }
                if (i < int.Parse(a[0]) || i >= int.Parse(a[3]))
                {
                    add = 0;
                    double con = Math.Round(Convert.ToDouble(add), 1);
                    ts.Add(con);
                    c.Add(i);
                    richTextBox1.AppendText(i.ToString() + " " + con.ToString() + "\n");
                    continue;
                }
            }
            bool found = false;
            int Num = 0;
            double razn = 100000;
            for (int i = 0; i < ts.Count; i++)
            {
                double sumLeft = 0;
                double sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += ts[j];
                }

                for (int k = i + 1; k < ts.Count; k++)
                {
                    sumRight += ts[k];
                }

                if (sumLeft == sumRight)
                {
                    F = c[i];
                    found = true;
                    break;
                }
                else if (Math.Abs(sumLeft - sumRight) < 1)
                {
                    if (i == 0 || i == c.Count)
                        continue;
                    if (Math.Abs(sumLeft - sumRight) < razn)
                    {
                        razn = Math.Abs(sumLeft - sumRight);
                        Num = c[i];
                    }
                }
            }
            if (!found)
            {
                F = Num;
            }
            return F;
        }

        private void BinButton_Click(object sender, EventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            mainMenu.txt_Insert.Clear();
            mainMenu.txt_Insert.Text = textBox3.Text;
            mainMenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
