namespace WindowsFormsApp1
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.residents = new System.Windows.Forms.Button();
            this.pets = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.vehicles = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.Button();
            this.invoices = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(749, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administrator Portal";
            // 
            // residents
            // 
            this.residents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residents.Location = new System.Drawing.Point(180, 149);
            this.residents.Name = "residents";
            this.residents.Size = new System.Drawing.Size(109, 48);
            this.residents.TabIndex = 3;
            this.residents.Text = "Manage Residents";
            this.residents.UseVisualStyleBackColor = true;
            this.residents.Click += new System.EventHandler(this.residents_Click);
            // 
            // pets
            // 
            this.pets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pets.Location = new System.Drawing.Point(332, 149);
            this.pets.Name = "pets";
            this.pets.Size = new System.Drawing.Size(109, 48);
            this.pets.TabIndex = 4;
            this.pets.Text = "Manage Pets";
            this.pets.UseVisualStyleBackColor = true;
            // 
            // employees
            // 
            this.employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees.Location = new System.Drawing.Point(482, 149);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(109, 48);
            this.employees.TabIndex = 5;
            this.employees.Text = "Manage Employees";
            this.employees.UseVisualStyleBackColor = true;
            // 
            // vehicles
            // 
            this.vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicles.Location = new System.Drawing.Point(180, 236);
            this.vehicles.Name = "vehicles";
            this.vehicles.Size = new System.Drawing.Size(109, 48);
            this.vehicles.TabIndex = 6;
            this.vehicles.Text = "Manage Vehicles";
            this.vehicles.UseVisualStyleBackColor = true;
            // 
            // events
            // 
            this.events.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.events.Location = new System.Drawing.Point(332, 236);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(109, 48);
            this.events.TabIndex = 7;
            this.events.Text = "Manage Events";
            this.events.UseVisualStyleBackColor = true;
            // 
            // invoices
            // 
            this.invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoices.Location = new System.Drawing.Point(482, 236);
            this.invoices.Name = "invoices";
            this.invoices.Size = new System.Drawing.Size(109, 48);
            this.invoices.TabIndex = 8;
            this.invoices.Text = "Manage Invoices";
            this.invoices.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(281, 341);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(208, 48);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search);
            this.Controls.Add(this.invoices);
            this.Controls.Add(this.events);
            this.Controls.Add(this.vehicles);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.pets);
            this.Controls.Add(this.residents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button residents;
        private System.Windows.Forms.Button pets;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button vehicles;
        private System.Windows.Forms.Button events;
        private System.Windows.Forms.Button invoices;
        private System.Windows.Forms.Button search;
    }
}

