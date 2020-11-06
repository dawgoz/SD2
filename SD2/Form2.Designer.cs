namespace SD2
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateManualy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter value of deque:\r\n(separate with \',\' or \' \')";
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(223, 207);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(328, 29);
            this.txtValues.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your deque";
            // 
            // btnCreateManualy
            // 
            this.btnCreateManualy.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateManualy.Location = new System.Drawing.Point(226, 311);
            this.btnCreateManualy.Name = "btnCreateManualy";
            this.btnCreateManualy.Size = new System.Drawing.Size(141, 62);
            this.btnCreateManualy.TabIndex = 5;
            this.btnCreateManualy.Text = "Create!";
            this.btnCreateManualy.UseVisualStyleBackColor = true;
            this.btnCreateManualy.Click += new System.EventHandler(this.btnCreateManualy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter size of deque:\r\n(max. 10)";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(223, 125);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(68, 29);
            this.txtSize.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateManualy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Manualy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateManualy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSize;
    }
}