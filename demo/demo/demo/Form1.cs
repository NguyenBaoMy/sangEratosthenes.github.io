using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace demo
{
    public class TextBoxStreamWriter : TextWriter
    {
        TextBox _output = null;

        public TextBoxStreamWriter(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.AppendText(value.ToString());

        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void eratosthenes_MouseEnter(object sender, EventArgs e)
        {
            Stopwatch tEra = new Stopwatch();
            tEra.Start();
            int n = int.Parse(textBox1.Text);
            bool[] a = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                a[i] = true;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (a[i])
                {
                    int j = (int)Math.Pow(i, 2);
                    while (j <= n)
                    {
                        a[j] = false;
                        j += i;
                    }
                }
            }
            for (int i = 2; i <= n; i++)
                if (a[i])
                    Console.Write("{0} ", i);
            tEra.Stop();
            Console.WriteLine("Thời gian thực hiện: " + tEra.ElapsedTicks);
        }
    }
}
