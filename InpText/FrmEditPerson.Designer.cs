namespace InpText
{
    partial class FrmEditPerson
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
            this.cmbGgender = new System.Windows.Forms.ComboBox();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbGgender
            // 
            this.cmbGgender.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.cmbGgender.FormattingEnabled = true;
            this.cmbGgender.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.cmbGgender.Location = new System.Drawing.Point(47, 185);
            this.cmbGgender.Name = "cmbGgender";
            this.cmbGgender.Size = new System.Drawing.Size(121, 24);
            this.cmbGgender.TabIndex = 4;
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmation.Enabled = false;
            this.btnConfirmation.Location = new System.Drawing.Point(75, 226);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(93, 40);
            this.btnConfirmation.TabIndex = 5;
            this.btnConfirmation.Text = "Confirmation";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(183, 185);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(183, 141);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(90, 16);
            this.lblNationalCode.TabIndex = 8;
            this.lblNationalCode.Text = "NationalCode";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(183, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 16);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "LastName";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(183, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalCode.Location = new System.Drawing.Point(53, 135);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(100, 22);
            this.txtNationalCode.TabIndex = 3;
            this.txtNationalCode.TextChanged += new System.EventHandler(this.txtNationalCode_TextChanged);
            this.txtNationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalCode_KeyPress);
            // 
            // txtlastName
            // 
            this.txtlastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlastName.Location = new System.Drawing.Point(53, 84);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(100, 22);
            this.txtlastName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(53, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // FrmEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 305);
            this.Controls.Add(this.cmbGgender);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(this.txtName);
            this.Name = "FrmEditPerson";
            this.Text = "FrmEditPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGgender;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtName;
    }
}