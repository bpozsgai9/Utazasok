namespace Utazasok.View
{
    partial class AddTrip
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prioroty";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(114, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(154, 27);
            this.nameTextBox.TabIndex = 5;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(114, 118);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(154, 27);
            this.countryTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(114, 157);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(154, 27);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // priorityNumericUpDown
            // 
            this.priorityNumericUpDown.Location = new System.Drawing.Point(114, 196);
            this.priorityNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.priorityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priorityNumericUpDown.Name = "priorityNumericUpDown";
            this.priorityNumericUpDown.Size = new System.Drawing.Size(154, 27);
            this.priorityNumericUpDown.TabIndex = 9;
            this.priorityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Lime;
            this.okButton.Location = new System.Drawing.Point(114, 240);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(154, 29);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(23, 240);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 29);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(114, 73);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(154, 28);
            this.categoryComboBox.TabIndex = 12;
            // 
            // AddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 327);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.priorityNumericUpDown);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTrip";
            this.Text = "AddTrip";
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameTextBox;
        private TextBox countryTextBox;
        private TextBox descriptionTextBox;
        private NumericUpDown priorityNumericUpDown;
        private Button okButton;
        private Button CancelButton;
        private ComboBox categoryComboBox;
    }
}