using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADW06_TAKEHOME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtProdukSimpan = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        public string selectedCategory = "";
        public string idSelected = "";

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbFilter.Enabled = false;
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            
            dtProdukSimpan.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dtProdukSimpan.Rows.Add("T001", "T-Shirt Black Pink", 70000, 20, "C2");
            dtProdukSimpan.Rows.Add("T002", "T-Shirt Obsessive", 75000, 16, "C2");
            dtProdukSimpan.Rows.Add("R001", "Rok mini", 82000, 26, "C3");
            dtProdukSimpan.Rows.Add("J002", "Jeans Biru ", 90000, 5, "C4");
            dtProdukSimpan.Rows.Add("C001", "Celana Pendek Coklat", 60000, 11, "C4");
            dtProdukSimpan.Rows.Add("C002", "Cawat Blink-blink", 1000000, 1, "C5");
            dtProdukSimpan.Rows.Add("R002", "Rocca Shirt ", 50000, 8, "C2");


            dtCategory.Columns.Add("ID Category", typeof(string));
            dtCategory.Columns.Add("Nama Category", typeof(string));

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");

            cmbFilter.Text = "";

            dtProdukTampil = dtProdukSimpan.Copy();

            dgvCategory.DataSource = dtCategory;
            dgvProdukSimpan.DataSource = dtProdukTampil;

            cmbCategory.DataSource = dtCategory.Copy();
            cmbCategory.DisplayMember = "Nama Category";
            cmbCategory.ValueMember = "ID Category";

            cmbFilter.DataSource = dtCategory.Copy();
            cmbFilter.DisplayMember = "Nama Category";
            cmbFilter.ValueMember = "ID Category";

            dgvCategory.CurrentCell = null;
            dgvProdukSimpan.ClearSelection();
            dgvProdukSimpan.CurrentCell = null;
            cmbCategory.Text = "";
            cmbFilter.Text = "";
        }

        private void buttonAddDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxNamaProduk.Text) || string.IsNullOrEmpty(txtboxHarga.Text) || string.IsNullOrEmpty(txtboxStock.Text) || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("All Fields Need To Be Filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var adaID = dtProdukSimpan.AsEnumerable().Select(roww => roww.Field<string>("ID Product"));
            string firstChar = txtboxNamaProduk.Text.Substring(0, 1).ToUpper();
            int newId = 1;

            foreach (DataRow row1 in dtProdukSimpan.Rows)
            {
                if (row1[0].ToString()[0].ToString() == firstChar)
                {
                    newId++;
                }

            }

            string newIdTampilan = firstChar + newId;
            for (int i = newId.ToString().Length; i < 3; i++)
            {
                firstChar = string.Concat(firstChar, "0");
            }
            firstChar = string.Concat(firstChar, newId.ToString());
            DataRow row = dtProdukSimpan.NewRow();
            row[0] = firstChar;
            row[1] = txtboxNamaProduk.Text;
            row[2] = txtboxHarga.Text;
            row[3] = txtboxStock.Text;
            row[4] = cmbCategory.SelectedValue;
            dtProdukSimpan.Rows.Add(row);
            UpdateData("");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (idSelected == "")
            {
                MessageBox.Show("All Fields Need To Be Filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string newValueNama = txtboxNamaProduk.Text;
                string newValueCategory = cmbCategory.SelectedValue.ToString();
                float newValueHarga = Convert.ToInt64(txtboxHarga.Text);
                int newValueStock = Convert.ToInt32(txtboxStock.Text);
                foreach (DataRow row in dtProdukSimpan.Rows)
                {
                    if (row[0].ToString() != idSelected)
                    {
                        continue;
                    }
                    else
                    {
                        row[1] = newValueNama;
                        row[2] = newValueHarga;
                        row[3] = newValueStock;
                        row[4] = newValueCategory;
                    }

                    if (row[3].ToString() != "0")
                    {
                        continue;
                    }
                    else
                    {
                        dtProdukSimpan.Rows.Remove(row);
                    }

                    UpdateData("");
                    return;
                }
            }
            UpdateData("");
        }

        private void dataGridViewTampil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvProdukSimpan.Rows[e.RowIndex];
            idSelected = row.Cells[0].Value.ToString();
            txtboxNamaProduk.Text = row.Cells[1].Value.ToString();
            txtboxHarga.Text = row.Cells[2].Value.ToString();
            txtboxStock.Text = row.Cells[3].Value.ToString();
            cmbCategory.SelectedValue = row.Cells[4].Value.ToString();
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtboxNamaProduk.Text) || string.IsNullOrEmpty(txtboxHarga.Text) || string.IsNullOrEmpty(txtboxStock.Text) || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please Choose an Item", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow row in dtProdukSimpan.Rows)
            {
                if (row[0].ToString() != idSelected)
                {
                    continue;
                }
                dtProdukSimpan.Rows.Remove(row);
                UpdateData("");
                return;
            }
            UpdateData("");
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string namaCategory = txtboxNamaCategory.Text;
            var adaID = dtCategory.AsEnumerable().Select(row => row.Field<string>("ID Category"));
            bool isAvailable = false;
            foreach (DataRow row in dtCategory.Rows)
            {
                if (txtboxNamaCategory.Text != row[1].ToString())
                {
                    continue;
                }
                isAvailable = true;
            }
            if (isAvailable == true)
            {
                MessageBox.Show("Category Already Exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxNamaCategory.Text = "";
                return;
            }
            string firstChar = "C";
            int newId = 1;

            if (namaCategory == "")
            {
                MessageBox.Show("All Fields Need To Be Filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (adaID.Contains(firstChar + newId))
            {
                newId++;
            }

            string newIdCategory = firstChar + newId;

            DataRow roww = dtCategory.NewRow();
            roww[0] = newIdCategory;
            roww[1] = namaCategory;

            dtCategory.Rows.Add(roww);

            UpdateData("");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string namaCategory = txtboxNamaCategory.Text;
            if (string.IsNullOrEmpty(namaCategory))
            {
                MessageBox.Show("Please choose the category", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataRow row in dtCategory.Rows)
            {
                if (row[0].ToString() != selectedCategory)
                {
                    continue;
                }
                dtCategory.Rows.Remove(row);
                for (int i = dtProdukSimpan.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtProdukSimpan.Rows[i]["ID Category"] == selectedCategory)
                    {
                        dtProdukSimpan.Rows.Remove(dtProdukSimpan.Rows[i]);
                    }
                }
                UpdateData("");
                return;
            }
            for (int i = dtProdukSimpan.Rows.Count - 1; i >= 0; i--)
            {
                if (dtProdukSimpan.Rows[i]["ID Category"] == selectedCategory)
                {
                    dtProdukSimpan.Rows.Remove(dtProdukSimpan.Rows[i]);
                }
            }
            UpdateData("");
        }

        bool select = false;
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            cmbFilter.Enabled = true;
            select = true;
        }

        private void comboBoxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nama = cmbFilter.SelectedValue.ToString();
            foreach (DataRow row in dtCategory.Rows)
            {
                if (row[0].ToString() == nama)
                {
                    nama = row[1].ToString();
                    break;
                }
            }
            UpdateData(cmbFilter.SelectedValue.ToString());
            if (select == true)
            {
                cmbFilter.Text = nama;
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            UpdateData("");
            select = false;
            cmbFilter.Enabled = false;
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategory = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtboxNamaCategory.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void txtBoxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void UpdateData(string value)
        {
            if (value == "")
            {
                dtProdukTampil.Rows.Clear();
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    DataRow row = dtProdukTampil.NewRow();
                    row[0] = dtProdukSimpan.Rows[i][0];
                    row[1] = dtProdukSimpan.Rows[i][1];
                    row[2] = dtProdukSimpan.Rows[i][2];
                    row[3] = dtProdukSimpan.Rows[i][3];
                    row[4] = dtProdukSimpan.Rows[i][4];
                    dtProdukTampil.Rows.Add(row);
                }
            }
            else
            {
                dtProdukTampil.Rows.Clear();
                for (int j = 0; j < dtProdukSimpan.Rows.Count; j++)
                {
                    if (dtProdukSimpan.Rows[j][4].ToString() == value)
                    {
                        DataRow row = dtProdukTampil.NewRow();
                        row[0] = dtProdukSimpan.Rows[j][0];
                        row[1] = dtProdukSimpan.Rows[j][1];
                        row[2] = dtProdukSimpan.Rows[j][2];
                        row[3] = dtProdukSimpan.Rows[j][3];
                        row[4] = dtProdukSimpan.Rows[j][4];
                        dtProdukTampil.Rows.Add(row);
                    }
                }
            }

            dgvProdukSimpan.CurrentCell = null;
            dgvCategory.CurrentCell = null;
            txtboxNamaProduk.Clear();
            txtboxHarga.Clear();
            txtboxStock.Clear();
            idSelected = "";
            selectedCategory = "";
            cmbCategory.DataSource = dtCategory.Copy();
            cmbFilter.DataSource = dtCategory.Copy();
            cmbCategory.Text = "";
            cmbFilter.Text = "";
            txtboxNamaCategory.Text = "";
        }
    }
}