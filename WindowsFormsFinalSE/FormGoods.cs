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
    public partial class FormGoods : Form
    {
        FinalSE db = new FinalSE();
        public FormGoods()
        {
            InitializeComponent();
        }

        private void FormGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSet5.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.finalSEDataSet5.Good);
            // TODO: This line of code loads data into the 'finalSEDataSet4.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.finalSEDataSet4.Accountant);
            // TODO: This line of code loads data into the 'finalSEDataSet3.Import' table. You can move, or remove it, as needed.
            this.importTableAdapter.Fill(this.finalSEDataSet3.Import);


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.accountantTableAdapter.FillBy(this.finalSEDataSet4.Accountant);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
