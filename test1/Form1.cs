using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            try
            {
                int op1Number = int.Parse(this.textboxop1.Text);
                int op2Number = int.Parse(this.textboxop2.Text);
                int result = op1Number + op2Number;
                this.labelResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                this.labelResult.Text = ex.Message;
            }
            //this.labelResult.Text = this.textboxop1.Text + this.textboxop2.Text;
        }
    }
}
