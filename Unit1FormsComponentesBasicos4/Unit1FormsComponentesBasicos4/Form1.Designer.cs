namespace Unit1FormsComponentesBasicos4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculate = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.operat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(66, 192);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(186, 65);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 23);
            this.Sum.TabIndex = 1;
            this.Sum.Text = "Sum";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Substract
            // 
            this.Substract.Location = new System.Drawing.Point(186, 128);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(100, 23);
            this.Substract.TabIndex = 2;
            this.Substract.Text = "Substract";
            this.Substract.UseVisualStyleBackColor = true;
            this.Substract.Click += new System.EventHandler(this.Substract_Click);
            // 
            // Rest
            // 
            this.Rest.Location = new System.Drawing.Point(305, 192);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(100, 23);
            this.Rest.TabIndex = 3;
            this.Rest.Text = "Rest";
            this.Rest.UseVisualStyleBackColor = true;
            this.Rest.Click += new System.EventHandler(this.Rest_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(66, 65);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 4;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(304, 95);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 5;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(66, 128);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 6;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // operat
            // 
            this.operat.Location = new System.Drawing.Point(186, 193);
            this.operat.Name = "operat";
            this.operat.Size = new System.Drawing.Size(100, 22);
            this.operat.TabIndex = 7;
            this.operat.TextChanged += new System.EventHandler(this.operat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select operation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operation selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operat);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.Rest);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox operat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

