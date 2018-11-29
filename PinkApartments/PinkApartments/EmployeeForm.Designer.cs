namespace PinkApartments
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empidBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hiredateBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.jobBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Employees";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(872, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // empidBox
            // 
            this.empidBox.Location = new System.Drawing.Point(117, 86);
            this.empidBox.Name = "empidBox";
            this.empidBox.ReadOnly = true;
            this.empidBox.Size = new System.Drawing.Size(159, 22);
            this.empidBox.TabIndex = 3;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(117, 168);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(159, 22);
            this.fnameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(117, 225);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(159, 22);
            this.lnameBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(117, 282);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(159, 22);
            this.emailBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // hiredateBox
            // 
            this.hiredateBox.Location = new System.Drawing.Point(117, 340);
            this.hiredateBox.Name = "hiredateBox";
            this.hiredateBox.Size = new System.Drawing.Size(159, 22);
            this.hiredateBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hire Date";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(117, 395);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(159, 22);
            this.salaryBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salary";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(61, 449);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 41);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add Employee";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(250, 449);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(137, 41);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Update Employee";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(298, 96);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(607, 304);
            this.dgvEmployee.TabIndex = 16;
            this.dgvEmployee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployee_RowHeaderMouseClick);
            // 
            // jobBox
            // 
            this.jobBox.Location = new System.Drawing.Point(117, 128);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(159, 22);
            this.jobBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Job Title";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 518);
            this.Controls.Add(this.jobBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hiredateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empidBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empidBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hiredateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox jobBox;
        private System.Windows.Forms.Label label8;
    }
}