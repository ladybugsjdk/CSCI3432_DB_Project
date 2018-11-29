namespace PinkApartments
{
    partial class EventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUpcoming = new System.Windows.Forms.DataGridView();
            this.dgvPast = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.eventIDBox = new System.Windows.Forms.TextBox();
            this.empIDBox = new System.Windows.Forms.TextBox();
            this.resIDBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcoming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPast)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(923, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upcoming Events";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Past Events";
            // 
            // dgvUpcoming
            // 
            this.dgvUpcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcoming.Location = new System.Drawing.Point(12, 74);
            this.dgvUpcoming.Name = "dgvUpcoming";
            this.dgvUpcoming.RowTemplate.Height = 24;
            this.dgvUpcoming.Size = new System.Drawing.Size(430, 220);
            this.dgvUpcoming.TabIndex = 4;
            this.dgvUpcoming.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUpcoming_RowHeaderMouseClick);
            // 
            // dgvPast
            // 
            this.dgvPast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPast.Location = new System.Drawing.Point(536, 74);
            this.dgvPast.Name = "dgvPast";
            this.dgvPast.RowTemplate.Height = 24;
            this.dgvPast.Size = new System.Drawing.Size(430, 220);
            this.dgvPast.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "EventID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "EmployeeID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "ResidentID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Description";
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(556, 337);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(227, 22);
            this.locationBox.TabIndex = 12;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(556, 388);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(227, 22);
            this.dateBox.TabIndex = 13;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(556, 437);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(227, 22);
            this.descBox.TabIndex = 14;
            // 
            // eventIDBox
            // 
            this.eventIDBox.Location = new System.Drawing.Point(134, 337);
            this.eventIDBox.Name = "eventIDBox";
            this.eventIDBox.Size = new System.Drawing.Size(124, 22);
            this.eventIDBox.TabIndex = 15;
            // 
            // empIDBox
            // 
            this.empIDBox.Location = new System.Drawing.Point(134, 385);
            this.empIDBox.Name = "empIDBox";
            this.empIDBox.Size = new System.Drawing.Size(124, 22);
            this.empIDBox.TabIndex = 16;
            // 
            // resIDBox
            // 
            this.resIDBox.Location = new System.Drawing.Point(134, 437);
            this.resIDBox.Name = "resIDBox";
            this.resIDBox.Size = new System.Drawing.Size(124, 22);
            this.resIDBox.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(230, 493);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 52);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(425, 493);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 52);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 637);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.resIDBox);
            this.Controls.Add(this.empIDBox);
            this.Controls.Add(this.eventIDBox);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPast);
            this.Controls.Add(this.dgvUpcoming);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcoming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUpcoming;
        private System.Windows.Forms.DataGridView dgvPast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.TextBox eventIDBox;
        private System.Windows.Forms.TextBox empIDBox;
        private System.Windows.Forms.TextBox resIDBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}