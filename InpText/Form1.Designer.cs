namespace InpText
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
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtInputChar = new System.Windows.Forms.TextBox();
            this.btnListWord = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbltxt = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(80, 61);
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(100, 22);
            this.txtInputText.TabIndex = 0;
            this.txtInputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputText_KeyPress);
            this.txtInputText.MouseHover += new System.EventHandler(this.txtInputText_MouseHover);
            // 
            // txtInputChar
            // 
            this.txtInputChar.Location = new System.Drawing.Point(80, 103);
            this.txtInputChar.MaxLength = 1;
            this.txtInputChar.Name = "txtInputChar";
            this.txtInputChar.Size = new System.Drawing.Size(100, 22);
            this.txtInputChar.TabIndex = 1;
            this.txtInputChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputText_KeyPress);
            this.txtInputChar.MouseHover += new System.EventHandler(this.txtInputChar_MouseHover);
            // 
            // btnListWord
            // 
            this.btnListWord.Location = new System.Drawing.Point(12, 157);
            this.btnListWord.Name = "btnListWord";
            this.btnListWord.Size = new System.Drawing.Size(75, 37);
            this.btnListWord.TabIndex = 2;
            this.btnListWord.Tag = "1";
            this.btnListWord.Text = "لیست کلمات";
            this.btnListWord.UseVisualStyleBackColor = true;
            this.btnListWord.Click += new System.EventHandler(this.btnListWord_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(88, 157);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(83, 37);
            this.btnChar.TabIndex = 2;
            this.btnChar.Tag = "2";
            this.btnChar.Text = "تعداد حرف";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(174, 157);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(82, 37);
            this.btnWord.TabIndex = 2;
            this.btnWord.Tag = "3";
            this.btnWord.Text = "تعداد کلمه";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 87);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 16);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "..........";
            this.lblResult.Visible = false;
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(197, 61);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(24, 16);
            this.lbltxt.TabIndex = 4;
            this.lbltxt.Text = "متن";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(197, 109);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(44, 16);
            this.lblChar.TabIndex = 4;
            this.lblChar.Text = "کارکتر";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 219);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btnListWord);
            this.Controls.Add(this.txtInputChar);
            this.Controls.Add(this.txtInputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtInputChar;
        private System.Windows.Forms.Button btnListWord;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblChar;
    }
}

