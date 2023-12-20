namespace WindowsFormsApp4.Forms
{
    partial class GivingBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditionCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDReadersCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GiveButt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CountText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CountText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EditionCombo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.IDReadersCombo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GiveButt);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(446, 291);
            this.panel1.MinimumSize = new System.Drawing.Size(391, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 291);
            this.panel1.TabIndex = 7;
            // 
            // EditionCombo
            // 
            this.EditionCombo.FormattingEnabled = true;
            this.EditionCombo.Location = new System.Drawing.Point(196, 116);
            this.EditionCombo.Name = "EditionCombo";
            this.EditionCombo.Size = new System.Drawing.Size(121, 21);
            this.EditionCombo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(7, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Издание:";
            // 
            // IDReadersCombo
            // 
            this.IDReadersCombo.FormattingEnabled = true;
            this.IDReadersCombo.Location = new System.Drawing.Point(196, 79);
            this.IDReadersCombo.Name = "IDReadersCombo";
            this.IDReadersCombo.Size = new System.Drawing.Size(121, 21);
            this.IDReadersCombo.TabIndex = 7;
            this.IDReadersCombo.SelectedIndexChanged += new System.EventHandler(this.IDReaderCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(139, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выдача книги";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID пользователя:";
            // 
            // GiveButt
            // 
            this.GiveButt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GiveButt.BackColor = System.Drawing.Color.Green;
            this.GiveButt.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.цветной_паттерн;
            this.GiveButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GiveButt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GiveButt.Location = new System.Drawing.Point(357, 256);
            this.GiveButt.Name = "GiveButt";
            this.GiveButt.Size = new System.Drawing.Size(82, 28);
            this.GiveButt.TabIndex = 4;
            this.GiveButt.Text = "Выдать";
            this.GiveButt.UseVisualStyleBackColor = false;
            this.GiveButt.Click += new System.EventHandler(this.GiveButt_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(9, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Количество:";
            // 
            // CountText
            // 
            this.CountText.Location = new System.Drawing.Point(196, 151);
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(121, 20);
            this.CountText.TabIndex = 14;
            // 
            // GivingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.цветной_паттерн;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 435);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "GivingBooks";
            this.Text = "GivingBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GiveButt;
        private System.Windows.Forms.ComboBox EditionCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox IDReadersCombo;
        private System.Windows.Forms.TextBox CountText;
        private System.Windows.Forms.Label label6;
    }
}