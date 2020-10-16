namespace Unit1FormsComponentsBasics9
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
            this.selected = new System.Windows.Forms.TextBox();
            this.numbers = new System.Windows.Forms.ComboBox();
            this.par = new System.Windows.Forms.Button();
            this.impar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selected
            // 
            this.selected.Location = new System.Drawing.Point(50, 199);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(342, 22);
            this.selected.TabIndex = 0;
            this.selected.TextChanged += new System.EventHandler(this.selected_TextChanged);
            // 
            // numbers
            // 
            this.numbers.FormattingEnabled = true;
            this.numbers.Location = new System.Drawing.Point(50, 88);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(217, 24);
            this.numbers.TabIndex = 1;
            this.numbers.SelectedIndexChanged += new System.EventHandler(this.numbers_SelectedIndexChanged);
            // 
            // par
            // 
            this.par.Location = new System.Drawing.Point(294, 68);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(98, 23);
            this.par.TabIndex = 2;
            this.par.Text = "Even (par)";
            this.par.UseVisualStyleBackColor = true;
            this.par.Click += new System.EventHandler(this.par_Click);
            // 
            // impar
            // 
            this.impar.Location = new System.Drawing.Point(294, 110);
            this.impar.Name = "impar";
            this.impar.Size = new System.Drawing.Size(98, 23);
            this.impar.TabIndex = 3;
            this.impar.Text = "Odd (impar)";
            this.impar.UseVisualStyleBackColor = true;
            this.impar.Click += new System.EventHandler(this.impar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 286);
            this.Controls.Add(this.impar);
            this.Controls.Add(this.par);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.selected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selected;
        private System.Windows.Forms.ComboBox numbers;
        private System.Windows.Forms.Button par;
        private System.Windows.Forms.Button impar;
    }
}

