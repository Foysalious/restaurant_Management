namespace Restaurant_management.Views
{
    partial class AddDeleviryman
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
            this.textBoxConpass = new System.Windows.Forms.TextBox();
            this.labelConpass = new System.Windows.Forms.Label();
            this.groupBoxGander = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelCusPass = new System.Windows.Forms.Label();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCusName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxGander.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConpass
            // 
            this.textBoxConpass.Location = new System.Drawing.Point(291, 314);
            this.textBoxConpass.Name = "textBoxConpass";
            this.textBoxConpass.Size = new System.Drawing.Size(229, 20);
            this.textBoxConpass.TabIndex = 54;
            this.textBoxConpass.UseSystemPasswordChar = true;
            // 
            // labelConpass
            // 
            this.labelConpass.AutoSize = true;
            this.labelConpass.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelConpass.Location = new System.Drawing.Point(39, 314);
            this.labelConpass.Name = "labelConpass";
            this.labelConpass.Size = new System.Drawing.Size(230, 31);
            this.labelConpass.TabIndex = 53;
            this.labelConpass.Text = "Confirm Password   :";
            // 
            // groupBoxGander
            // 
            this.groupBoxGander.Controls.Add(this.radioFemale);
            this.groupBoxGander.Controls.Add(this.radioMale);
            this.groupBoxGander.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxGander.Location = new System.Drawing.Point(738, 233);
            this.groupBoxGander.Name = "groupBoxGander";
            this.groupBoxGander.Size = new System.Drawing.Size(155, 81);
            this.groupBoxGander.TabIndex = 52;
            this.groupBoxGander.TabStop = false;
            this.groupBoxGander.Text = "groupBoxGender";
            this.groupBoxGander.Enter += new System.EventHandler(this.GroupBoxGander_Enter);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioFemale.Location = new System.Drawing.Point(39, 43);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(108, 38);
            this.radioFemale.TabIndex = 14;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioMale.Location = new System.Drawing.Point(40, 9);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(85, 38);
            this.radioMale.TabIndex = 12;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Silver;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(770, 429);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(105, 64);
            this.buttonConfirm.TabIndex = 51;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(601, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 34);
            this.label1.TabIndex = 50;
            this.label1.Text = "Gander :";
            this.label1.UseWaitCursor = true;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(291, 233);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(229, 20);
            this.textBoxname.TabIndex = 49;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(168, 233);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(101, 31);
            this.labelName.TabIndex = 48;
            this.labelName.Text = "Name   :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Matura MT Script Capitals", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label.Location = new System.Drawing.Point(227, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(838, 85);
            this.label.TabIndex = 0;
            this.label.Text = "Deliveryman Signup Form";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(291, 448);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(229, 20);
            this.textBoxEmail.TabIndex = 47;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmail.Location = new System.Drawing.Point(163, 440);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(106, 31);
            this.labelEmail.TabIndex = 46;
            this.labelEmail.Text = "Email   :";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(291, 397);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(229, 20);
            this.textBoxPhone.TabIndex = 45;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPhone.Location = new System.Drawing.Point(168, 397);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(101, 31);
            this.labelPhone.TabIndex = 44;
            this.labelPhone.Text = "Phone  :";
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(291, 356);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(229, 20);
            this.textBoxaddress.TabIndex = 43;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAddress.Location = new System.Drawing.Point(149, 356);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(120, 31);
            this.labelAddress.TabIndex = 42;
            this.labelAddress.Text = "Address   :";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(291, 274);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(229, 20);
            this.textBoxPass.TabIndex = 41;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // labelCusPass
            // 
            this.labelCusPass.AutoSize = true;
            this.labelCusPass.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCusPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCusPass.Location = new System.Drawing.Point(131, 274);
            this.labelCusPass.Name = "labelCusPass";
            this.labelCusPass.Size = new System.Drawing.Size(138, 31);
            this.labelCusPass.TabIndex = 40;
            this.labelCusPass.Text = "Password   :";
            // 
            // textBoxUname
            // 
            this.textBoxUname.Location = new System.Drawing.Point(291, 203);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(229, 20);
            this.textBoxUname.TabIndex = 39;
            this.textBoxUname.TextChanged += new System.EventHandler(this.TextBoxUname_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(-190, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 141);
            this.panel1.TabIndex = 37;
            // 
            // labelCusName
            // 
            this.labelCusName.AutoSize = true;
            this.labelCusName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCusName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCusName.Location = new System.Drawing.Point(128, 194);
            this.labelCusName.Name = "labelCusName";
            this.labelCusName.Size = new System.Drawing.Size(142, 33);
            this.labelCusName.TabIndex = 38;
            this.labelCusName.Text = "Username   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(103, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 33);
            this.label2.TabIndex = 56;
            this.label2.Text = "Date of Birth  :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 493);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(629, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 64);
            this.button1.TabIndex = 57;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddDeleviryman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(941, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxConpass);
            this.Controls.Add(this.labelConpass);
            this.Controls.Add(this.groupBoxGander);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelCusPass);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCusName);
            this.Name = "AddDeleviryman";
            this.Text = "AddDeleviryman";
            this.groupBoxGander.ResumeLayout(false);
            this.groupBoxGander.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConpass;
        private System.Windows.Forms.Label labelConpass;
        private System.Windows.Forms.GroupBox groupBoxGander;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelCusPass;
        private System.Windows.Forms.TextBox textBoxUname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}