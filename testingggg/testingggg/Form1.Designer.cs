namespace ADW06_TAKEHOME
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProdukSimpan = new System.Windows.Forms.DataGridView();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.labelDetail = new System.Windows.Forms.Label();
            this.labelNamaProduct = new System.Windows.Forms.Label();
            this.labelCategoryDetails = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.txtboxNamaProduk = new System.Windows.Forms.TextBox();
            this.txtboxHarga = new System.Windows.Forms.TextBox();
            this.txtboxStock = new System.Windows.Forms.TextBox();
            this.buttonAddDetails = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.labelNamaCategory = new System.Windows.Forms.Label();
            this.txtboxNamaCategory = new System.Windows.Forms.TextBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdukSimpan
            // 
            this.dgvProdukSimpan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdukSimpan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukSimpan.Location = new System.Drawing.Point(18, 91);
            this.dgvProdukSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProdukSimpan.Name = "dgvProdukSimpan";
            this.dgvProdukSimpan.RowHeadersWidth = 62;
            this.dgvProdukSimpan.Size = new System.Drawing.Size(752, 306);
            this.dgvProdukSimpan.TabIndex = 0;
            this.dgvProdukSimpan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTampil_CellClick);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(820, 91);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 62;
            this.dgvCategory.Size = new System.Drawing.Size(360, 231);
            this.dgvCategory.TabIndex = 1;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Euclid Circular B SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(13, 35);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(139, 41);
            this.labelProduct.TabIndex = 2;
            this.labelProduct.Text = "Product";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Euclid Circular B Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(815, 35);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(171, 41);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Purple;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(430, 51);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(64, 35);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Turquoise;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(502, 51);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 35);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(590, 51);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(180, 28);
            this.cmbFilter.TabIndex = 6;
            this.cmbFilter.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFilter_SelectionChangeCommitted);
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Font = new System.Drawing.Font("Euclid Circular B Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetail.Location = new System.Drawing.Point(21, 414);
            this.labelDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(131, 41);
            this.labelDetail.TabIndex = 7;
            this.labelDetail.Text = "Details";
            // 
            // labelNamaProduct
            // 
            this.labelNamaProduct.AutoSize = true;
            this.labelNamaProduct.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaProduct.Location = new System.Drawing.Point(13, 484);
            this.labelNamaProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaProduct.Name = "labelNamaProduct";
            this.labelNamaProduct.Size = new System.Drawing.Size(142, 20);
            this.labelNamaProduct.TabIndex = 8;
            this.labelNamaProduct.Text = "Nama Product :";
            // 
            // labelCategoryDetails
            // 
            this.labelCategoryDetails.AutoSize = true;
            this.labelCategoryDetails.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryDetails.Location = new System.Drawing.Point(50, 523);
            this.labelCategoryDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoryDetails.Name = "labelCategoryDetails";
            this.labelCategoryDetails.Size = new System.Drawing.Size(100, 20);
            this.labelCategoryDetails.TabIndex = 9;
            this.labelCategoryDetails.Text = "Category :";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(75, 568);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(73, 20);
            this.labelHarga.TabIndex = 10;
            this.labelHarga.Text = "Harga :";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(75, 616);
            this.labelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(68, 20);
            this.labelStock.TabIndex = 11;
            this.labelStock.Text = "Stock :";
            // 
            // txtboxNamaProduk
            // 
            this.txtboxNamaProduk.Location = new System.Drawing.Point(171, 481);
            this.txtboxNamaProduk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxNamaProduk.Name = "txtboxNamaProduk";
            this.txtboxNamaProduk.Size = new System.Drawing.Size(418, 26);
            this.txtboxNamaProduk.TabIndex = 12;
            // 
            // txtboxHarga
            // 
            this.txtboxHarga.Location = new System.Drawing.Point(171, 565);
            this.txtboxHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxHarga.Name = "txtboxHarga";
            this.txtboxHarga.Size = new System.Drawing.Size(180, 26);
            this.txtboxHarga.TabIndex = 14;
            this.txtboxHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxHarga_KeyPress);
            // 
            // txtboxStock
            // 
            this.txtboxStock.Location = new System.Drawing.Point(171, 616);
            this.txtboxStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxStock.Name = "txtboxStock";
            this.txtboxStock.Size = new System.Drawing.Size(180, 26);
            this.txtboxStock.TabIndex = 15;
            this.txtboxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxStock_KeyPress);
            // 
            // buttonAddDetails
            // 
            this.buttonAddDetails.BackColor = System.Drawing.Color.Green;
            this.buttonAddDetails.FlatAppearance.BorderSize = 0;
            this.buttonAddDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDetails.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDetails.ForeColor = System.Drawing.Color.White;
            this.buttonAddDetails.Location = new System.Drawing.Point(414, 566);
            this.buttonAddDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddDetails.Name = "buttonAddDetails";
            this.buttonAddDetails.Size = new System.Drawing.Size(110, 72);
            this.buttonAddDetails.TabIndex = 16;
            this.buttonAddDetails.Text = "Add Product";
            this.buttonAddDetails.UseVisualStyleBackColor = false;
            this.buttonAddDetails.Click += new System.EventHandler(this.buttonAddDetails_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Yellow;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(532, 566);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 72);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Update Product";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveProduct.FlatAppearance.BorderSize = 0;
            this.buttonRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveProduct.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveProduct.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveProduct.Location = new System.Drawing.Point(651, 564);
            this.buttonRemoveProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(119, 72);
            this.buttonRemoveProduct.TabIndex = 18;
            this.buttonRemoveProduct.Text = "Remove Product";
            this.buttonRemoveProduct.UseVisualStyleBackColor = false;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // labelNamaCategory
            // 
            this.labelNamaCategory.AutoSize = true;
            this.labelNamaCategory.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaCategory.Location = new System.Drawing.Point(793, 355);
            this.labelNamaCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaCategory.Name = "labelNamaCategory";
            this.labelNamaCategory.Size = new System.Drawing.Size(156, 20);
            this.labelNamaCategory.TabIndex = 19;
            this.labelNamaCategory.Text = "Nama Category :";
            // 
            // txtboxNamaCategory
            // 
            this.txtboxNamaCategory.Location = new System.Drawing.Point(979, 355);
            this.txtboxNamaCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxNamaCategory.Name = "txtboxNamaCategory";
            this.txtboxNamaCategory.Size = new System.Drawing.Size(201, 26);
            this.txtboxNamaCategory.TabIndex = 20;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.Green;
            this.buttonAddCategory.FlatAppearance.BorderSize = 0;
            this.buttonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategory.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCategory.ForeColor = System.Drawing.Color.White;
            this.buttonAddCategory.Location = new System.Drawing.Point(946, 414);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(112, 68);
            this.buttonAddCategory.TabIndex = 21;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Euclid Circular B Medium", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(1070, 414);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(112, 68);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove Category";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(171, 524);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 28);
            this.cmbCategory.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1205, 692);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.txtboxNamaCategory);
            this.Controls.Add(this.labelNamaCategory);
            this.Controls.Add(this.buttonRemoveProduct);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAddDetails);
            this.Controls.Add(this.txtboxStock);
            this.Controls.Add(this.txtboxHarga);
            this.Controls.Add(this.txtboxNamaProduk);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelCategoryDetails);
            this.Controls.Add(this.labelNamaProduct);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.dgvProdukSimpan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdukSimpan;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label labelNamaProduct;
        private System.Windows.Forms.Label labelCategoryDetails;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox txtboxNamaProduk;
        private System.Windows.Forms.TextBox txtboxHarga;
        private System.Windows.Forms.TextBox txtboxStock;
        private System.Windows.Forms.Button buttonAddDetails;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.Label labelNamaCategory;
        private System.Windows.Forms.TextBox txtboxNamaCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}
