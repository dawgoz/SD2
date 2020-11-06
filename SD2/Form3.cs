using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SD2
{
    public partial class Form3 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        string line = "";
        Deque deq = new Deque();
        string strValues;
        string[] valueArr;
        public Form3()

        {
            InitializeComponent();
            deq = Form2.deq;
            strValues = Form2.strValues;
            valueArr = Form2.valueArr;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        txtValues.Text = line;
                    }
                }
                sr.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void btnCreateManualy_Click(object sender, EventArgs e)
        {
            deq.size = 0;
            strValues = txtValues.Text;
            char[] separator = { ',', ' ', ';' };
            valueArr = strValues.Split(separator);
            foreach (var s in valueArr)
            {
                deq.size++;
            }
            deq.deqSize = deq.size;
                foreach (var s in valueArr)
                {
                    deq.InsertLast(s);
                }
                Form4 form4 = new Form4();
                this.Hide();
                form4.ShowDialog();
            
        }
    }
}
