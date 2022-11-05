namespace Utazasok
{
    partial class ListTrips
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addTripStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listTripStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tripDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTripStrip,
            this.listTripStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addTripStrip
            // 
            this.addTripStrip.Name = "addTripStrip";
            this.addTripStrip.Size = new System.Drawing.Size(89, 24);
            this.addTripStrip.Text = "Add Tripp";
            this.addTripStrip.Click += new System.EventHandler(this.addTripStrip_Click);
            // 
            // listTripStrip
            // 
            this.listTripStrip.Name = "listTripStrip";
            this.listTripStrip.Size = new System.Drawing.Size(102, 24);
            this.listTripStrip.Text = "List All Trips";
            this.listTripStrip.Click += new System.EventHandler(this.listTripStrip_Click);
            // 
            // tripDataGridView
            // 
            this.tripDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripDataGridView.Location = new System.Drawing.Point(0, 31);
            this.tripDataGridView.Name = "tripDataGridView";
            this.tripDataGridView.RowHeadersWidth = 51;
            this.tripDataGridView.RowTemplate.Height = 29;
            this.tripDataGridView.Size = new System.Drawing.Size(800, 420);
            this.tripDataGridView.TabIndex = 1;
            this.tripDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tripDataGridView_CellMouseClick);
            // 
            // ListTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tripDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListTrips";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addTripStrip;
        private ToolStripMenuItem listTripStrip;
        private DataGridView tripDataGridView;
    }
}