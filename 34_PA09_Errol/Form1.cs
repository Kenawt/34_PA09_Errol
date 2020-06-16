using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_PA09_Errol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            try
            {
                double AmountEntered;
                double convertedValue;
                //checking for null button
                if ((rdb_USD.Checked == false) && (rdb_JP.Checked == false) && (rdb_MY.Checked == false))
                    txt_ConvertedAmt.Text = "Select at least one type of currency to convert.";

                if (rdb_USD.Checked == true)
                {
                    AmountEntered = double.Parse(txt_Amount.Text);
                    convertedValue = AmountEntered * 0.74;
                    txt_ConvertedAmt.Text = convertedValue.ToString();
                }
                if (rdb_JP.Checked == true)
                {
                    AmountEntered = double.Parse(txt_Amount.Text);
                    convertedValue = AmountEntered * 81.97;
                    txt_ConvertedAmt.Text = convertedValue.ToString();
                }

                if (rdb_MY.Checked == true)
                {
                    AmountEntered = double.Parse(txt_Amount.Text);
                    convertedValue = AmountEntered * 3.01;
                    txt_ConvertedAmt.Text = convertedValue.ToString();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter a valid value.");
                txt_Amount.Text = "";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rdb_JP.Checked = false;
            rdb_USD.Checked = false;
            rdb_MY.Checked = false;
            txt_Amount.Text = "";
            txt_ConvertedAmt.Text = "";
        }
    }
}
