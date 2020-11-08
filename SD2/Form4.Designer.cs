namespace SD2
{
    partial class Form4
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
            this.btnEmpty = new System.Windows.Forms.Button();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblFull = new System.Windows.Forms.Label();
            this.btnFull = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReadFirstLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPalindrome = new System.Windows.Forms.Label();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.txtInsertFirst = new System.Windows.Forms.TextBox();
            this.btnInsertFirst = new System.Windows.Forms.Button();
            this.btnInsertLast = new System.Windows.Forms.Button();
            this.txtInsertLast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(192, 36);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(167, 43);
            this.btnEmpty.TabIndex = 0;
            this.btnEmpty.Text = "Is deque empty";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Location = new System.Drawing.Point(50, 45);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(0, 25);
            this.lblEmpty.TabIndex = 1;
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.Location = new System.Drawing.Point(50, 111);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(0, 25);
            this.lblFull.TabIndex = 3;
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(192, 102);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(167, 43);
            this.btnFull.TabIndex = 2;
            this.btnFull.Text = "Is deque full";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(50, 176);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 25);
            this.lblSize.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check size";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(631, 36);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(139, 43);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read deque";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnReadFirstLast
            // 
            this.btnReadFirstLast.Location = new System.Drawing.Point(631, 142);
            this.btnReadFirstLast.Name = "btnReadFirstLast";
            this.btnReadFirstLast.Size = new System.Drawing.Size(139, 68);
            this.btnReadFirstLast.TabIndex = 8;
            this.btnReadFirstLast.Text = "Read first and last elements";
            this.btnReadFirstLast.UseVisualStyleBackColor = true;
            this.btnReadFirstLast.Click += new System.EventHandler(this.btnReadFirstLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "First:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(488, 142);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 25);
            this.lblFirst.TabIndex = 11;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(488, 185);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(0, 25);
            this.lblLast.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 77);
            this.button2.TabIndex = 13;
            this.button2.Text = "Is deque a palindrome";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPalindrome
            // 
            this.lblPalindrome.AutoSize = true;
            this.lblPalindrome.Location = new System.Drawing.Point(50, 255);
            this.lblPalindrome.Name = "lblPalindrome";
            this.lblPalindrome.Size = new System.Drawing.Size(0, 25);
            this.lblPalindrome.TabIndex = 14;
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(408, 36);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(193, 73);
            this.txtRead.TabIndex = 15;
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.Location = new System.Drawing.Point(413, 261);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(144, 41);
            this.btnDeleteFirst.TabIndex = 16;
            this.btnDeleteFirst.Text = "Delete First";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // btnDeleteLast
            // 
            this.btnDeleteLast.Location = new System.Drawing.Point(626, 261);
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.Size = new System.Drawing.Size(144, 41);
            this.btnDeleteLast.TabIndex = 17;
            this.btnDeleteLast.Text = "Delete Last";
            this.btnDeleteLast.UseVisualStyleBackColor = true;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click);
            // 
            // txtInsertFirst
            // 
            this.txtInsertFirst.Location = new System.Drawing.Point(417, 371);
            this.txtInsertFirst.Name = "txtInsertFirst";
            this.txtInsertFirst.Size = new System.Drawing.Size(144, 29);
            this.txtInsertFirst.TabIndex = 18;
            // 
            // btnInsertFirst
            // 
            this.btnInsertFirst.Location = new System.Drawing.Point(626, 363);
            this.btnInsertFirst.Name = "btnInsertFirst";
            this.btnInsertFirst.Size = new System.Drawing.Size(144, 46);
            this.btnInsertFirst.TabIndex = 19;
            this.btnInsertFirst.Text = "Insert First";
            this.btnInsertFirst.UseVisualStyleBackColor = true;
            this.btnInsertFirst.Click += new System.EventHandler(this.btnInsertFirst_Click);
            // 
            // btnInsertLast
            // 
            this.btnInsertLast.Location = new System.Drawing.Point(626, 423);
            this.btnInsertLast.Name = "btnInsertLast";
            this.btnInsertLast.Size = new System.Drawing.Size(144, 46);
            this.btnInsertLast.TabIndex = 21;
            this.btnInsertLast.Text = "Insert Last";
            this.btnInsertLast.UseVisualStyleBackColor = true;
            this.btnInsertLast.Click += new System.EventHandler(this.btnInsertLast_Click);
            // 
            // txtInsertLast
            // 
            this.txtInsertLast.Location = new System.Drawing.Point(417, 431);
            this.txtInsertLast.Name = "txtInsertLast";
            this.txtInsertLast.Size = new System.Drawing.Size(144, 29);
            this.txtInsertLast.TabIndex = 20;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 491);
            this.Controls.Add(this.btnInsertLast);
            this.Controls.Add(this.txtInsertLast);
            this.Controls.Add(this.btnInsertFirst);
            this.Controls.Add(this.txtInsertFirst);
            this.Controls.Add(this.btnDeleteLast);
            this.Controls.Add(this.btnDeleteFirst);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.lblPalindrome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadFirstLast);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.btnEmpty);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnReadFirstLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPalindrome;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Button btnDeleteFirst;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.TextBox txtInsertFirst;
        private System.Windows.Forms.Button btnInsertFirst;
        private System.Windows.Forms.Button btnInsertLast;
        private System.Windows.Forms.TextBox txtInsertLast;
    }
}