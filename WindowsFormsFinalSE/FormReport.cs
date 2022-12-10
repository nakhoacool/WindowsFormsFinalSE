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
            // TODO: This line of code loads data into the 'finalSEDataSetSold.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter.Fill(this.finalSEDataSetSold.Income);

        }

        
       

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewTopSelling.DataSource = null;
            if (comboBoxSort.Text == "Quantity")
            {
                /*datagridviewtopselling should be sorted by quantity*/
                dataGridViewTopSelling.DataSource = db.Incomes.Where(x => x.OrderDate >= dateTimePickerFrom.Value && x.OrderDate <= dateTimePickerTo.Value).OrderByDescending(x => x.Quantity).ToList();
            }
            else if (comboBoxSort.Text == "Total Price")
            {
                /*datagridviewtopselling should be sorted by price*/
                dataGridViewTopSelling.DataSource = db.Incomes.Where(x => x.OrderDate >= dateTimePickerFrom.Value && x.OrderDate <= dateTimePickerTo.Value).OrderByDescending(x => x.TotalPrice).ToList();
            }
        }
    }
}
