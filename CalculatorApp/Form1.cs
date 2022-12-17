using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //input(take data from form)
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            //action
            int res = num1+ num2;
            //output(put data in form)
             lableResult.Text = res.ToString(); 
            labelResultInfo.Text = num1.ToString()+ "+" + num2.ToString()+  "=" +res.ToString();   
        }

        private void sub_Click(object sender, EventArgs e)
        {
            //input(take data from form)
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            //action
            int res = num1 - num2;
            //output(put data in form)
            lableResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + "-" + num2.ToString() + "=" + res.ToString();
        }

        private void dis_Click(object sender, EventArgs e)
        {
            //input(take data from form)
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            //action
            int res = num1 / num2;
            //output(put data in form)
            lableResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + "/" + num2.ToString() + "=" + res.ToString();
        }

        private void mount_Click(object sender, EventArgs e)
        {
            //input(take data from form)
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            //action
            int res = num1 * num2;
            //output(put data in form)
            lableResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + "*" + num2.ToString() + "=" + res.ToString();
        }

        private void ost_Click(object sender, EventArgs e)
        {
            //input(take data from form)
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            //action
            int res = num1 % num2;
            //output(put data in form)
            lableResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + "%" + num2.ToString() + "=" + res.ToString();
        }
    }
}
