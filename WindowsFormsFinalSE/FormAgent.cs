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

        public FormAgent()
        {
            InitializeComponent();
            btn_Add.Enabled = true;
            btn_Clear.Enabled = true;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
        }

        private void Reload()
        {
            dataGridView_Agent.DataSource = null;
            dataGridView_Agent.DataSource = db.Agents.ToList();
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
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this Agent?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string id = txtID.Text.ToString();
                Agent agent = db.Agents.Find(id);
                db.Agents.Remove(agent);
                db.SaveChanges();
                Reload();
                MessageBox.Show("Agent deleted successfully!");
                txtID.Text = "";
                txtName.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
            }
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Agent agent = db.Agents.Find(txtID.Text);
            agent.AName = txtName.Text.ToString();
            agent.PhoneNum = txtPhone.Text.ToString();
            agent.A_Address = txtAddress.Text.ToString();
            db.SaveChanges();
            Reload();
            MessageBox.Show("Agent edited!");
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            Reload();
            btn_Add.Enabled = true;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                dataGridView_Agent.DataSource = null;
                dataGridView_Agent.DataSource = db.Agents.Where(x => x.AID == txtID.Text).ToList();
            }
            else if (txtName.Text != "")
            {
                dataGridView_Agent.DataSource = null;
                dataGridView_Agent.DataSource = db.Agents.Where(x => x.AName == txtName.Text).ToList();
            }
            else if (txtPhone.Text != "")
            {
                dataGridView_Agent.DataSource = null;
                dataGridView_Agent.DataSource = db.Agents.Where(x => x.PhoneNum == txtPhone.Text).ToList();
            }
            else if (txtAddress.Text != "")
            {
                dataGridView_Agent.DataSource = null;
                dataGridView_Agent.DataSource = db.Agents.Where(x => x.A_Address == txtAddress.Text).ToList();
            }
            else
            {
                dataGridView_Agent.DataSource = null;
                dataGridView_Agent.DataSource = db.Agents.ToList();
            }
        }

        private void dataGridView_Agent_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Agent.SelectedRows.Count > 0)
            {
                txtID.Text = dataGridView_Agent.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGridView_Agent.SelectedRows[0].Cells[1].Value.ToString();
                txtPhone.Text = dataGridView_Agent.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text = dataGridView_Agent.SelectedRows[0].Cells[3].Value.ToString();

                btn_Add.Enabled = false;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
            }
        }
    }
}
