using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFinalSE
{
    public partial class FormGoods : Form
    {
        FinalSE db = new FinalSE();

        private void Reload()
        {
            goodGridView.DataSource = null;
            goodGridView.DataSource = db.Goods.ToList();
        }

        private byte[] ConvertImagetoByte(string path)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(path);
            long numBytes = fInfo.Length;
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fileStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private Image ConvertBytetoImage(byte[] data)
        {
            Image image;
            using (MemoryStream ms = new MemoryStream(data, 0, data.Length))
            {
                ms.Write(data, 0, data.Length);
                image = Image.FromStream(ms, true);
            }
            return image;
        }

        public FormGoods()
        {
            InitializeComponent();
            buttonGoodSave.Enabled = true;
            buttonGoodClear.Enabled = true;
            buttonGoodDelete.Enabled = false;
            buttonGoodEdit.Enabled = false;
        }

        private void FormGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSEDataSetGood.Good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.finalSEDataSetGood.Good);
        }

        private void buttonGoodBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse Image Files";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxGoodPhoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void buttonGoodSave_Click(object sender, EventArgs e)
        {
            Good good = new Good();
            good.GID = textBoxGoodID.Text.ToString();
            good.GName = textBoxGoodName.Text.ToString();
            good.Quantity = int.Parse(textBoxGoodQuantity.Text.ToString());
            good.Manufacture = textBoxGoodManu.Text.ToString();
            good.ImportPrice = int.Parse(textBoxGoodImpPrice.Text.ToString());
            good.SellingPrice = int.Parse(textBoxGoodSell.Text.ToString());
            good.GPhoto = ConvertImagetoByte(pictureBoxGoodPhoto.ImageLocation);
            db.Goods.Add(good);
            db.SaveChanges();
            Reload();
            MessageBox.Show("Good added successfully");
            Class.Clear.ResetAllControls(this);
        }

        private void goodGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (goodGridView.SelectedRows.Count > 0)
            {
                textBoxGoodID.Text = goodGridView.SelectedRows[0].Cells[0].Value.ToString();
                textBoxGoodName.Text = goodGridView.SelectedRows[0].Cells[1].Value.ToString();
                textBoxGoodQuantity.Text = goodGridView.SelectedRows[0].Cells[2].Value.ToString();
                textBoxGoodManu.Text = goodGridView.SelectedRows[0].Cells[3].Value.ToString();
                textBoxGoodImpPrice.Text = goodGridView.SelectedRows[0].Cells[4].Value.ToString();
                textBoxGoodSell.Text = goodGridView.SelectedRows[0].Cells[5].Value.ToString();
                pictureBoxGoodPhoto.Image = ConvertBytetoImage((byte[])goodGridView.SelectedRows[0].Cells[6].Value);

                buttonGoodSave.Enabled = false;
                buttonGoodDelete.Enabled = true;
                buttonGoodEdit.Enabled = true;
            }
        }

        private void buttonGoodDelete_Click(object sender, EventArgs e)
        {
            string id = textBoxGoodID.Text.ToString();
            Good good = db.Goods.Find(id);
            db.Goods.Remove(good);
            db.SaveChanges();
            Reload();
            MessageBox.Show("Good deleted successfully");
            Class.Clear.ResetAllControls(this);
        }

        private void buttonGoodClear_Click(object sender, EventArgs e)
        {
            Class.Clear.ResetAllControls(this);
            Reload();
            buttonGoodSave.Enabled = true;
            buttonGoodDelete.Enabled = false;
            buttonGoodEdit.Enabled = false;
        }

        private void buttonGoodEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxGoodID.Text.ToString();
            Good good = db.Goods.Find(id);
            good.GID = textBoxGoodID.Text.ToString();
            good.GName = textBoxGoodName.Text.ToString();
            good.Quantity = int.Parse(textBoxGoodQuantity.Text.ToString());
            good.Manufacture = textBoxGoodManu.Text.ToString();
            good.ImportPrice = int.Parse(textBoxGoodImpPrice.Text.ToString());
            good.SellingPrice = int.Parse(textBoxGoodSell.Text.ToString());
            if (pictureBoxGoodPhoto.ImageLocation != null)
            {
                good.GPhoto = ConvertImagetoByte(pictureBoxGoodPhoto.ImageLocation);
            }
            db.SaveChanges();
            Reload();
            MessageBox.Show("Good updated successfully");
            Class.Clear.ResetAllControls(this);
        }

        private void buttonGoodSearch_Click(object sender, EventArgs e)
        {
            if (textBoxGoodID.Text != "")
            {
                goodGridView.DataSource = null;
                goodGridView.DataSource = db.Goods.Where(x => x.GID == textBoxGoodID.Text).ToList();
            }
            else if (textBoxGoodName.Text != "")
            {
                goodGridView.DataSource = null;
                goodGridView.DataSource = db.Goods.Where(x => x.GName == textBoxGoodName.Text || x.GName.Contains(textBoxGoodName.Text)).ToList();
            }
            else if (textBoxGoodQuantity.Text != "")
            {
                goodGridView.DataSource = null;
                goodGridView.DataSource = db.Goods.Where(x => x.Quantity == int.Parse(textBoxGoodQuantity.Text)).ToList();
            }
            else if (textBoxGoodManu.Text != "")
            {
                goodGridView.DataSource = null;
                goodGridView.DataSource = db.Goods.Where(x => x.Manufacture == textBoxGoodManu.Text || x.Manufacture.Contains(textBoxGoodManu.Text)).ToList();
            }
            else if (textBoxGoodImpPrice.Text != "")
            {
                goodGridView.DataSource = null;
                goodGridView.DataSource = db.Goods.Where(x => x.ImportPrice == int.Parse(textBoxGoodImpPrice.Text)).ToList();
            }
            else if (textBoxGoodSell.Text != "")
            {
                goodGridView.DataSource = null;
                goodGridView.DataSource = db.Goods.Where(x => x.SellingPrice == int.Parse(textBoxGoodSell.Text)).ToList();
            }
            else
            {
                Reload();
            }
        }
    }
}
