namespace Unit1FormsComponentsBasics10
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
            this.scroll = new System.Windows.Forms.HScrollBar();
            this.percent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scroll
            // 
            this.scroll.Location = new System.Drawing.Point(41, 30);
            this.scroll.Maximum = 89;
            this.scroll.Minimum = 49;
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(500, 28);
            this.scroll.TabIndex = 0;
            this.scroll.Value = 50;
            this.scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_Scroll);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(41, 103);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(500, 22);
            this.percent.TabIndex = 1;
            this.percent.TextChanged += new System.EventHandler(this.percent_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 186);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.scroll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scroll;
        private System.Windows.Forms.TextBox percent;
    }
}

