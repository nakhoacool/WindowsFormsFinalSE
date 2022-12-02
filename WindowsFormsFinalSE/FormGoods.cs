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
        public FormGoods()
        {
            InitializeComponent();
        }

        private void FormGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSet2.Import' table. You can move, or remove it, as needed.
            this.importTableAdapter.Fill(this.finalSEDataSet2.Import);
            // TODO: This line of code loads data into the 'finalSEDataSet1.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.finalSEDataSet1.Good);

        }
    }
}
