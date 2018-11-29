namespace PinkApartments
{
    partial class PetandVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetandVehicleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectViewBox = new System.Windows.Forms.ComboBox();
            this.dgvPetVeh = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resid1Box = new System.Windows.Forms.TextBox();
            this.breedBox = new System.Windows.Forms.TextBox();
            this.speciesBox = new System.Windows.Forms.TextBox();
            this.regdateBox = new System.Windows.Forms.TextBox();
            this.paydateBox = new System.Windows.Forms.TextBox();
            this.addPetBtn = new System.Windows.Forms.Button();
            this.updatePetBtn = new System.Windows.Forms.Button();
            this.deletePetBtn = new System.Windows.Forms.Button();
            this.delVehBtn = new System.Windows.Forms.Button();
            this.updateVehBtn = new System.Windows.Forms.Button();
            this.addVehBtn = new System.Windows.Forms.Button();
            this.regivehicleBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.makeBox = new System.Windows.Forms.TextBox();
            this.lienseBox = new System.Windows.Forms.TextBox();
            this.resid2Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.decalBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.showDGV = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.clearPetBtn = new System.Windows.Forms.Button();
            this.clearVehBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetVeh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Pets and Vehicles";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select One:";
            // 
            // selectViewBox
            // 
            this.selectViewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectViewBox.FormattingEnabled = true;
            this.selectViewBox.Items.AddRange(new object[] {
            "Pets",
            "ResidentVehicles"});
            this.selectViewBox.Location = new System.Drawing.Point(270, 62);
            this.selectViewBox.Name = "selectViewBox";
            this.selectViewBox.Size = new System.Drawing.Size(200, 28);
            this.selectViewBox.TabIndex = 3;
            // 
            // dgvPetVeh
            // 
            this.dgvPetVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetVeh.Location = new System.Drawing.Point(73, 111);
            this.dgvPetVeh.Name = "dgvPetVeh";
            this.dgvPetVeh.RowTemplate.Height = 24;
            this.dgvPetVeh.Size = new System.Drawing.Size(638, 202);
            this.dgvPetVeh.TabIndex = 4;
            this.dgvPetVeh.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPetVeh_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ResidentID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Breed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Species";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Registration Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Payment Date";
            // 
            // resid1Box
            // 
            this.resid1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resid1Box.Location = new System.Drawing.Point(182, 351);
            this.resid1Box.Name = "resid1Box";
            this.resid1Box.Size = new System.Drawing.Size(116, 27);
            this.resid1Box.TabIndex = 11;
            // 
            // breedBox
            // 
            this.breedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breedBox.Location = new System.Drawing.Point(182, 384);
            this.breedBox.Name = "breedBox";
            this.breedBox.Size = new System.Drawing.Size(164, 27);
            this.breedBox.TabIndex = 12;
            // 
            // speciesBox
            // 
            this.speciesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciesBox.Location = new System.Drawing.Point(182, 418);
            this.speciesBox.Name = "speciesBox";
            this.speciesBox.Size = new System.Drawing.Size(164, 27);
            this.speciesBox.TabIndex = 13;
            // 
            // regdateBox
            // 
            this.regdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regdateBox.Location = new System.Drawing.Point(182, 451);
            this.regdateBox.Name = "regdateBox";
            this.regdateBox.Size = new System.Drawing.Size(164, 27);
            this.regdateBox.TabIndex = 14;
            // 
            // paydateBox
            // 
            this.paydateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paydateBox.Location = new System.Drawing.Point(182, 484);
            this.paydateBox.Name = "paydateBox";
            this.paydateBox.Size = new System.Drawing.Size(164, 27);
            this.paydateBox.TabIndex = 15;
            // 
            // addPetBtn
            // 
            this.addPetBtn.BackColor = System.Drawing.Color.LightCoral;
            this.addPetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPetBtn.Location = new System.Drawing.Point(37, 532);
            this.addPetBtn.Name = "addPetBtn";
            this.addPetBtn.Size = new System.Drawing.Size(142, 44);
            this.addPetBtn.TabIndex = 16;
            this.addPetBtn.Text = "Add Pet";
            this.addPetBtn.UseVisualStyleBackColor = false;
            this.addPetBtn.Click += new System.EventHandler(this.addPetBtn_Click);
            // 
            // updatePetBtn
            // 
            this.updatePetBtn.BackColor = System.Drawing.Color.LightCoral;
            this.updatePetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePetBtn.Location = new System.Drawing.Point(204, 532);
            this.updatePetBtn.Name = "updatePetBtn";
            this.updatePetBtn.Size = new System.Drawing.Size(142, 44);
            this.updatePetBtn.TabIndex = 17;
            this.updatePetBtn.Text = "Update Pet";
            this.updatePetBtn.UseVisualStyleBackColor = false;
            this.updatePetBtn.Click += new System.EventHandler(this.updatePetBtn_Click);
            // 
            // deletePetBtn
            // 
            this.deletePetBtn.BackColor = System.Drawing.Color.LightCoral;
            this.deletePetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePetBtn.Location = new System.Drawing.Point(37, 595);
            this.deletePetBtn.Name = "deletePetBtn";
            this.deletePetBtn.Size = new System.Drawing.Size(142, 44);
            this.deletePetBtn.TabIndex = 18;
            this.deletePetBtn.Text = "Delete Pet";
            this.deletePetBtn.UseVisualStyleBackColor = false;
            this.deletePetBtn.Click += new System.EventHandler(this.deletePetBtn_Click);
            // 
            // delVehBtn
            // 
            this.delVehBtn.BackColor = System.Drawing.Color.LightCoral;
            this.delVehBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVehBtn.Location = new System.Drawing.Point(440, 717);
            this.delVehBtn.Name = "delVehBtn";
            this.delVehBtn.Size = new System.Drawing.Size(142, 44);
            this.delVehBtn.TabIndex = 32;
            this.delVehBtn.Text = "Delete Vehicle";
            this.delVehBtn.UseVisualStyleBackColor = false;
            this.delVehBtn.Click += new System.EventHandler(this.delVehBtn_Click);
            // 
            // updateVehBtn
            // 
            this.updateVehBtn.BackColor = System.Drawing.Color.LightCoral;
            this.updateVehBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVehBtn.Location = new System.Drawing.Point(619, 650);
            this.updateVehBtn.Name = "updateVehBtn";
            this.updateVehBtn.Size = new System.Drawing.Size(142, 44);
            this.updateVehBtn.TabIndex = 31;
            this.updateVehBtn.Text = "Update Vehicle";
            this.updateVehBtn.UseVisualStyleBackColor = false;
            this.updateVehBtn.Click += new System.EventHandler(this.updateVehBtn_Click);
            // 
            // addVehBtn
            // 
            this.addVehBtn.BackColor = System.Drawing.Color.LightCoral;
            this.addVehBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehBtn.Location = new System.Drawing.Point(440, 650);
            this.addVehBtn.Name = "addVehBtn";
            this.addVehBtn.Size = new System.Drawing.Size(142, 44);
            this.addVehBtn.TabIndex = 30;
            this.addVehBtn.Text = "Add Vehicle";
            this.addVehBtn.UseVisualStyleBackColor = false;
            this.addVehBtn.Click += new System.EventHandler(this.addVehBtn_Click);
            // 
            // regivehicleBox
            // 
            this.regivehicleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regivehicleBox.Location = new System.Drawing.Point(567, 531);
            this.regivehicleBox.Name = "regivehicleBox";
            this.regivehicleBox.Size = new System.Drawing.Size(164, 27);
            this.regivehicleBox.TabIndex = 29;
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.Location = new System.Drawing.Point(567, 496);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(164, 27);
            this.modelBox.TabIndex = 28;
            // 
            // makeBox
            // 
            this.makeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBox.Location = new System.Drawing.Point(567, 451);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(164, 27);
            this.makeBox.TabIndex = 27;
            // 
            // lienseBox
            // 
            this.lienseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lienseBox.Location = new System.Drawing.Point(567, 406);
            this.lienseBox.Name = "lienseBox";
            this.lienseBox.Size = new System.Drawing.Size(164, 27);
            this.lienseBox.TabIndex = 26;
            // 
            // resid2Box
            // 
            this.resid2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resid2Box.Location = new System.Drawing.Point(567, 366);
            this.resid2Box.Name = "resid2Box";
            this.resid2Box.Size = new System.Drawing.Size(116, 27);
            this.resid2Box.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Registration Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 493);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Model";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(497, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Make";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(435, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "License Plate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(454, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "ResidentID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(420, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 29);
            this.label14.TabIndex = 19;
            this.label14.Text = "Vehicles";
            // 
            // decalBox
            // 
            this.decalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decalBox.Location = new System.Drawing.Point(567, 568);
            this.decalBox.Name = "decalBox";
            this.decalBox.Size = new System.Drawing.Size(164, 27);
            this.decalBox.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(436, 568);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Decal Sticker";
            // 
            // showDGV
            // 
            this.showDGV.BackColor = System.Drawing.Color.LightCoral;
            this.showDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDGV.Location = new System.Drawing.Point(477, 51);
            this.showDGV.Name = "showDGV";
            this.showDGV.Size = new System.Drawing.Size(142, 44);
            this.showDGV.TabIndex = 35;
            this.showDGV.Text = "Show";
            this.showDGV.UseVisualStyleBackColor = false;
            this.showDGV.Click += new System.EventHandler(this.showDGV_Click);
            // 
            // colorBox
            // 
            this.colorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBox.Location = new System.Drawing.Point(567, 607);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(164, 27);
            this.colorBox.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(497, 607);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Color";
            // 
            // clearPetBtn
            // 
            this.clearPetBtn.BackColor = System.Drawing.Color.LightCoral;
            this.clearPetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPetBtn.Location = new System.Drawing.Point(204, 595);
            this.clearPetBtn.Name = "clearPetBtn";
            this.clearPetBtn.Size = new System.Drawing.Size(142, 44);
            this.clearPetBtn.TabIndex = 38;
            this.clearPetBtn.Text = "Clear Form";
            this.clearPetBtn.UseVisualStyleBackColor = false;
            this.clearPetBtn.Click += new System.EventHandler(this.clearPetBtn_Click);
            // 
            // clearVehBtn
            // 
            this.clearVehBtn.BackColor = System.Drawing.Color.LightCoral;
            this.clearVehBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearVehBtn.Location = new System.Drawing.Point(619, 717);
            this.clearVehBtn.Name = "clearVehBtn";
            this.clearVehBtn.Size = new System.Drawing.Size(142, 44);
            this.clearVehBtn.TabIndex = 39;
            this.clearVehBtn.Text = "Clear Form";
            this.clearVehBtn.UseVisualStyleBackColor = false;
            this.clearVehBtn.Click += new System.EventHandler(this.clearVehBtn_Click);
            // 
            // PetandVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(823, 786);
            this.Controls.Add(this.clearVehBtn);
            this.Controls.Add(this.clearPetBtn);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.showDGV);
            this.Controls.Add(this.decalBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.delVehBtn);
            this.Controls.Add(this.updateVehBtn);
            this.Controls.Add(this.addVehBtn);
            this.Controls.Add(this.regivehicleBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.makeBox);
            this.Controls.Add(this.lienseBox);
            this.Controls.Add(this.resid2Box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.deletePetBtn);
            this.Controls.Add(this.updatePetBtn);
            this.Controls.Add(this.addPetBtn);
            this.Controls.Add(this.paydateBox);
            this.Controls.Add(this.regdateBox);
            this.Controls.Add(this.speciesBox);
            this.Controls.Add(this.breedBox);
            this.Controls.Add(this.resid1Box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPetVeh);
            this.Controls.Add(this.selectViewBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetandVehicleForm";
            this.Text = "PetandVehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetVeh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectViewBox;
        private System.Windows.Forms.DataGridView dgvPetVeh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resid1Box;
        private System.Windows.Forms.TextBox breedBox;
        private System.Windows.Forms.TextBox speciesBox;
        private System.Windows.Forms.TextBox regdateBox;
        private System.Windows.Forms.TextBox paydateBox;
        private System.Windows.Forms.Button addPetBtn;
        private System.Windows.Forms.Button updatePetBtn;
        private System.Windows.Forms.Button deletePetBtn;
        private System.Windows.Forms.Button delVehBtn;
        private System.Windows.Forms.Button updateVehBtn;
        private System.Windows.Forms.Button addVehBtn;
        private System.Windows.Forms.TextBox regivehicleBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox makeBox;
        private System.Windows.Forms.TextBox lienseBox;
        private System.Windows.Forms.TextBox resid2Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox decalBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button showDGV;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button clearPetBtn;
        private System.Windows.Forms.Button clearVehBtn;
    }
}