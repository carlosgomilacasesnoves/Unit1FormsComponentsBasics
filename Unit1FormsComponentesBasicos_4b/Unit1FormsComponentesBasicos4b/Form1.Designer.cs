namespace Unit1FormsComponentesBasicos4b
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.rest = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.operat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionselected = new System.Windows.Forms.Label();
            this.selected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(65, 63);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(65, 119);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(345, 89);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 3;
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(345, 169);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(100, 23);
            this.rest.TabIndex = 4;
            this.rest.Text = "Rest";
            this.rest.UseVisualStyleBackColor = true;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(65, 168);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(100, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // operat
            // 
            this.operat.FormattingEnabled = true;
            this.operat.Items.AddRange(new object[] {
            "+",
            "-"});
            this.operat.Location = new System.Drawing.Point(204, 45);
            this.operat.Name = "operat";
            this.operat.Size = new System.Drawing.Size(100, 24);
            this.operat.TabIndex = 6;
            this.operat.SelectedIndexChanged += new System.EventHandler(this.operat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select option";
            // 
            // optionselected
            // 
            this.optionselected.AutoSize = true;
            this.optionselected.Location = new System.Drawing.Point(201, 149);
            this.optionselected.Name = "optionselected";
            this.optionselected.Size = new System.Drawing.Size(107, 17);
            this.optionselected.TabIndex = 8;
            this.optionselected.Text = "Option selected";
            // 
            // selected
            // 
            this.selected.Location = new System.Drawing.Point(204, 168);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(100, 22);
            this.selected.TabIndex = 9;
            this.selected.TextChanged += new System.EventHandler(this.selected_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 251);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.optionselected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operat);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.ComboBox operat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label optionselected;
        private System.Windows.Forms.TextBox selected;
    }
}

