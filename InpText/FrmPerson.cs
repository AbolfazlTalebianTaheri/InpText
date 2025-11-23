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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddOeRemove("Add");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPerson.SelectedRows[0];
                Person selctedPerson = (Person)selectedRow.DataBoundItem;
                Persson.Remove(selctedPerson);
                dgvPerson.DataSource = null;
                RefreshDgv();
            }
            else
                MessageBox.Show("لطفا یک سطر را انتخاب کنید");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPerson.SelectedRows.Count > 0)
            {
                try
                {
                    int index = dgvPerson.SelectedRows.Count;
                    EditPerson.Index = index;
                    new FrmEditPerson().ShowDialog();
                    bool successful = EditPerson.Successful_Operation;
                    if (successful)
                    {
                        DataGridViewRow selectedRow = dgvPerson.SelectedRows[0];
                        Person selctedPerson = (Person)selectedRow.DataBoundItem;
                        Persson.Remove(selctedPerson);
                        dgvPerson.DataSource = null;
                        RefreshDgv();
                        EditPerson.successful = false;
                    }
                }
                catch
                {
                    MessageBox.Show("خطا در ویرایش");
                }
            }
            else
                MessageBox.Show("لطفا یک سطر را انتخاب کنید");
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }
    }
}