using System;
using System.Windows.Forms;

namespace playfair
{
    public partial class ResultForm : Form
    {
        public ResultForm(string resultText)
        {
            InitializeComponent();

            // Hiển thị kết quả trong RichTextBox
            richTextBoxResult.Text = resultText;
        }

        private void InitializeComponent()
        {
            this.richTextBoxResult = new Krypton.Toolkit.KryptonRichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(625, 314);
            this.richTextBoxResult.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.richTextBoxResult.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxResult.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxResult.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.richTextBoxResult.StateCommon.Border.Rounding = 18F;
            this.richTextBoxResult.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.richTextBoxResult.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBoxResult.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            // 
            // ResultForm
            // 
            this.ClientSize = new System.Drawing.Size(649, 338);
            this.Controls.Add(this.richTextBoxResult);
            this.Name = "ResultForm";
            this.Text = "Result";
            this.ResumeLayout(false);

        }

        private Krypton.Toolkit.KryptonRichTextBox richTextBoxResult;
    }
}
