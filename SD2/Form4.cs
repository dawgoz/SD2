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
    public partial class Form4 : Form
    {
        Deque deq = new Deque();
        string strValues;
        string[] valueArr;

        public Form4()
        {
            InitializeComponent();

            deq = Form2.deq;
            strValues = Form2.strValues;
            valueArr = Form2.valueArr;
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {

            if (deq.IsEmpty() || Form2.strValues == "") lblEmpty.Text = "Empty";
            else lblEmpty.Text = "Not empty";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (Form2.strValues == "")
            {
                txtRead.Text = "null";
            }
            else
            {/*
                string temp = "";
                foreach (var item in valueArr)
                {
                    temp += item + " ";
                }
                txtRead.Text = temp;*/

                txtRead.Text = deq.Read();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lblSize.Text = deq.GetSize(deq.deqSize).ToString();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            if (deq.size == 1 && Form2.strValues == "" || !deq.IsFull(deq.deqSize))
            {
                lblFull.Text = "Not Full";
            }
            else lblFull.Text = "Full";
            
        }

        private void btnReadFirstLast_Click(object sender, EventArgs e)
        {
            if (deq.IsEmpty())
            {
                lblFirst.Text = "null";
                lblLast.Text = "null";
            }
            else
            {
                lblFirst.Text = deq.GetFront();
                lblLast.Text = deq.GetRear();
            }

        }

        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            if (deq.IsEmpty()) MessageBox.Show("Degue is empty!");
            else deq.DeleteFront();
        }

        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            if (deq.IsEmpty()) MessageBox.Show("Degue is empty!");
            else deq.DeleteLast();
        }

        private void btnInsertFirst_Click(object sender, EventArgs e)
        {
            deq.InsertFront(txtInsertFirst.Text);
            txtInsertFirst.Clear();
            if (deq.GetElementCount() > deq.deqSize)
            {
                deq.deqSize++;
            }
        }

        private void btnInsertLast_Click(object sender, EventArgs e)
        {
            deq.InsertLast(txtInsertLast.Text);
            txtInsertLast.Clear();
            if (deq.GetElementCount()>deq.deqSize)
            {
                deq.deqSize++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (deq.IsPalindrome()) lblPalindrome.Text = "Yes";
            else lblPalindrome.Text = "No";
        }
    }
}
