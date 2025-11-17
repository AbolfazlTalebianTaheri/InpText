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
            if (name != "" && lastName != "" && nationalCode != "")
            {
                    var person = new Person();
                    person.Name = name;
                    person.lastname = lastName;
                    person.National_code = nationalCode;
                    person.gender = gender;
                    var frm = Application.OpenForms[nameof(FrmPerson)] as FrmPerson;
                    frm.Persson.Add(person);
                txtName.Clear();
                txtlastName.Clear();
                txtNationalCode.Clear();
                cmbGgender.Text ="";
            }
            else
                MessageBox.Show("Fill in all the boxes.");
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
