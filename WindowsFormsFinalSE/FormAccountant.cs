using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFinalSE
{
    public partial class FormAccountant : Form
    {
        FinalSE db = new FinalSE();
        public FormAccountant()
        {
            InitializeComponent();
        }
        private void Reload()
        {
            dataGridView_Acc.DataSource = null;
            dataGridView_Acc.DataSource = db.Accountants.ToList();
        }

        private void btn_AccAdd_Click(object sender, EventArgs e)
        {
            Accountant accountant = new Accountant();
            accountant.ID = txtBox_AccID.Text.ToString();
            accountant.AName = txtBox_AccName.Text.ToString();
            accountant.Phone = txtBox_AccPhone.Text.ToString();
            accountant.Email = txtBox_AccEmail.Text.ToString();
            accountant.BirthDay = dateTimePicker_AccBirth.Value;
            db.Accountants.Add(accountant);
            db.SaveChanges();
            Reload();
            MessageBox.Show("Accountant added successfully");
        }

        private void FormAccountant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSet.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.finalSEDataSet.Accountant);

        }

        private void dataGridView_Acc_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Acc.SelectedRows.Count > 0)
            {
                txtBox_AccID.Text = dataGridView_Acc.SelectedRows[0].Cells[0].Value.ToString();
                txtBox_AccName.Text = dataGridView_Acc.SelectedRows[0].Cells[1].Value.ToString();
                txtBox_AccPhone.Text = dataGridView_Acc.SelectedRows[0].Cells[2].Value.ToString();
                txtBox_AccEmail.Text = dataGridView_Acc.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker_AccBirth.Value = (DateTime)dataGridView_Acc.SelectedRows[0].Cells[4].Value;
            }

        }
    }
}
