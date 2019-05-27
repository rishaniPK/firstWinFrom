using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstWinFrom
{
    public partial class Form_calculator : Form
    {
        public Form_calculator()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        //subrating 2 numbers
        private void Btn_subr_Click(object sender, EventArgs e)
        {
            int first_number = int.Parse(txt_num1.Text);
            int second_number = int.Parse(txt_num2.Text);
            int result = first_number - second_number;
            txt_resu.Text = result.ToString();
        }

        //multipling 2 numebrs

        private void Btn_multi_Click(object sender, EventArgs e)
        {
            int first_number = int.Parse(txt_num1.Text);
            int second_number = int.Parse(txt_num2.Text);
            int result = first_number * second_number;
            txt_resu.Text = result.ToString();
        }
        //Adding 2 numbers

        private void Btn_addi_Click(object sender, EventArgs e)
        {
            int first_number = int.Parse(txt_num1.Text);
            int second_number = int.Parse(txt_num2.Text);
            int result = first_number + second_number;
            txt_resu.Text = result.ToString();
        }

        //Dividing two numbers
        private void Bnt_divi_Click(object sender, EventArgs e)
        {
            int first_number = int.Parse(txt_num1.Text);
            int second_number = int.Parse(txt_num2.Text);
            int result = first_number / second_number;
            txt_resu.Text = result.ToString();
        }
        
        //Code to refresh the controls (clearing the data)
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
