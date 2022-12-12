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
    public partial class FormReport : Form
    {
        FinalSE db = new FinalSE();
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSetItemImported.Vw_ItemImported' table. You can move, or remove it, as needed.
            this.vw_ItemImportedTableAdapter.Fill(this.finalSEDataSetItemImported.Vw_ItemImported);



            // TODO: This line of code loads data into the 'finalSEDataSetOrdered.Vw_ItemOrdered' table. You can move, or remove it, as needed.
            this.vw_ItemOrderedTableAdapter.Fill(this.finalSEDataSetOrdered.Vw_ItemOrdered);
            


        }




        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewTopSelling.DataSource = null;
            if (comboBoxSort.Text == "Quantity")
            {
                /*datagridviewtopselling should be sorted by quantity*/
                //dataGridViewTopSelling.DataSource = db.Incomes.Where(x => x.OrderDate >= dateTimePickerFrom.Value && x.OrderDate <= dateTimePickerTo.Value).OrderByDescending(x => x.Quantity).ToList();
            }
            else if (comboBoxSort.Text == "Total Price")
            {
                /*datagridviewtopselling should be sorted by price*/
                //dataGridViewTopSelling.DataSource = db.Incomes.Where(x => x.OrderDate >= dateTimePickerFrom.Value && x.OrderDate <= dateTimePickerTo.Value).OrderByDescending(x => x.TotalPrice).ToList();
            }
        }

        private void btnLoadIncome_Click(object sender, EventArgs e)
        {
            dataGridViewIncome.DataSource = null;
            int num = 0;
            int total = 0;
            if (comboBoxIncomeSort.Text == "Quantity")
            {
                
                dataGridViewIncome.DataSource = db.Vw_ItemOrdered.Where(x => x.OrderDate >= dateTimePickerIncomeFrom.Value && x.OrderDate <= dateTimePickerIncomeTo.Value).OrderByDescending(x => x.Quantity).ToList();
                foreach (DataGridViewRow row in dataGridViewIncome.Rows)
                {
                    num += Convert.ToInt32(row.Cells[2].Value);
                    total += Convert.ToInt32(row.Cells[3].Value);
                }
                txtTotal.Text = num.ToString();
                txtTotalIncome.Text = total.ToString();
            }
            else if (comboBoxIncomeSort.Text == "Total Price")
            {
                dataGridViewIncome.DataSource = db.Vw_ItemOrdered.Where(x => x.OrderDate >= dateTimePickerIncomeFrom.Value && x.OrderDate <= dateTimePickerIncomeTo.Value).OrderByDescending(x => x.TotalPrice).ToList();
                foreach (DataGridViewRow row in dataGridViewIncome.Rows)
                {
                    num += Convert.ToInt32(row.Cells[2].Value);
                    total += Convert.ToInt32(row.Cells[3].Value);
                }
                txtTotal.Text = num.ToString();
                txtTotalIncome.Text = total.ToString();
            }
            
        }

        private void btnLoadOutcome_Click(object sender, EventArgs e)
        {
            dataGridViewOutcome.DataSource = null;
            int num = 0;
            int total = 0;
            if (comboBoxOutcomeSort.Text == "Quantity")
            {
                dataGridViewOutcome.DataSource = db.Vw_ItemImported.Where(x => x.ImportDate >= dateTimePickerOutcomeFrom.Value && x.ImportDate <= dateTimePickerOutcomeTo.Value).OrderByDescending(x => x.Quantity).ToList();
                foreach (DataGridViewRow row in dataGridViewOutcome.Rows)
                {
                    num += Convert.ToInt32(row.Cells[3].Value);
                    total += Convert.ToInt32(row.Cells[4].Value);
                }
                txtImport.Text = num.ToString();
                txtOutcome.Text = total.ToString();
            }
            else if (comboBoxOutcomeSort.Text == "Total Price")
            {
                dataGridViewOutcome.DataSource = db.Vw_ItemImported.Where(x => x.ImportDate >= dateTimePickerOutcomeFrom.Value && x.ImportDate <= dateTimePickerOutcomeTo.Value).OrderByDescending(x => x.price).ToList();
                foreach (DataGridViewRow row in dataGridViewOutcome.Rows)
                {
                    num += Convert.ToInt32(row.Cells[3].Value);
                    total += Convert.ToInt32(row.Cells[4].Value);
                }
                txtImport.Text = num.ToString();
                txtOutcome.Text = total.ToString();
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {

            int income = 0;
            int outcome = 0;
            int revenue = 0;
            foreach (Vw_ItemImported s in db.Vw_ItemImported.Where(x => x.ImportDate.Value.Month == dateTimePicker.Value.Month))
            {
                outcome += Convert.ToInt32(s.price);
            }
            foreach (Vw_ItemOrdered s in db.Vw_ItemOrdered.Where(x => x.OrderDate.Value.Month == dateTimePicker.Value.Month))
            {
                income += Convert.ToInt32(s.TotalPrice);
            }
           
            revenue = income - outcome;
            txtRevenue.Text = revenue.ToString();
        }

        private void dataGridViewOutcome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
