namespace Unit1FormsComponentesBasicos6
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
            this.blue = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.white = new System.Windows.Forms.RadioButton();
            this.ok = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(51, 114);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(57, 21);
            this.blue.TabIndex = 0;
            this.blue.TabStop = true;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(51, 70);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(55, 21);
            this.red.TabIndex = 1;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            // 
            // white
            // 
            this.white.AutoSize = true;
            this.white.Location = new System.Drawing.Point(51, 157);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(65, 21);
            this.white.TabIndex = 2;
            this.white.TabStop = true;
            this.white.Text = "White";
            this.white.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(51, 207);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(51, 258);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(182, 22);
            this.result.TabIndex = 4;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 326);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.white);
            this.Controls.Add(this.red);
            this.Controls.Add(this.blue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton white;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox result;
    }
}

