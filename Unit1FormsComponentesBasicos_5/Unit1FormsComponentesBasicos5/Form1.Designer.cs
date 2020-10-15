namespace Unit1FormsComponentesBasicos5
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
            this.mouse = new System.Windows.Forms.CheckBox();
            this.cat = new System.Windows.Forms.CheckBox();
            this.dog = new System.Windows.Forms.CheckBox();
            this.ok = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mouse
            // 
            this.mouse.AutoSize = true;
            this.mouse.Location = new System.Drawing.Point(37, 37);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(72, 21);
            this.mouse.TabIndex = 0;
            this.mouse.Text = "Mouse";
            this.mouse.UseVisualStyleBackColor = true;
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Location = new System.Drawing.Point(37, 77);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(51, 21);
            this.cat.TabIndex = 1;
            this.cat.Text = "Cat";
            this.cat.UseVisualStyleBackColor = true;
            // 
            // dog
            // 
            this.dog.AutoSize = true;
            this.dog.Location = new System.Drawing.Point(37, 118);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(56, 21);
            this.dog.TabIndex = 2;
            this.dog.Text = "Dog";
            this.dog.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(37, 165);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(37, 206);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(270, 22);
            this.result.TabIndex = 4;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 271);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.mouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mouse;
        private System.Windows.Forms.CheckBox cat;
        private System.Windows.Forms.CheckBox dog;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox result;
    }
}

