using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> text { get; set; }
        public Form1()
        {
            InitializeComponent();
            text = new List<string>();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = ofd.FileName;
           
            text = System.IO.File.ReadAllLines(filename).ToList();
            listBox1.DataSource = text;
        }
    }
}
