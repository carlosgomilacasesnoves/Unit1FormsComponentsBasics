namespace Unit1FormsComponentsBasics7
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
            this.showsel = new System.Windows.Forms.TextBox();
            this.comboColors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // showsel
            // 
            this.showsel.Location = new System.Drawing.Point(27, 123);
            this.showsel.Name = "showsel";
            this.showsel.Size = new System.Drawing.Size(243, 22);
            this.showsel.TabIndex = 0;
            this.showsel.TextChanged += new System.EventHandler(this.showsel_TextChanged);
            // 
            // comboColors
            // 
            this.comboColors.FormattingEnabled = true;
            this.comboColors.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Green",
            "White",
            "Cian"});
            this.comboColors.Location = new System.Drawing.Point(27, 30);
            this.comboColors.Name = "comboColors";
            this.comboColors.Size = new System.Drawing.Size(243, 24);
            this.comboColors.TabIndex = 1;
            this.comboColors.SelectedIndexChanged += new System.EventHandler(this.comboColors_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboColors);
            this.Controls.Add(this.showsel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showsel;
        private System.Windows.Forms.ComboBox comboColors;
    }
}

