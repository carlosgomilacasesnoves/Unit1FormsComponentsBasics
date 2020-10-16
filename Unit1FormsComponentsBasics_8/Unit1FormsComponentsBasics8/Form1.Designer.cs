namespace Unit1FormsComponentsBasics8
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
            this.name = new System.Windows.Forms.TextBox();
            this.room1 = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.room2 = new System.Windows.Forms.Button();
            this.listClassroom = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(35, 188);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 22);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // room1
            // 
            this.room1.Location = new System.Drawing.Point(197, 188);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(112, 23);
            this.room1.TabIndex = 1;
            this.room1.Text = "Classroom_1";
            this.room1.UseVisualStyleBackColor = true;
            this.room1.Click += new System.EventHandler(this.room1_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(267, 80);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(96, 23);
            this.clean.TabIndex = 2;
            this.clean.Text = "Clean";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // room2
            // 
            this.room2.Location = new System.Drawing.Point(315, 188);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(112, 23);
            this.room2.TabIndex = 3;
            this.room2.Text = "Classroom_2";
            this.room2.UseVisualStyleBackColor = true;
            this.room2.Click += new System.EventHandler(this.room2_Click);
            // 
            // listClassroom
            // 
            this.listClassroom.FormattingEnabled = true;
            this.listClassroom.ItemHeight = 16;
            this.listClassroom.Location = new System.Drawing.Point(35, 27);
            this.listClassroom.Name = "listClassroom";
            this.listClassroom.Size = new System.Drawing.Size(156, 132);
            this.listClassroom.TabIndex = 4;
            this.listClassroom.SelectedIndexChanged += new System.EventHandler(this.listClassroom_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 258);
            this.Controls.Add(this.listClassroom);
            this.Controls.Add(this.room2);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.room1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button room1;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button room2;
        private System.Windows.Forms.ListBox listClassroom;
    }
}

