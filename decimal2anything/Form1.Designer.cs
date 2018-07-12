namespace decimal2anything
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
            this.value = new System.Windows.Forms.TextBox();
            this.convert_btn = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.Color.Ivory;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value.Dock = System.Windows.Forms.DockStyle.Top;
            this.value.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.Location = new System.Drawing.Point(0, 0);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(380, 32);
            this.value.TabIndex = 1;
            this.value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // convert_btn
            // 
            this.convert_btn.BackColor = System.Drawing.Color.Ivory;
            this.convert_btn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.convert_btn.FlatAppearance.BorderSize = 0;
            this.convert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert_btn.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold);
            this.convert_btn.Location = new System.Drawing.Point(466, 62);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(146, 33);
            this.convert_btn.TabIndex = 1;
            this.convert_btn.Text = "Convert";
            this.convert_btn.UseVisualStyleBackColor = false;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // sonuc
            // 
            this.sonuc.BackColor = System.Drawing.Color.Ivory;
            this.sonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sonuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.sonuc.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonuc.Location = new System.Drawing.Point(0, 32);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(380, 32);
            this.sonuc.TabIndex = 2;
            this.sonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 30);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.convert_btn);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 32);
            this.panel2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "2",
            "8",
            "16"});
            this.comboBox1.BackColor = System.Drawing.Color.Ivory;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "8",
            "16"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(461, 32);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sonuc);
            this.panel3.Controls.Add(this.value);
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 69);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(386, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(461, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "DecimalConverter";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.TextBox sonuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}

