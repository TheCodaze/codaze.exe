using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUpdateService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("The Program can't start because MSVCP140.dll is missing from your computer. Try reinstalling the program to fix this problem.", "Codaze.exe 3.0",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Form2 MyForm = new Form2();

            this.timer1.Start();
            this.timer2.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(1);
            if (progressBar2.Value >= progressBar2.Maximum)
            {
                timer2.Stop();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}
