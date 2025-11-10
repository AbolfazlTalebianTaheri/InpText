using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InpText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void outPut_Message(int Importance =0)
        {
            if (Importance == 0)
                MessageBox.Show("لطفا کادر ها را پر کنید");
            else
                MessageBox.Show("لطفا هر دو کادر را پر کنید");

                lblResult.Visible = false;
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
             if (txtInputText.Text != "" && txtInputChar.Text != "")
            {
                lblResult.Visible = true;
                string temp = txtInputText.Text;
                string te = txtInputChar.Text;
                string result = "";
                bool bre = false;
                for(int i=0; i<temp.Length;i++)
                {
                    if (temp[i].ToString() == te)
                        for (int j = i; j >= 0; j--)
                            if (temp[j] == ' ' || j == 0)
                            {
                                int J = j;
                                if(j==0)
                                    J = j;
                                else
                                    J = j+1;
                                for (int k = J; k < temp.Length; k++)
                                {
                                    if (temp[k] == ' ' || k == temp.Length)
                                    {
                                        lblResult.Visible = true;
                                        lblResult.Text = result;
                                        i = k;
                                        break;
                                    }
                                    result += temp[k];
                                    bre = true;
                                }
                                if(bre)
                                {
                                    bre = false;
                                    result += " ";
                                    break;
                                    
                                }
                            }
                    lblResult.Text = result;
                }
            }
            else
                outPut_Message();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text != "" && txtInputChar.Text != "")
            {
                lblResult.Visible = true;
                string inText = txtInputChar.Text;
                string temp = txtInputText.Text;
                int number = 0;
                for (int i = 0; i < temp.Length; i++)
                    if (temp[i].ToString() == inText)
                        for (int j = i; j < temp.Length; j++)
                            if (temp[j].ToString() == " " || j==temp.Length-1)
                            {
                                number++;
                                i = j;
                                break;
                            }
                lblResult.Text = number.ToString();
            }
            else
                outPut_Message();
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
                outPut_Message(1);
        }

        private void txtInputText_MouseHover(object sender, EventArgs e)
        {
            ToolTip textIn = new ToolTip();
            textIn.SetToolTip(txtInputText,"در اینجا متن خود را وارد کنید");
        }

        private void txtInputChar_MouseHover(object sender, EventArgs e)
        {
            ToolTip textIn = new ToolTip();
            textIn.SetToolTip(txtInputChar, "در اینجا کاراکتر مورد نظر را وارد کنید");
        }
    }
}
