﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServicesWFA.MathService;

namespace MathServicesWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            MathServiceClient loClient = new MathServiceClient();

            Int32 loNum1 = Convert.ToInt32(txtNum1.Text.Trim());
            Int32 loNum2 = Convert.ToInt32(txtNum2.Text.Trim());

            if (cboOperation.Text == "Add")
            {
                txtResult.Text = loClient.Add(loNum1, loNum2).ToString();
            }
            else if(cboOperation.Text == "Subtract")
            {
                txtResult.Text = loClient.Subtract(loNum1, loNum2).ToString();

            }
            else if (cboOperation.Text == "Multiply")
            {
                txtResult.Text = loClient.Subtract(loNum1, loNum2).ToString();

            }
            else if (cboOperation.Text == "Divide")
            {
                txtResult.Text = loClient.Subtract(loNum1, loNum2).ToString();

            }
            else
            {
                txtResult.Text = loClient.Subtract(loNum1, loNum2).ToString();

            }
        }
    }
}
