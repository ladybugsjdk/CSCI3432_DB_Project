namespace WindowsFormsApp1
{
    partial class LookUp
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
            this.components = new System.ComponentModel.Container();
            this.lookupResident = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pinkDataSet = new WindowsFormsApp1.PinkDataSet();
            this.pinkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentsTableAdapter = new WindowsFormsApp1.PinkDataSetTableAdapters.ResidentsTableAdapter();
            this.residentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lookupResident
            // 
            this.lookupResident.AutoSize = true;
            this.lookupResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupResident.Location = new System.Drawing.Point(294, 44);
            this.lookupResident.Name = "lookupResident";
            this.lookupResident.Size = new System.Drawing.Size(154, 24);
            this.lookupResident.TabIndex = 1;
            this.lookupResident.Text = "LookUp Resident";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residentIDDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.aptNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.residentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 336);
            this.dataGridView1.TabIndex = 2;
            // 
            // pinkDataSet
            // 
            this.pinkDataSet.DataSetName = "PinkDataSet";
            this.pinkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pinkDataSetBindingSource
            // 
            this.pinkDataSetBindingSource.DataSource = this.pinkDataSet;
            this.pinkDataSetBindingSource.Position = 0;
            // 
            // residentsBindingSource
            // 
            this.residentsBindingSource.DataMember = "Residents";
            this.residentsBindingSource.DataSource = this.pinkDataSetBindingSource;
            // 
            // residentsTableAdapter
            // 
            this.residentsTableAdapter.ClearBeforeFill = true;
            // 
            // residentIDDataGridViewTextBoxColumn
            // 
            this.residentIDDataGridViewTextBoxColumn.DataPropertyName = "ResidentID";
            this.residentIDDataGridViewTextBoxColumn.HeaderText = "ResidentID";
            this.residentIDDataGridViewTextBoxColumn.Name = "residentIDDataGridViewTextBoxColumn";
            this.residentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // aptNumberDataGridViewTextBoxColumn
            // 
            this.aptNumberDataGridViewTextBoxColumn.DataPropertyName = "AptNumber";
            this.aptNumberDataGridViewTextBoxColumn.HeaderText = "AptNumber";
            this.aptNumberDataGridViewTextBoxColumn.Name = "aptNumberDataGridViewTextBoxColumn";
            // 
            // LookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lookupResident);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LookUp";
            this.Text = "LookUp";
            this.Load += new System.EventHandler(this.LookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lookupResident;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pinkDataSetBindingSource;
        private PinkDataSet pinkDataSet;
        private System.Windows.Forms.BindingSource residentsBindingSource;
        private PinkDataSetTableAdapters.ResidentsTableAdapter residentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptNumberDataGridViewTextBoxColumn;
    }
}