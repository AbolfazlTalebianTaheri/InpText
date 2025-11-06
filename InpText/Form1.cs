using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InpText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtInputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || e.KeyChar == ' ')
                return;
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void btnListWord_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text != "")
            {
                lblResult.Visible = true;
                string temp = txtInputText.Text;
                lblResult.Text = temp;
            }
            else
            {
                MessageBox.Show("لطفا کادر را پر کنید");
                lblResult.Visible = false;
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text != "")
            {
                lblResult.Visible = true;
                string inText = txtInputText.Text;
                int number = 1;
                for (int i = 0; i < inText.Length; i++)
                    if (i < inText.Length - 1)
                        if (inText[i] == ' ' && inText[i + 1] != ' ')
                            number++;
                lblResult.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("لطفا کادر را پر کنید");
                lblResult.Visible = false;
            }
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text != "" && txtInputChar.Text != "")
            {
                lblResult.Visible = true;
                string inChar = txtInputChar.Text.ToLower();
                int number = 0;
                foreach (char item in txtInputText.Text)
                    if (item.ToString().ToLower() == inChar)
                        number++;
                lblResult.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("لطفا کادر پایینی راهم پر کنید");
                lblResult.Visible = false;
            }
        }

    }
}
