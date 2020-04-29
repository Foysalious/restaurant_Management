namespace Restaurant_management.Views
{
    partial class UserType
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
            this.ButtonAdmin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1Employee = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonDeliveryman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAdmin
            // 
            this.ButtonAdmin.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdmin.Location = new System.Drawing.Point(249, 36);
            this.ButtonAdmin.Name = "ButtonAdmin";
            this.ButtonAdmin.Size = new System.Drawing.Size(323, 72);
            this.ButtonAdmin.TabIndex = 0;
            this.ButtonAdmin.Text = "Admin_Login";
            this.ButtonAdmin.UseVisualStyleBackColor = true;
            this.ButtonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // button1Employee
            // 
            this.button1Employee.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Employee.Location = new System.Drawing.Point(249, 140);
            this.button1Employee.Name = "button1Employee";
            this.button1Employee.Size = new System.Drawing.Size(323, 72);
            this.button1Employee.TabIndex = 1;
            this.button1Employee.Text = "Employee_Login";
            this.button1Employee.UseVisualStyleBackColor = true;
            this.button1Employee.Click += new System.EventHandler(this.Button1Employee_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.Location = new System.Drawing.Point(249, 242);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(323, 72);
            this.buttonCustomer.TabIndex = 2;
            this.buttonCustomer.Text = "Customer_Login";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.ButtonCustomer_Click);
            // 
            // buttonDeliveryman
            // 
            this.buttonDeliveryman.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeliveryman.Location = new System.Drawing.Point(249, 357);
            this.buttonDeliveryman.Name = "buttonDeliveryman";
            this.buttonDeliveryman.Size = new System.Drawing.Size(323, 72);
            this.buttonDeliveryman.TabIndex = 3;
            this.buttonDeliveryman.Text = "Deliveryman_Login";
            this.buttonDeliveryman.UseVisualStyleBackColor = true;
            this.buttonDeliveryman.Click += new System.EventHandler(this.ButtonDeliveryman_Click);
            // 
            // UserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.buttonDeliveryman);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.button1Employee);
            this.Controls.Add(this.ButtonAdmin);
            this.Name = "UserType";
            this.Text = "UserType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdmin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1Employee;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonDeliveryman;
    }
}