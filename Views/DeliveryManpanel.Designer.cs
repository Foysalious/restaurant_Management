namespace Restaurant_management.Views
{
    partial class DeliveryManpanel
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
            this.dataGridOrderFood = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrderno = new System.Windows.Forms.TextBox();
            this.textBoxDstatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrderFood
            // 
            this.dataGridOrderFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderFood.Location = new System.Drawing.Point(65, 2);
            this.dataGridOrderFood.Name = "dataGridOrderFood";
            this.dataGridOrderFood.Size = new System.Drawing.Size(860, 484);
            this.dataGridOrderFood.TabIndex = 1;
            this.dataGridOrderFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOrderFood_CellClick);
            this.dataGridOrderFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridOrderFood.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditUser);
            this.dataGridOrderFood.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.Rowchanage);
            this.dataGridOrderFood.SelectionChanged += new System.EventHandler(this.SelectionChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(962, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order No:";
            // 
            // textBoxOrderno
            // 
            this.textBoxOrderno.Location = new System.Drawing.Point(1047, 176);
            this.textBoxOrderno.Name = "textBoxOrderno";
            this.textBoxOrderno.Size = new System.Drawing.Size(203, 20);
            this.textBoxOrderno.TabIndex = 3;
            // 
            // textBoxDstatus
            // 
            this.textBoxDstatus.Location = new System.Drawing.Point(1047, 212);
            this.textBoxDstatus.Name = "textBoxDstatus";
            this.textBoxDstatus.Size = new System.Drawing.Size(203, 20);
            this.textBoxDstatus.TabIndex = 5;
            this.textBoxDstatus.TextChanged += new System.EventHandler(this.TextBoxDstatus_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(931, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delivery Status :";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(1106, 265);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1014, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DeliveryManpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxDstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOrderno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOrderFood);
            this.Name = "DeliveryManpanel";
            this.Text = "DeliveryManpanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridOrderFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrderno;
        private System.Windows.Forms.TextBox textBoxDstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button button1;
    }
}