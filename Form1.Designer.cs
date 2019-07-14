namespace AlgoritmTask3
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(12, 22);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(136, 20);
            this.firstNumberTextBox.TabIndex = 0;
            this.firstNumberTextBox.Text = "Introduce the first number";
            this.firstNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FirstNumberTextBox_MouseClick_1);
            this.firstNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNumberTextBox_KeyPress);
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(12, 73);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(136, 20);
            this.secondNumberTextBox.TabIndex = 1;
            this.secondNumberTextBox.Text = "Introduce the divisor";
            this.secondNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SecondNumberTextBox_MouseClick_1);
            this.secondNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondNumberTextBox_KeyPress);
            // 
            // OkBtn
            // 
            this.OkBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.OkBtn.Location = new System.Drawing.Point(107, 126);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.closeBtn.Location = new System.Drawing.Point(12, 126);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 161);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button closeBtn;
        public System.Windows.Forms.TextBox firstNumberTextBox;
        public System.Windows.Forms.TextBox secondNumberTextBox;
    }
}

