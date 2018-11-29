namespace PinkApartments.PinkClasses
{
    partial class ResidentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.residBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvResident = new System.Windows.Forms.DataGridView();
            this.addResBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.empidBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResident)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Residents";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(850, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resident ID";
            // 
            // residBox
            // 
            this.residBox.Location = new System.Drawing.Point(151, 110);
            this.residBox.Name = "residBox";
            this.residBox.ReadOnly = true;
            this.residBox.Size = new System.Drawing.Size(183, 22);
            this.residBox.TabIndex = 3;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(151, 208);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(183, 22);
            this.fnameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(151, 268);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(183, 22);
            this.lnameBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(151, 325);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(183, 22);
            this.emailBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(151, 377);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(183, 22);
            this.phoneBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone";
            // 
            // dgvResident
            // 
            this.dgvResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResident.Location = new System.Drawing.Point(355, 110);
            this.dgvResident.Name = "dgvResident";
            this.dgvResident.RowTemplate.Height = 24;
            this.dgvResident.Size = new System.Drawing.Size(533, 292);
            this.dgvResident.TabIndex = 12;
            this.dgvResident.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResident_RowHeaderMouseClick);
            // 
            // addResBtn
            // 
            this.addResBtn.Location = new System.Drawing.Point(77, 446);
            this.addResBtn.Name = "addResBtn";
            this.addResBtn.Size = new System.Drawing.Size(141, 58);
            this.addResBtn.TabIndex = 13;
            this.addResBtn.Text = "Add Resident";
            this.addResBtn.UseVisualStyleBackColor = true;
            this.addResBtn.Click += new System.EventHandler(this.addResBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update Resident";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // empidBox
            // 
            this.empidBox.Location = new System.Drawing.Point(150, 160);
            this.empidBox.Name = "empidBox";
            this.empidBox.Size = new System.Drawing.Size(183, 22);
            this.empidBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Employee ID";
            // 
            // ResidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 526);
            this.Controls.Add(this.empidBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addResBtn);
            this.Controls.Add(this.dgvResident);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.residBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResidentForm";
            this.Text = "ResidentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox residBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvResident;
        private System.Windows.Forms.Button addResBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox empidBox;
        private System.Windows.Forms.Label label7;
    }
}