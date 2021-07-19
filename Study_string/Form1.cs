using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sample, Test, Text
            string strText = lblText.Text;

            lblContain.Text = strText.Contains("Test").ToString();
            lblEquals.Text = strText.Equals("Test").ToString();
            lblLength.Text = strText.Length.ToString();
            lblReplace.Text = strText.Replace("Test", "I can").ToString();

            string[] strSplit = strText.Split(',');
            lblSplit.Text = strSplit[0].ToString();
            lblSplit2.Text = strSplit[1].ToString();
            lblSplit3.Text = strSplit[2].ToString();

            lblSubString.Text = strText.Substring(3, 5).ToString();
           
            lblTolower.Text = strText.ToLower().ToString();
            lblToUpper.Text = strText.ToUpper().ToString();

            lblTrim.Text = strText.Trim().ToString();   
           
        }
    }
}
