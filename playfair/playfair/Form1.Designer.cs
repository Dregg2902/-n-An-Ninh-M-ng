namespace playfair
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBoxPlaintext = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.textBoxKey = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new Krypton.Toolkit.KryptonDataGridView();
            this.buttonEncrypt = new Krypton.Toolkit.KryptonButton();
            this.buttonDecrypt = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(28, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelKey.Location = new System.Drawing.Point(28, 252);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(73, 29);
            this.labelKey.TabIndex = 3;
            this.labelKey.Text = "Khóa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBoxPlaintext
            // 
            this.richTextBoxPlaintext.Location = new System.Drawing.Point(117, 82);
            this.richTextBoxPlaintext.Name = "richTextBoxPlaintext";
            this.richTextBoxPlaintext.Size = new System.Drawing.Size(835, 149);
            this.richTextBoxPlaintext.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.richTextBoxPlaintext.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxPlaintext.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxPlaintext.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.richTextBoxPlaintext.StateCommon.Border.Rounding = 18F;
            this.richTextBoxPlaintext.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.richTextBoxPlaintext.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBoxPlaintext.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.richTextBoxPlaintext.TabIndex = 7;
            this.richTextBoxPlaintext.Text = "";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(117, 246);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(835, 35);
            this.textBoxKey.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.textBoxKey.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxKey.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxKey.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBoxKey.StateCommon.Border.Rounding = 18F;
            this.textBoxKey.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.textBoxKey.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxKey.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textBoxKey.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(339, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "MÃ HÓA PLAYFAIR";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrix.ColumnHeadersHeight = 36;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(117, 310);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(835, 212);
            this.dataGridViewMatrix.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMatrix.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMatrix.StateCommon.Background.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewMatrix.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewMatrix.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.dataGridViewMatrix.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.dataGridViewMatrix.StateCommon.DataCell.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewMatrix.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Gray;
            this.dataGridViewMatrix.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Gray;
            this.dataGridViewMatrix.StateCommon.DataCell.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewMatrix.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMatrix.StateCommon.DataCell.Content.Color2 = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewMatrix.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridViewMatrix.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.DarkGray;
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkGray;
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Black;
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridViewMatrix.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridViewMatrix.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.DarkGray;
            this.dataGridViewMatrix.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.DarkGray;
            this.dataGridViewMatrix.StateCommon.HeaderRow.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewMatrix.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMatrix.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMatrix.StateCommon.HeaderRow.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewMatrix.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.dataGridViewMatrix.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.Black;
            this.dataGridViewMatrix.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridViewMatrix.StateCommon.HeaderRow.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridViewMatrix.TabIndex = 10;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(285, 567);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonEncrypt.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.buttonEncrypt.OverrideDefault.Back.ColorAngle = 45F;
            this.buttonEncrypt.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonEncrypt.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.buttonEncrypt.OverrideDefault.Border.ColorAngle = 45F;
            this.buttonEncrypt.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonEncrypt.OverrideDefault.Border.Rounding = 18F;
            this.buttonEncrypt.OverrideDefault.Border.Width = 1;
            this.buttonEncrypt.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonEncrypt.Size = new System.Drawing.Size(160, 44);
            this.buttonEncrypt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.buttonEncrypt.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.buttonEncrypt.StateCommon.Back.ColorAngle = 45F;
            this.buttonEncrypt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.buttonEncrypt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.buttonEncrypt.StateCommon.Border.ColorAngle = 45F;
            this.buttonEncrypt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonEncrypt.StateCommon.Border.Rounding = 18F;
            this.buttonEncrypt.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonEncrypt.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonEncrypt.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonEncrypt.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.buttonEncrypt.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.buttonEncrypt.StatePressed.Back.ColorAngle = 130F;
            this.buttonEncrypt.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.buttonEncrypt.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.buttonEncrypt.StatePressed.Border.ColorAngle = 130F;
            this.buttonEncrypt.StatePressed.Border.Rounding = 18F;
            this.buttonEncrypt.StatePressed.Border.Width = 1;
            this.buttonEncrypt.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonEncrypt.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonEncrypt.StateTracking.Back.ColorAngle = 45F;
            this.buttonEncrypt.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonEncrypt.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.buttonEncrypt.StateTracking.Border.ColorAngle = 45F;
            this.buttonEncrypt.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonEncrypt.StateTracking.Border.Rounding = 18F;
            this.buttonEncrypt.StateTracking.Border.Width = 1;
            this.buttonEncrypt.TabIndex = 11;
            this.buttonEncrypt.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.buttonEncrypt.Values.Text = "Mã hóa";
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(557, 567);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonDecrypt.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.buttonDecrypt.OverrideDefault.Back.ColorAngle = 45F;
            this.buttonDecrypt.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonDecrypt.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.buttonDecrypt.OverrideDefault.Border.ColorAngle = 45F;
            this.buttonDecrypt.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonDecrypt.OverrideDefault.Border.Rounding = 18F;
            this.buttonDecrypt.OverrideDefault.Border.Width = 1;
            this.buttonDecrypt.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonDecrypt.Size = new System.Drawing.Size(160, 44);
            this.buttonDecrypt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.buttonDecrypt.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.buttonDecrypt.StateCommon.Back.ColorAngle = 45F;
            this.buttonDecrypt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.buttonDecrypt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.buttonDecrypt.StateCommon.Border.ColorAngle = 45F;
            this.buttonDecrypt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonDecrypt.StateCommon.Border.Rounding = 18F;
            this.buttonDecrypt.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonDecrypt.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonDecrypt.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDecrypt.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.buttonDecrypt.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.buttonDecrypt.StatePressed.Back.ColorAngle = 130F;
            this.buttonDecrypt.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.buttonDecrypt.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(122)))), ((int)(((byte)(206)))));
            this.buttonDecrypt.StatePressed.Border.ColorAngle = 130F;
            this.buttonDecrypt.StatePressed.Border.Rounding = 18F;
            this.buttonDecrypt.StatePressed.Border.Width = 1;
            this.buttonDecrypt.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonDecrypt.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonDecrypt.StateTracking.Back.ColorAngle = 45F;
            this.buttonDecrypt.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.buttonDecrypt.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.buttonDecrypt.StateTracking.Border.ColorAngle = 45F;
            this.buttonDecrypt.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonDecrypt.StateTracking.Border.Rounding = 18F;
            this.buttonDecrypt.StateTracking.Border.Width = 1;
            this.buttonDecrypt.TabIndex = 12;
            this.buttonDecrypt.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.buttonDecrypt.Values.Text = "Giải mã";
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 650);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.richTextBoxPlaintext);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Playfair Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKey; // Sửa tên thành labelKey
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Krypton.Toolkit.KryptonRichTextBox richTextBoxPlaintext;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonTextBox textBoxKey;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonDataGridView dataGridViewMatrix;
        private Krypton.Toolkit.KryptonButton buttonEncrypt;
        private Krypton.Toolkit.KryptonButton buttonDecrypt;
    }
}
