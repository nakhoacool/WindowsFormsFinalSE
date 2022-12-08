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
    public partial class FormImport : Form
    {
        FinalSE db = new FinalSE();
        public FormImport()
        {
            InitializeComponent();
            
           
        }

        private void FormGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSetImport.Import' table. You can move, or remove it, as needed.
            this.importTableAdapter.Fill(this.finalSEDataSetImport.Import);
            // TODO: This line of code loads data into the 'goodimportDataSet.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.goodimportDataSet.Good);
            // TODO: This line of code loads data into the 'accoutantimportDataset.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.accoutantimportDataset.Accountant);
            // TODO: This line of code loads data into the 'accoutantimportDataset.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.accoutantimportDataset.Accountant);
            // TODO: This line of code loads data into the 'goodimportDataSet.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.goodimportDataSet.Good);
      
            
            comboBoxID.SelectedIndex = -1;
            comboBoxGID.SelectedIndex = -1;

        }

       
        private void Reload()
        {
            ImportGridView.DataSource = null;
            ImportGridView.DataSource = db.Imports.ToList();
        }
       
        private void Import_addGrid(String ID, String GID, String Quantity, int totalPrice) 
        {
            //try
            //{

            ImportGridView.Rows.Add(ID, GID, Quantity, totalPrice);
            //}
           
        }
        

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Accountant accountant = new Accountant();
            String str = this.comboBoxID.GetItemText(this.comboBoxID.SelectedItem);

            if (comboBoxID.Text == "") { txtName.Text = ""; }

            else {
                accountant = (Accountant) db.Accountants.Find(str);
                txtName.Text = accountant.AName;
            }
                
        }

        private void comboBoxGID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Good good = new Good();
            String str = this.comboBoxGID.GetItemText(this.comboBoxGID.SelectedItem);

            if (comboBoxGID.Text == "") { txtGName.Text = ""; }

            else
            {
                good = (Good)db.Goods.Find(str);
                txtGName.Text = good.GName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxID.Text == "" || comboBoxGID.Text == "" || txtQuantity.Text == "" || txtImportID.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                Good good = db.Goods.Find(comboBoxGID.Text);
                int importprice = (int)((int)good.SellingPrice * 0.75);
                int totalprice = importprice * int.Parse(txtQuantity.Text.ToString());
                Import_addGrid(comboBoxID.Text, comboBoxGID.Text, txtQuantity.Text, totalprice);
               
                //show datagridview
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            if (ImportGridView.DataBindings.Count == 0)
            {
                MessageBox.Show("Add goods before import");
            }

            else
            {
                import.ImportID = txtImportID.Text.ToString();
                import.ID = comboBoxID.Text.ToString();
                import.GID = comboBoxGID.Text.ToString();
                import.Quantity = int.Parse(txtQuantity.Text.ToString());
                import.ImportDate = dateTimePickerImport.Value;
                import.totalPrice = int.Parse(txtTotalPrice.Text.ToString());
                db.SaveChanges();
                MessageBox.Show("Import successfully");
                ImportGridView.DataSource = null;
                Class.Clear.ResetAllControls(this);
            }
        }
    }
}
