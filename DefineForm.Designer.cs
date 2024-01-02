namespace StockManager1_0
{
    partial class DefineForm
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.supplierPanel = new System.Windows.Forms.Panel();
            this.sAddButton = new System.Windows.Forms.Button();
            this.sContactBox = new System.Windows.Forms.TextBox();
            this.sContactLabel = new System.Windows.Forms.Label();
            this.sNameBox = new System.Windows.Forms.TextBox();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.manufacturerPanel = new System.Windows.Forms.Panel();
            this.mAddButton = new System.Windows.Forms.Button();
            this.mContactBox = new System.Windows.Forms.TextBox();
            this.mContactLabel = new System.Windows.Forms.Label();
            this.mNameBox = new System.Windows.Forms.TextBox();
            this.mNameLabel = new System.Windows.Forms.Label();
            this.brandPanel = new System.Windows.Forms.Panel();
            this.bAddButton = new System.Windows.Forms.Button();
            this.bSupplierBox = new System.Windows.Forms.ListBox();
            this.bSupplierLabel = new System.Windows.Forms.Label();
            this.bManufacturerBox = new System.Windows.Forms.ListBox();
            this.bManufacturerLabel = new System.Windows.Forms.Label();
            this.bNameBox = new System.Windows.Forms.TextBox();
            this.bNameLabel = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.pAddButton = new System.Windows.Forms.Button();
            this.pPriceBox = new System.Windows.Forms.NumericUpDown();
            this.pPriceLabel = new System.Windows.Forms.Label();
            this.pCostBox = new System.Windows.Forms.NumericUpDown();
            this.pCostLabel = new System.Windows.Forms.Label();
            this.pBrandBox = new System.Windows.Forms.ListBox();
            this.pBrandLabel = new System.Windows.Forms.Label();
            this.pNameBox = new System.Windows.Forms.TextBox();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.supplierPanel.SuspendLayout();
            this.manufacturerPanel.SuspendLayout();
            this.brandPanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCostBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayout.Controls.Add(this.supplierPanel, 2, 2);
            this.mainLayout.Controls.Add(this.manufacturerPanel, 2, 1);
            this.mainLayout.Controls.Add(this.brandPanel, 1, 1);
            this.mainLayout.Controls.Add(this.productPanel, 0, 1);
            this.mainLayout.Controls.Add(this.closeButton, 1, 3);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.Size = new System.Drawing.Size(624, 450);
            this.mainLayout.TabIndex = 0;
            // 
            // supplierPanel
            // 
            this.supplierPanel.Controls.Add(this.sAddButton);
            this.supplierPanel.Controls.Add(this.sContactBox);
            this.supplierPanel.Controls.Add(this.sContactLabel);
            this.supplierPanel.Controls.Add(this.sNameBox);
            this.supplierPanel.Controls.Add(this.sNameLabel);
            this.supplierPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierPanel.Location = new System.Drawing.Point(439, 228);
            this.supplierPanel.Name = "supplierPanel";
            this.supplierPanel.Size = new System.Drawing.Size(182, 174);
            this.supplierPanel.TabIndex = 3;
            // 
            // sAddButton
            // 
            this.sAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sAddButton.Location = new System.Drawing.Point(2, 136);
            this.sAddButton.Name = "sAddButton";
            this.sAddButton.Size = new System.Drawing.Size(176, 36);
            this.sAddButton.TabIndex = 11;
            this.sAddButton.Text = "New Supplier";
            this.sAddButton.UseVisualStyleBackColor = true;
            this.sAddButton.Click += new System.EventHandler(this.AddSupplierClick);
            // 
            // sContactBox
            // 
            this.sContactBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sContactBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sContactBox.Location = new System.Drawing.Point(2, 84);
            this.sContactBox.MaxLength = 32;
            this.sContactBox.Name = "sContactBox";
            this.sContactBox.Size = new System.Drawing.Size(176, 26);
            this.sContactBox.TabIndex = 6;
            // 
            // sContactLabel
            // 
            this.sContactLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sContactLabel.AutoSize = true;
            this.sContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sContactLabel.Location = new System.Drawing.Point(2, 60);
            this.sContactLabel.Name = "sContactLabel";
            this.sContactLabel.Size = new System.Drawing.Size(97, 20);
            this.sContactLabel.TabIndex = 5;
            this.sContactLabel.Text = "Contact Info";
            // 
            // sNameBox
            // 
            this.sNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sNameBox.Location = new System.Drawing.Point(2, 28);
            this.sNameBox.MaxLength = 32;
            this.sNameBox.Name = "sNameBox";
            this.sNameBox.Size = new System.Drawing.Size(176, 26);
            this.sNameBox.TabIndex = 4;
            // 
            // sNameLabel
            // 
            this.sNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sNameLabel.Location = new System.Drawing.Point(2, 4);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(113, 20);
            this.sNameLabel.TabIndex = 3;
            this.sNameLabel.Text = "Supplier Name";
            // 
            // manufacturerPanel
            // 
            this.manufacturerPanel.Controls.Add(this.mAddButton);
            this.manufacturerPanel.Controls.Add(this.mContactBox);
            this.manufacturerPanel.Controls.Add(this.mContactLabel);
            this.manufacturerPanel.Controls.Add(this.mNameBox);
            this.manufacturerPanel.Controls.Add(this.mNameLabel);
            this.manufacturerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manufacturerPanel.Location = new System.Drawing.Point(439, 48);
            this.manufacturerPanel.Name = "manufacturerPanel";
            this.manufacturerPanel.Size = new System.Drawing.Size(182, 174);
            this.manufacturerPanel.TabIndex = 2;
            // 
            // mAddButton
            // 
            this.mAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mAddButton.Location = new System.Drawing.Point(2, 136);
            this.mAddButton.Name = "mAddButton";
            this.mAddButton.Size = new System.Drawing.Size(176, 36);
            this.mAddButton.TabIndex = 10;
            this.mAddButton.Text = "New Manufacturer";
            this.mAddButton.UseVisualStyleBackColor = true;
            this.mAddButton.Click += new System.EventHandler(this.AddManufacturerClick);
            // 
            // mContactBox
            // 
            this.mContactBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mContactBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mContactBox.Location = new System.Drawing.Point(2, 84);
            this.mContactBox.MaxLength = 32;
            this.mContactBox.Name = "mContactBox";
            this.mContactBox.Size = new System.Drawing.Size(176, 26);
            this.mContactBox.TabIndex = 5;
            // 
            // mContactLabel
            // 
            this.mContactLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mContactLabel.AutoSize = true;
            this.mContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mContactLabel.Location = new System.Drawing.Point(2, 60);
            this.mContactLabel.Name = "mContactLabel";
            this.mContactLabel.Size = new System.Drawing.Size(97, 20);
            this.mContactLabel.TabIndex = 4;
            this.mContactLabel.Text = "Contact Info";
            // 
            // mNameBox
            // 
            this.mNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mNameBox.Location = new System.Drawing.Point(2, 28);
            this.mNameBox.MaxLength = 32;
            this.mNameBox.Name = "mNameBox";
            this.mNameBox.Size = new System.Drawing.Size(176, 26);
            this.mNameBox.TabIndex = 3;
            // 
            // mNameLabel
            // 
            this.mNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mNameLabel.AutoSize = true;
            this.mNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mNameLabel.Location = new System.Drawing.Point(2, 4);
            this.mNameLabel.Name = "mNameLabel";
            this.mNameLabel.Size = new System.Drawing.Size(150, 20);
            this.mNameLabel.TabIndex = 2;
            this.mNameLabel.Text = "Manufacturer Name";
            // 
            // brandPanel
            // 
            this.brandPanel.Controls.Add(this.bAddButton);
            this.brandPanel.Controls.Add(this.bSupplierBox);
            this.brandPanel.Controls.Add(this.bSupplierLabel);
            this.brandPanel.Controls.Add(this.bManufacturerBox);
            this.brandPanel.Controls.Add(this.bManufacturerLabel);
            this.brandPanel.Controls.Add(this.bNameBox);
            this.brandPanel.Controls.Add(this.bNameLabel);
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandPanel.Location = new System.Drawing.Point(252, 48);
            this.brandPanel.Name = "brandPanel";
            this.mainLayout.SetRowSpan(this.brandPanel, 2);
            this.brandPanel.Size = new System.Drawing.Size(181, 354);
            this.brandPanel.TabIndex = 1;
            // 
            // bAddButton
            // 
            this.bAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAddButton.Location = new System.Drawing.Point(2, 316);
            this.bAddButton.Name = "bAddButton";
            this.bAddButton.Size = new System.Drawing.Size(176, 36);
            this.bAddButton.TabIndex = 9;
            this.bAddButton.Text = "Define Brand";
            this.bAddButton.UseVisualStyleBackColor = true;
            this.bAddButton.Click += new System.EventHandler(this.AddBrandClick);
            // 
            // bSupplierBox
            // 
            this.bSupplierBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSupplierBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSupplierBox.FormattingEnabled = true;
            this.bSupplierBox.ItemHeight = 20;
            this.bSupplierBox.Location = new System.Drawing.Point(2, 158);
            this.bSupplierBox.Name = "bSupplierBox";
            this.bSupplierBox.Size = new System.Drawing.Size(176, 44);
            this.bSupplierBox.TabIndex = 6;
            // 
            // bSupplierLabel
            // 
            this.bSupplierLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSupplierLabel.AutoSize = true;
            this.bSupplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSupplierLabel.Location = new System.Drawing.Point(2, 134);
            this.bSupplierLabel.Name = "bSupplierLabel";
            this.bSupplierLabel.Size = new System.Drawing.Size(114, 20);
            this.bSupplierLabel.TabIndex = 5;
            this.bSupplierLabel.Text = "Brand Supplier";
            // 
            // bManufacturerBox
            // 
            this.bManufacturerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bManufacturerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bManufacturerBox.FormattingEnabled = true;
            this.bManufacturerBox.ItemHeight = 20;
            this.bManufacturerBox.Location = new System.Drawing.Point(2, 84);
            this.bManufacturerBox.Name = "bManufacturerBox";
            this.bManufacturerBox.Size = new System.Drawing.Size(176, 44);
            this.bManufacturerBox.TabIndex = 4;
            // 
            // bManufacturerLabel
            // 
            this.bManufacturerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bManufacturerLabel.AutoSize = true;
            this.bManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bManufacturerLabel.Location = new System.Drawing.Point(2, 60);
            this.bManufacturerLabel.Name = "bManufacturerLabel";
            this.bManufacturerLabel.Size = new System.Drawing.Size(151, 20);
            this.bManufacturerLabel.TabIndex = 3;
            this.bManufacturerLabel.Text = "Brand Manufacturer";
            // 
            // bNameBox
            // 
            this.bNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bNameBox.Location = new System.Drawing.Point(2, 28);
            this.bNameBox.MaxLength = 32;
            this.bNameBox.Name = "bNameBox";
            this.bNameBox.Size = new System.Drawing.Size(176, 26);
            this.bNameBox.TabIndex = 2;
            // 
            // bNameLabel
            // 
            this.bNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bNameLabel.AutoSize = true;
            this.bNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bNameLabel.Location = new System.Drawing.Point(2, 4);
            this.bNameLabel.Name = "bNameLabel";
            this.bNameLabel.Size = new System.Drawing.Size(98, 20);
            this.bNameLabel.TabIndex = 1;
            this.bNameLabel.Text = "Brand Name";
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.pAddButton);
            this.productPanel.Controls.Add(this.pPriceBox);
            this.productPanel.Controls.Add(this.pPriceLabel);
            this.productPanel.Controls.Add(this.pCostBox);
            this.productPanel.Controls.Add(this.pCostLabel);
            this.productPanel.Controls.Add(this.pBrandBox);
            this.productPanel.Controls.Add(this.pBrandLabel);
            this.productPanel.Controls.Add(this.pNameBox);
            this.productPanel.Controls.Add(this.pNameLabel);
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPanel.Location = new System.Drawing.Point(3, 48);
            this.productPanel.Name = "productPanel";
            this.mainLayout.SetRowSpan(this.productPanel, 2);
            this.productPanel.Size = new System.Drawing.Size(243, 354);
            this.productPanel.TabIndex = 0;
            // 
            // pAddButton
            // 
            this.pAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pAddButton.Location = new System.Drawing.Point(26, 316);
            this.pAddButton.Name = "pAddButton";
            this.pAddButton.Size = new System.Drawing.Size(190, 36);
            this.pAddButton.TabIndex = 8;
            this.pAddButton.Text = "Define Product";
            this.pAddButton.UseVisualStyleBackColor = true;
            this.pAddButton.Click += new System.EventHandler(this.AddProductClick);
            // 
            // pPriceBox
            // 
            this.pPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pPriceBox.Location = new System.Drawing.Point(26, 214);
            this.pPriceBox.Name = "pPriceBox";
            this.pPriceBox.Size = new System.Drawing.Size(190, 26);
            this.pPriceBox.TabIndex = 7;
            this.pPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pPriceLabel
            // 
            this.pPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pPriceLabel.AutoSize = true;
            this.pPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pPriceLabel.Location = new System.Drawing.Point(26, 190);
            this.pPriceLabel.Name = "pPriceLabel";
            this.pPriceLabel.Size = new System.Drawing.Size(103, 20);
            this.pPriceLabel.TabIndex = 6;
            this.pPriceLabel.Text = "Product Price";
            // 
            // pCostBox
            // 
            this.pCostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pCostBox.Location = new System.Drawing.Point(26, 158);
            this.pCostBox.Name = "pCostBox";
            this.pCostBox.Size = new System.Drawing.Size(190, 26);
            this.pCostBox.TabIndex = 5;
            this.pCostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pCostLabel
            // 
            this.pCostLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pCostLabel.AutoSize = true;
            this.pCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pCostLabel.Location = new System.Drawing.Point(26, 134);
            this.pCostLabel.Name = "pCostLabel";
            this.pCostLabel.Size = new System.Drawing.Size(101, 20);
            this.pCostLabel.TabIndex = 4;
            this.pCostLabel.Text = "Product Cost";
            // 
            // pBrandBox
            // 
            this.pBrandBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBrandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pBrandBox.FormattingEnabled = true;
            this.pBrandBox.ItemHeight = 20;
            this.pBrandBox.Location = new System.Drawing.Point(26, 84);
            this.pBrandBox.Name = "pBrandBox";
            this.pBrandBox.Size = new System.Drawing.Size(190, 44);
            this.pBrandBox.TabIndex = 3;
            // 
            // pBrandLabel
            // 
            this.pBrandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBrandLabel.AutoSize = true;
            this.pBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pBrandLabel.Location = new System.Drawing.Point(26, 60);
            this.pBrandLabel.Name = "pBrandLabel";
            this.pBrandLabel.Size = new System.Drawing.Size(111, 20);
            this.pBrandLabel.TabIndex = 2;
            this.pBrandLabel.Text = "Product Brand";
            // 
            // pNameBox
            // 
            this.pNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pNameBox.Location = new System.Drawing.Point(26, 28);
            this.pNameBox.MaxLength = 32;
            this.pNameBox.Name = "pNameBox";
            this.pNameBox.Size = new System.Drawing.Size(190, 26);
            this.pNameBox.TabIndex = 1;
            // 
            // pNameLabel
            // 
            this.pNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNameLabel.AutoSize = true;
            this.pNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pNameLabel.Location = new System.Drawing.Point(26, 4);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(110, 20);
            this.pNameLabel.TabIndex = 0;
            this.pNameLabel.Text = "Product Name";
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.Location = new System.Drawing.Point(252, 408);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(181, 39);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // DefineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.mainLayout);
            this.Name = "DefineForm";
            this.Text = "DefineForm";
            this.mainLayout.ResumeLayout(false);
            this.supplierPanel.ResumeLayout(false);
            this.supplierPanel.PerformLayout();
            this.manufacturerPanel.ResumeLayout(false);
            this.manufacturerPanel.PerformLayout();
            this.brandPanel.ResumeLayout(false);
            this.brandPanel.PerformLayout();
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCostBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel supplierPanel;
        private System.Windows.Forms.Panel manufacturerPanel;
        private System.Windows.Forms.Panel brandPanel;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox pNameBox;
        private System.Windows.Forms.ListBox pBrandBox;
        private System.Windows.Forms.Label pBrandLabel;
        private System.Windows.Forms.NumericUpDown pCostBox;
        private System.Windows.Forms.Label pCostLabel;
        private System.Windows.Forms.Label pPriceLabel;
        private System.Windows.Forms.NumericUpDown pPriceBox;
        private System.Windows.Forms.TextBox bNameBox;
        private System.Windows.Forms.Label bNameLabel;
        private System.Windows.Forms.Button pAddButton;
        private System.Windows.Forms.Label bSupplierLabel;
        private System.Windows.Forms.ListBox bManufacturerBox;
        private System.Windows.Forms.Label bManufacturerLabel;
        private System.Windows.Forms.TextBox mNameBox;
        private System.Windows.Forms.Label mNameLabel;
        private System.Windows.Forms.Button bAddButton;
        private System.Windows.Forms.ListBox bSupplierBox;
        private System.Windows.Forms.Label mContactLabel;
        private System.Windows.Forms.Button sAddButton;
        private System.Windows.Forms.TextBox sContactBox;
        private System.Windows.Forms.Label sContactLabel;
        private System.Windows.Forms.TextBox sNameBox;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.Button mAddButton;
        private System.Windows.Forms.TextBox mContactBox;
    }
}