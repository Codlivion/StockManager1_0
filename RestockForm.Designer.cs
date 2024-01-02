namespace StockManager1_0
{
    partial class RestockForm
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.modePanel = new System.Windows.Forms.Panel();
            this.cmodeButton = new System.Windows.Forms.Button();
            this.pmodeButton = new System.Windows.Forms.Button();
            this.qmodeButton = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.mainLayout.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.modePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.Controls.Add(this.controlPanel, 1, 3);
            this.mainLayout.Controls.Add(this.modePanel, 1, 0);
            this.mainLayout.Controls.Add(this.editPanel, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.Size = new System.Drawing.Size(624, 549);
            this.mainLayout.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.closeButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(34, 495);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(555, 51);
            this.controlPanel.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.Location = new System.Drawing.Point(202, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // modePanel
            // 
            this.modePanel.Controls.Add(this.cmodeButton);
            this.modePanel.Controls.Add(this.pmodeButton);
            this.modePanel.Controls.Add(this.qmodeButton);
            this.modePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modePanel.Location = new System.Drawing.Point(34, 3);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(555, 48);
            this.modePanel.TabIndex = 1;
            // 
            // cmodeButton
            // 
            this.cmodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmodeButton.Location = new System.Drawing.Point(400, 5);
            this.cmodeButton.Name = "cmodeButton";
            this.cmodeButton.Size = new System.Drawing.Size(150, 30);
            this.cmodeButton.TabIndex = 2;
            this.cmodeButton.Text = "Cost";
            this.cmodeButton.UseVisualStyleBackColor = true;
            this.cmodeButton.Click += new System.EventHandler(this.CostButtonClick);
            // 
            // pmodeButton
            // 
            this.pmodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pmodeButton.Location = new System.Drawing.Point(202, 5);
            this.pmodeButton.Name = "pmodeButton";
            this.pmodeButton.Size = new System.Drawing.Size(150, 30);
            this.pmodeButton.TabIndex = 1;
            this.pmodeButton.Text = "Price";
            this.pmodeButton.UseVisualStyleBackColor = true;
            this.pmodeButton.Click += new System.EventHandler(this.PriceButtonClick);
            // 
            // qmodeButton
            // 
            this.qmodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.qmodeButton.Location = new System.Drawing.Point(5, 5);
            this.qmodeButton.Name = "qmodeButton";
            this.qmodeButton.Size = new System.Drawing.Size(150, 30);
            this.qmodeButton.TabIndex = 0;
            this.qmodeButton.Text = "Quantity";
            this.qmodeButton.UseVisualStyleBackColor = true;
            this.qmodeButton.Click += new System.EventHandler(this.QuantityButtonClick);
            // 
            // editPanel
            // 
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPanel.Location = new System.Drawing.Point(34, 57);
            this.editPanel.Name = "editPanel";
            this.mainLayout.SetRowSpan(this.editPanel, 2);
            this.editPanel.Size = new System.Drawing.Size(555, 432);
            this.editPanel.TabIndex = 0;
            this.editPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawEditPanel);
            this.editPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditPanelClick);
            // 
            // RestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 549);
            this.Controls.Add(this.mainLayout);
            this.Name = "RestockForm";
            this.Text = "RestockForm";
            this.mainLayout.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.modePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.Button pmodeButton;
        private System.Windows.Forms.Button qmodeButton;
        private System.Windows.Forms.Button cmodeButton;
        private System.Windows.Forms.Button closeButton;
    }
}