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
    public partial class FrmPerson : Form
    {
        public List<Person> Persson = new List<Person>();
        public FrmPerson()
        {
            InitializeComponent();
        }
        void RefreshDgv()
        {
            dgvPerson.DataSource = Persson.ToList();
        }
        void ShowAddOeRemove(string TextTitre)
        { 
          FrmAdd frm = new FrmAdd();
            frm.Text = TextTitre;
            frm.ShowDialog();
            RefreshDgv();
        }
        void ShowDelPerson(string TextTitre)
        {
            FrmRemove frm = new FrmRemove();
            frm.Text = TextTitre;
            frm.ShowDialog();
            RefreshDgv();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddOeRemove("Add");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //ShowDelPerson("Remove");
            if (dgvPerson.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPerson.SelectedRows[0];
                Person selctedPerson = (Person)selectedRow.DataBoundItem;
                Persson.Remove(selctedPerson);
                //dgvPerson.DataSource = null;
                dgvPerson.DataSource = Persson.ToList();
            }
            else
                MessageBox.Show("لطفا یک سطر را انتخاب کنید");
        }
    }
}
