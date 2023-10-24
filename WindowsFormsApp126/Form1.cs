using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp126
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.IO.FileStream f = new System.IO.FileStream("c:\\c-sharp-14020510\\test.txt", System.IO.FileMode.CreateNew);
            byte[] b = System.Text.Encoding.Unicode.GetBytes(textBox1.Text);
            f.Write(b, 0, b.Length);
            f.Flush();
            f.Close();
        }
    }
}
