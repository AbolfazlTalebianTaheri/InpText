namespace InpText
{
    partial class FrmAdd
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.cmbGgender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(61, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(191, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtlastName
            // 
            this.txtlastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlastName.Location = new System.Drawing.Point(61, 80);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(100, 22);
            this.txtlastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(191, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "LastName";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalCode.Location = new System.Drawing.Point(61, 131);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(100, 22);
            this.txtNationalCode.TabIndex = 2;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(191, 137);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(90, 16);
            this.lblNationalCode.TabIndex = 1;
            this.lblNationalCode.Text = "NationalCode";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(191, 181);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender";
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmation.Location = new System.Drawing.Point(83, 222);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(93, 40);
            this.btnConfirmation.TabIndex = 5;
            this.btnConfirmation.Text = "Confirmation";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // cmbGgender
            // 
            this.cmbGgender.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.cmbGgender.FormattingEnabled = true;
            this.cmbGgender.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.cmbGgender.Location = new System.Drawing.Point(55, 181);
            this.cmbGgender.Name = "cmbGgender";
            this.cmbGgender.Size = new System.Drawing.Size(121, 24);
            this.cmbGgender.TabIndex = 4;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 284);
            this.Controls.Add(this.cmbGgender);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(this.txtName);
            this.Name = "FrmAdd";
            this.Text = "FrmAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.ComboBox cmbGgender;
    }
}