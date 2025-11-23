using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InpText
{
    public partial class FrmEditPerson : Form
    {
        public FrmEditPerson()
        {
            InitializeComponent();
        }
        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtlastName.Text;
            string nationalCode = txtNationalCode.Text;
            string gender = cmbGgender.Text;
            int index = EditPerson.Index;
            var editIndex = new EditPerson();
            if (index > 0)
            {
                bool isValid = editIndex.Info(name, lastName, nationalCode, gender);
                if (isValid)
                {
                    txtName.Clear();
                    txtlastName.Clear();
                    txtNationalCode.Clear();
                    cmbGgender.Text = "";   
                }
                else
                    MessageBox.Show("Fill in all the boxes.");
            }
        }
    }
}