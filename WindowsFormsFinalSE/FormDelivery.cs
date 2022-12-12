using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsFinalSE
{
    public partial class FormDelivery : Form
    {
        FinalSE db = new FinalSE();
        public FormDelivery()
        {
            InitializeComponent();
            comboBoxStatus.Enabled = false;
            dataGridViewNote.DataSource = db.Deliveries.ToList();
        }
        
        private void Reload()
        {
            dataGridViewNote.DataSource = null;
            dataGridViewNote.DataSource = db.Deliveries.ToList();
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSetNote.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.finalSEDataSetNote.Delivery);

        }

        private void dataGridViewNote_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNote.SelectedRows.Count == 0)
            {
                return;
            }
            comboBoxStatus.Enabled = true;
            int index = dataGridViewNote.SelectedRows[0].Index;
            txtDeliveryID.Text = (String)dataGridViewNote.Rows[index].Cells[0].Value;
            txtAID.Text = (String)dataGridViewNote.Rows[index].Cells[1].Value;
            txtOID.Text = (String)dataGridViewNote.Rows[index].Cells[2].Value;
            txtPaymentStatus.Text = (String)dataGridViewNote.Rows[index].Cells[4].Value;

            comboBoxStatus.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Delivery delivery = db.Deliveries.Find(txtDeliveryID.Text);
            delivery.GoodsStatus = comboBoxStatus.Text;
            db.SaveChanges();
            Reload();
            txtDeliveryID.Clear();
            txtAID.Clear();
            txtOID.Clear();
            txtPaymentStatus.Clear();
            comboBoxStatus.SelectedIndex = -1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                MessageBox.Show("Please enter Delivery ID");
                return;
            }
            else
            {
                Delivery delivery = db.Deliveries.Find(txtFind.Text);
                if (delivery == null)
                {
                    MessageBox.Show("Delivery ID not found");
                    return;
                }
                else
                {
                    dataGridViewNote.DataSource = null;
                    dataGridViewNote.DataSource = db.Deliveries.Where(x => x.DeliveryID == txtFind.Text).ToList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                string id = txtDeliveryID.Text.ToString();
                Delivery delivery = db.Deliveries.Find(id);
                db.Deliveries.Remove(delivery);
                db.SaveChanges();
                Reload();
                MessageBox.Show("Delivery deleted successfully");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 0; i <= dataGridViewNote.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridViewNote.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridViewNote[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            xlWorkBook.SaveAs("DeliveryNote.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file \"\\Documents\\DeliveryNote.xls\"");
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
    
}
