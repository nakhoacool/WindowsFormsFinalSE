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
            // TODO: This line of code loads data into the 'goodimportDataSet.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.goodimportDataSet.Good);
            // TODO: This line of code loads data into the 'accoutantimportDataset.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.accoutantimportDataset.Accountant);
            // TODO: This line of code loads data into the 'accoutantimportDataset.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.accoutantimportDataset.Accountant);
            // TODO: This line of code loads data into the 'goodimportDataSet.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.goodimportDataSet.Good);
      
            // TODO: This line of code loads data into the 'importDataSet.Import' table. You can move, or remove it, as needed.
            this.importTableAdapter.Fill(this.importDataSet.Import);
            comboBoxID.SelectedIndex = -1;
            comboBoxGID.SelectedIndex = -1;

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

        private void txtGName_TextChanged(object sender, EventArgs e)
        {
            Good good = new Good();
            String str = this.comboBoxGID.GetItemText(this.comboBoxGID.SelectedItem);

            if(comboBoxGID.Text == "") { txtGName.Text = ""; }

            else
            {
                good = (Good)db.Goods.Find(str);
                txtGName.Text = good.GName;
            }
        }
    }
}
