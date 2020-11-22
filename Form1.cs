using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Calculator
{
    public partial class Form1 : Form
    {
        bool clearResult = false; //紀錄是否清除計算機數值


        public Form1()
        {
            InitializeComponent();
        }

        //此處思考一下Result與Process的動作
        private void Num_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (clearResult)
            {
                txtProcess.Text = "0";
                txtResult.Text = "0";
                clearResult = false;
            }
            if(txtResult.Text =="0" && txtProcess.Text == "0")
            {
                txtProcess.Text = btn.Text;
                txtResult.Text = btn.Text;
            }
            else
            {
                txtProcess.Text += btn.Text;
            }

        }

        //此處輸入Operator
        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtProcess.Text = btn.Text;
            txtResult.Text = "0"; //當前計算框重製
        }

    }
}
