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
            textBox1.ResetText();
            textBox2.ResetText();

            if(e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
                string[] temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if(Path.GetExtension(temp[0]).Equals(".btex"))
                {
                    filePath = temp[0];
                    InputFile_Box.Text = temp[0];
                }
                else
                {
                    e.Effect = DragDropEffects.None; 
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox3_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Convert_Button_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();

            Console.WriteLine($"sender:[{sender}], [EventArgs:{e}]");
            var converter = new Converter((string s) => textBox1.AppendText(s + "\r\n"), (string s) => textBox2.AppendText(s + "\r\n"));
            if(File.Exists(filePath)) {
                converter.Start(new StreamReader(filePath));
            }
            else
            {
                MessageBox.Show("ファイルが存在しません");
            }
        }

        private void OpenFile_Button_Click(object sender, EventArgs e)
        {
            if(OpenDialog.ShowDialog() == DialogResult.OK)
            {
                InputFile_Box.Text = filePath = OpenDialog.FileName;
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if(textBox2.TextLength <= 0)
            {
                Convert_Button_Click(sender, e);
            }

            SaveDialog.FileName = Path.GetFileNameWithoutExtension(filePath);
            if(SaveDialog.ShowDialog() == DialogResult.OK)
            {
                using(var writer = new StreamWriter(SaveDialog.FileName))
                {
                    writer.Write(textBox2.Text);
                }
            }
        }
    }
}
