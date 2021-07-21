using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study3_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
                   
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA + iNumB;

            tboxResult.Text = iResult.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA - iNumB;

            tboxResult.Text = iResult.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA * iNumB;

            tboxResult.Text = iResult.ToString();
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA / iNumB;

            tboxResult.Text = iResult.ToString();
        }

        private int ex(int iA, int iB)
        {
            return 0;
        }
    }
}
