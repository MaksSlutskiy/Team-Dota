using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
           
            text = File.ReadAllLines(filename).ToList();
            listBox1.DataSource = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = ofd.FileName;
            File.WriteAllLines(ofd.FileName,text);
            MessageBox.Show("Save file...");

        }
    }
}
