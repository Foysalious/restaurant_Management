namespace Restaurant_management.Views
{
    partial class Employee_Panel
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeliveryStatus = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add_Food";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete_Food";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update_Food";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 112);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Employee_panel";
            // 
            // buttonDeliveryStatus
            // 
            this.buttonDeliveryStatus.Location = new System.Drawing.Point(584, 422);
            this.buttonDeliveryStatus.Name = "buttonDeliveryStatus";
            this.buttonDeliveryStatus.Size = new System.Drawing.Size(253, 74);
            this.buttonDeliveryStatus.TabIndex = 5;
            this.buttonDeliveryStatus.Text = "Delivery Status";
            this.buttonDeliveryStatus.UseVisualStyleBackColor = true;
            this.buttonDeliveryStatus.Click += new System.EventHandler(this.ButtonDeliveryStatus_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(584, 540);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "GO BACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Employee_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 651);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonDeliveryStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Employee_Panel";
            this.Text = "Employee_Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeliveryStatus;
        private System.Windows.Forms.Button button5;
    }
}