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

namespace texBuilder_test
{
    public partial class Form1 : Form
    {
        private string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox3_DragDrop(object sender, DragEventArgs e)
        {
            string[] temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            filePath = temp[0];
            textBox3.Text = temp[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var converter = new Converter((string s) => textBox1.AppendText(s + "\r\n"), (string s) => textBox2.AppendText(s + "\r\n"));
            if(File.Exists(filePath)) {
                converter.Start(filePath);
            }
            else
            {
                MessageBox.Show("ファイルが存在しません");
            }
        }
    }
}
