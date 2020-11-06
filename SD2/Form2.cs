using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string strValues;
        public static string[] valueArr;
        public static Deque deq = new Deque();

        private void btnCreateManualy_Click(object sender, EventArgs e)
        {
            deq.size = 0;
            deq.deqSize = int.Parse(txtSize.Text);
            strValues = txtValues.Text;
            char[] separator = { ',', ' ', ';' };
            valueArr = strValues.Split(separator);
            foreach (var s in valueArr)
            {
                deq.size++;
            }
            if (deq.size > deq.deqSize)
            {
                MessageBox.Show("Too many values!");
            }
            else
            {
                foreach (var s in valueArr)
                {
                    deq.InsertLast(s);
                }
                Form4 form4 = new Form4();
                this.Hide();
                form4.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();

        }
    }
}
