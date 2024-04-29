namespace WeaselRental
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
            this.Small = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Large = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PriceEm = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Small
            // 
            this.Small.AutoSize = true;
            this.Small.Location = new System.Drawing.Point(244, 188);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(50, 17);
            this.Small.TabIndex = 1;
            this.Small.TabStop = true;
            this.Small.Text = "Small";
            this.Small.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Small.UseVisualStyleBackColor = true;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(244, 211);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(62, 17);
            this.Medium.TabIndex = 2;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // Large
            // 
            this.Large.AutoSize = true;
            this.Large.Location = new System.Drawing.Point(244, 234);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(52, 17);
            this.Large.TabIndex = 3;
            this.Large.TabStop = true;
            this.Large.Text = "Large";
            this.Large.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Large.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sleepy",
            "Energetic"});
            this.comboBox1.Location = new System.Drawing.Point(244, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // PriceEm
            // 
            this.PriceEm.Location = new System.Drawing.Point(383, 324);
            this.PriceEm.Name = "PriceEm";
            this.PriceEm.Size = new System.Drawing.Size(75, 23);
            this.PriceEm.TabIndex = 6;
            this.PriceEm.Text = "Price \'Em!";
            this.PriceEm.UseVisualStyleBackColor = true;
            this.PriceEm.Click += new System.EventHandler(this.PriceEm_Click);
            // 
            // Quantity
            // 
            this.Quantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Quantity.FormattingEnabled = true;
            this.Quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Quantity.Location = new System.Drawing.Point(244, 282);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(121, 21);
            this.Quantity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity";
            // 
            // OutPut
            // 
            this.OutPut.AutoSize = true;
            this.OutPut.Location = new System.Drawing.Point(380, 371);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(39, 13);
            this.OutPut.TabIndex = 10;
            this.OutPut.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.PriceEm);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Large);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Small);
            this.Name = "Form1";
            this.Text = "Weasel Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Large;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button PriceEm;
        private System.Windows.Forms.ComboBox Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutPut;
    }
}

