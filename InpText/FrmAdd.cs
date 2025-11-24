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
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtlastName.Text;
            string nationalCode = txtNationalCode.Text;
            string gender = cmbGgender.Text;
            var addPerson = new AddPeson();
            bool isValid = addPerson.Info(name, lastName, nationalCode, gender);
            if (isValid)
            {
                txtName.Clear();
                txtlastName.Clear();
                txtNationalCode.Clear();
                cmbGgender.Text = "";
                MessageBox.Show("Person added successfully.");
            }
            else
                MessageBox.Show("Enter the information correctly.");
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalCode.Text.Length >= 10)
                btnConfirmation.Enabled = true;
            else
                btnConfirmation.Enabled = false;
        }
    }
}
