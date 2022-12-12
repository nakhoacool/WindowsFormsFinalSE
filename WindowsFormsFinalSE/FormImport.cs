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

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = false;

            comboBoxGID.Enabled = false;

            txtQuantity.Enabled = false;

        }

        private void FormGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSetImport.ImportDetail' table. You can move, or remove it, as needed.
            this.importDetailTableAdapter.Fill(this.finalSEDataSetImport.ImportDetail);

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



        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Accountant accountant = new Accountant();
            String str = this.comboBoxID.GetItemText(this.comboBoxID.SelectedItem);

            if (comboBoxID.Text == "") { txtName.Text = ""; }

            else
            {
                accountant = (Accountant)db.Accountants.Find(str);
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
            if (comboBoxID.Text == "" || comboBoxGID.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                Good good = db.Goods.Find(comboBoxGID.Text);
                int importprice = (int)good.ImportPrice;
                int totalprice = importprice * int.Parse(txtQuantity.Text.ToString());

                ImportDetail importDetail = new ImportDetail();
                importDetail.ImportID = txtImportID.Text;
                importDetail.GID = comboBoxGID.Text;
                importDetail.Quantity = Convert.ToInt32(txtQuantity.Text);
                importDetail.price = totalprice;




                txtTotalPrice.Text = (int.Parse(txtTotalPrice.Text.ToString()) + totalprice).ToString();


                db.ImportDetails.Add(importDetail);

                db.SaveChanges();

                MessageBox.Show("Import Detail Added Successfully");


                comboBoxGID.SelectedIndex = -1;
                txtQuantity.Text = "";



                ImportGridView.DataSource = null;
                ImportGridView.DataSource = db.ImportDetails.ToList();
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

        }

        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnNew, "Please choose Accountant ID, fill ImportID field and Date to create new import note.");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxID.Text == "" || dateTimePickerImport.Text == "" || txtImportID.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                }

                else
                {
                    Import import = new Import();
                    import.ImportID = txtImportID.Text.ToString();
                    import.ID = comboBoxID.Text.ToString();
                    import.ImportDate = dateTimePickerImport.Value;
                    import.totalPrice = 0;
                    txtTotalPrice.Text = import.totalPrice.ToString();
                    db.Imports.Add(import);
                    db.SaveChanges();
                    MessageBox.Show("Adding successfully");
                    Reload();
                    /*Class.Clear.ResetAllControls(this);*/

                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnClear.Enabled = true;
                    btnSave.Enabled = true;
                    btnNew.Enabled = false;

                    txtQuantity.Enabled = true;
                    txtImportID.Enabled = false;

                    comboBoxID.Enabled = false;
                    comboBoxGID.Enabled = true;

                    dateTimePickerImport.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Import import = db.Imports.Find(txtImportID.Text);
            import.totalPrice = int.Parse(txtTotalPrice.Text.ToString());

            foreach (ImportDetail importDetail in db.ImportDetails)
            {
                if (importDetail.ImportID == txtImportID.Text)
                {
                    Good good = db.Goods.Find(importDetail.GID);
                    good.Quantity += importDetail.Quantity;
                }
            }

            db.SaveChanges();
            Reload();
            MessageBox.Show("Import note saved successfully");
            Class.Clear.ResetAllControls(this);
            txtImportID.Clear();
            comboBoxID.Text = "";
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = false;

            comboBoxGID.Enabled = false;

            txtQuantity.Enabled = false;

            btnNew.Enabled = true;
            comboBoxID.Enabled = true;
            dateTimePickerImport.Enabled = true;

            txtImportID.Enabled = true;
        }


    }
}
