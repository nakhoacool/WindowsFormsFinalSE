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
    public partial class FormAgent : Form
    {

        FinalSE db = new FinalSE();
        
        private void Reload()
        {
            dataGridView_Agent.DataSource = null;
            dataGridView_Agent.DataSource = db.Agents.ToString();
        }
        public FormAgent()
        {
            InitializeComponent();
        }

       

        private void FormAgent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSetAgent.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.finalSEDataSetAgent.Agent);

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.AID = txtID.Text.ToString();
            agent.AName = txtName.Text.ToString();
            agent.PhoneNum = txtPhone.Text.ToString();
            agent.A_Address = txtAddress.Text.ToString();   
            db.Agents.Add(agent);
            db.SaveChanges();
            Reload();
            MessageBox.Show("Agent added successfully");
        }

        private void dataGridView_Agent_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView_Agent.SelectedRows.Count > 0)
            {
                txtID.Text = dataGridView_Agent.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView_Agent.SelectedRows[0].Cells[1].Value.ToString();
                txtPhone.Text = dataGridView_Agent.SelectedRows [0].Cells[2].Value.ToString();
                txtAddress.Text = dataGridView_Agent.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
