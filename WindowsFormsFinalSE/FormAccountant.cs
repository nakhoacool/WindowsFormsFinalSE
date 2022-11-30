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
            btn_AccAdd.Enabled = true;
            btn_AccClear.Enabled = true;
            btn_AccUpdate.Enabled = false;
            btn_AccDelete.Enabled = false;
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
            Clear.ResetAllControls(this);
        }

        private void FormAccountant_Load(object sender, EventArgs e)
        {
            this.accountantTableAdapter.Fill(this.finalSEDataSet.Accountant);
        }
        private void dataGridView_Acc_Click(object sender, EventArgs e)
        {
            txtBox_AccID.Text = dataGridView_Acc.CurrentRow.Cells[0].Value.ToString();
            txtBox_AccName.Text = dataGridView_Acc.CurrentRow.Cells[1].Value.ToString();
            txtBox_AccPhone.Text = dataGridView_Acc.CurrentRow.Cells[2].Value.ToString();
            txtBox_AccEmail.Text = dataGridView_Acc.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_AccBirth.Value = (DateTime)dataGridView_Acc.CurrentRow.Cells[4].Value;

            btn_AccAdd.Enabled = false;
            btn_AccUpdate.Enabled = true;
            btn_AccDelete.Enabled = true;
        }


        private void btn_AccDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string id = txtBox_AccID.Text.ToString();
                Accountant accountant = db.Accountants.Find(id);
                db.Accountants.Remove(accountant);
                db.SaveChanges();
                Reload();
                MessageBox.Show("Accountant deleted successfully");
                Clear.ResetAllControls(this);
            }

        }

        private void btn_AccUpdate_Click(object sender, EventArgs e)
        {
            Accountant accountant = db.Accountants.Find(txtBox_AccID.Text);
            accountant.AName = txtBox_AccName.Text.ToString();
            accountant.Phone = txtBox_AccPhone.Text.ToString();
            accountant.Email = txtBox_AccEmail.Text.ToString();
            accountant.BirthDay = dateTimePicker_AccBirth.Value;
            db.SaveChanges();
            Reload();
            MessageBox.Show("Accountant updated successfully");
            Clear.ResetAllControls(this);
        }

        private void btn_AccClear_Click(object sender, EventArgs e)
        {
            Clear.ResetAllControls(this);
            Reload();
            btn_AccAdd.Enabled = true;
            btn_AccUpdate.Enabled = false;
            btn_AccDelete.Enabled = false;
        }

        private void btn_AccSearch_Click(object sender, EventArgs e)
        {

            if (txtBox_AccID.Text != "")
            {
                dataGridView_Acc.DataSource = null;
                dataGridView_Acc.DataSource = db.Accountants.Where(x => x.ID == txtBox_AccID.Text).ToList();
            }
            else if (txtBox_AccName.Text != "")
            {
                dataGridView_Acc.DataSource = null;
                dataGridView_Acc.DataSource = db.Accountants.Where(x => x.AName == txtBox_AccName.Text).ToList();
            }
            else if (txtBox_AccPhone.Text != "")
            {
                dataGridView_Acc.DataSource = null;
                dataGridView_Acc.DataSource = db.Accountants.Where(x => x.Phone == txtBox_AccPhone.Text).ToList();
            }
            else if (txtBox_AccEmail.Text != "")
            {
                dataGridView_Acc.DataSource = null;
                dataGridView_Acc.DataSource = db.Accountants.Where(x => x.Email == txtBox_AccEmail.Text).ToList();
            }
            else
            {
                dataGridView_Acc.DataSource = null;
                dataGridView_Acc.DataSource = db.Accountants.ToList();
            }
        }
    }
    public class Clear
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Value = DateTime.Now;
                }

                if (control is DataGridView)
                {
                    DataGridView dataGridView = (DataGridView)control;
                    dataGridView.ClearSelection();
                }
            }
        }
    }
}
