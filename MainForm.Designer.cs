namespace StockManager1_0
{
    partial class MainForm
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
            this.outputPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.simulationButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.stocksButton = new System.Windows.Forms.Button();
            this.defineButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.mainLayout.Controls.Add(this.outputPanel, 1, 1);
            this.mainLayout.Controls.Add(this.controlPanel, 1, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.Size = new System.Drawing.Size(624, 450);
            this.mainLayout.TabIndex = 0;
            // 
            // outputPanel
            // 
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.Location = new System.Drawing.Point(34, 48);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(555, 309);
            this.outputPanel.TabIndex = 0;
            this.outputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawOutput);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.simulationButton);
            this.controlPanel.Controls.Add(this.restockButton);
            this.controlPanel.Controls.Add(this.stocksButton);
            this.controlPanel.Controls.Add(this.defineButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(34, 363);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(555, 84);
            this.controlPanel.TabIndex = 1;
            // 
            // simulationButton
            // 
            this.simulationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simulationButton.Location = new System.Drawing.Point(197, 45);
            this.simulationButton.Name = "simulationButton";
            this.simulationButton.Size = new System.Drawing.Size(160, 30);
            this.simulationButton.TabIndex = 3;
            this.simulationButton.Text = "Test Simulation";
            this.simulationButton.UseVisualStyleBackColor = true;
            this.simulationButton.Click += new System.EventHandler(this.SimulationButtonClick);
            // 
            // restockButton
            // 
            this.restockButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restockButton.Location = new System.Drawing.Point(390, 10);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(160, 30);
            this.restockButton.TabIndex = 2;
            this.restockButton.Text = "Re-Stock Product";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.RestockButtonClick);
            // 
            // stocksButton
            // 
            this.stocksButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stocksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stocksButton.Location = new System.Drawing.Point(197, 10);
            this.stocksButton.Name = "stocksButton";
            this.stocksButton.Size = new System.Drawing.Size(160, 30);
            this.stocksButton.TabIndex = 1;
            this.stocksButton.Text = "Show Stocks";
            this.stocksButton.UseVisualStyleBackColor = true;
            this.stocksButton.Click += new System.EventHandler(this.StocksButtonClick);
            // 
            // defineButton
            // 
            this.defineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.defineButton.Location = new System.Drawing.Point(10, 10);
            this.defineButton.Name = "defineButton";
            this.defineButton.Size = new System.Drawing.Size(160, 30);
            this.defineButton.TabIndex = 0;
            this.defineButton.Text = "Define Product";
            this.defineButton.UseVisualStyleBackColor = true;
            this.defineButton.Click += new System.EventHandler(this.DefineButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.mainLayout);
            this.Name = "MainForm";
            this.Text = "Stock Manager";
            this.mainLayout.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button defineButton;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button stocksButton;
        private System.Windows.Forms.Button simulationButton;
    }
}

