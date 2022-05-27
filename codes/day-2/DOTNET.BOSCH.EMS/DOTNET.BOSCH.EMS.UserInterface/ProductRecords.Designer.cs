
namespace DOTNET.BOSCH.EMS.UserInterface
{
    partial class ProductRecords
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.columnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(534, 57);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 38);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Products";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductId,
            this.columnProductName,
            this.columnDesc,
            this.columnPrice,
            this.columnCategoryId});
            this.dgvProducts.Location = new System.Drawing.Point(36, 99);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1077, 320);
            this.dgvProducts.TabIndex = 1;
            // 
            // columnProductId
            // 
            this.columnProductId.DataPropertyName = "Id";
            this.columnProductId.HeaderText = "ID";
            this.columnProductId.MinimumWidth = 6;
            this.columnProductId.Name = "columnProductId";
            this.columnProductId.Width = 125;
            // 
            // columnProductName
            // 
            this.columnProductName.DataPropertyName = "Name";
            this.columnProductName.HeaderText = "NAME";
            this.columnProductName.MinimumWidth = 6;
            this.columnProductName.Name = "columnProductName";
            this.columnProductName.Width = 125;
            // 
            // columnDesc
            // 
            this.columnDesc.DataPropertyName = "Description";
            this.columnDesc.HeaderText = "DESCRIPTION";
            this.columnDesc.MinimumWidth = 6;
            this.columnDesc.Name = "columnDesc";
            this.columnDesc.Width = 125;
            // 
            // columnPrice
            // 
            this.columnPrice.DataPropertyName = "Price";
            this.columnPrice.HeaderText = "PRICE";
            this.columnPrice.MinimumWidth = 6;
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.Width = 125;
            // 
            // columnCategoryId
            // 
            this.columnCategoryId.DataPropertyName = "CategoryId";
            this.columnCategoryId.HeaderText = "CATEGORY ID";
            this.columnCategoryId.MinimumWidth = 6;
            this.columnCategoryId.Name = "columnCategoryId";
            this.columnCategoryId.Width = 125;
            // 
            // comboCategories
            // 
            this.comboCategories.BackColor = System.Drawing.SystemColors.Info;
            this.comboCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategories.FormattingEnabled = true;
            this.comboCategories.Location = new System.Drawing.Point(193, 57);
            this.comboCategories.Name = "comboCategories";
            this.comboCategories.Size = new System.Drawing.Size(283, 26);
            this.comboCategories.TabIndex = 2;
            this.comboCategories.SelectedIndexChanged += new System.EventHandler(this.comboCategories_SelectedIndexChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(67, 59);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(120, 17);
            this.lblCategories.TabIndex = 3;
            this.lblCategories.Text = "Select a Category";
            // 
            // ProductRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 547);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.comboCategories);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnLoad);
            this.Name = "ProductRecords";
            this.Text = "ProductRecords";
            this.Load += new System.EventHandler(this.ProductRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategoryId;
        private System.Windows.Forms.ComboBox comboCategories;
        private System.Windows.Forms.Label lblCategories;
    }
}