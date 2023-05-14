using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Zach Scheffler
    ITD-2343 Obj-Oriented Programming Using C#
    16 May, 2023
*/
namespace Week2_Scheffler_Project
{
    public partial class frmSummer2023 : Form
    {
        public frmSummer2023()
        {
            InitializeComponent();

            label2.Text = "";

            //Ensures that the large text box is empty on start

        }

        private void clsButton_Click(object sender, EventArgs e)
        {
            this.Close();

            //Uses library function to close form out
        }

        private void cnclButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;

            //Saves text from textBox1 into label2
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
        }

        
    }
}
