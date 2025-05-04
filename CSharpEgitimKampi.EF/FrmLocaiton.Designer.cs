namespace CSharpEgitimKampi.EF
{
    partial class FrmLocaiton
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCtry = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLokasyonId = new System.Windows.Forms.Label();
            this.txtCapacite = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.Label();
            this.textDandN = new System.Windows.Forms.TextBox();
            this.txtDayNight = new System.Windows.Forms.Label();
            this.txtGuide = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbmGuide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(63, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 36);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(63, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 36);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Çıkar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(63, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 36);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCtry
            // 
            this.txtCtry.Location = new System.Drawing.Point(126, 107);
            this.txtCtry.Name = "txtCtry";
            this.txtCtry.Size = new System.Drawing.Size(161, 22);
            this.txtCtry.TabIndex = 19;
            // 
            // txtCountry
            // 
            this.txtCountry.AutoSize = true;
            this.txtCountry.Location = new System.Drawing.Point(77, 110);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(35, 16);
            this.txtCountry.TabIndex = 18;
            this.txtCountry.Text = "Ülke";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 22);
            this.txtName.TabIndex = 17;
            // 
            // txtCity
            // 
            this.txtCity.AutoSize = true;
            this.txtCity.Location = new System.Drawing.Point(74, 77);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(38, 16);
            this.txtCity.TabIndex = 16;
            this.txtCity.Text = "Şehir";
            this.txtCity.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 385);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnList.Location = new System.Drawing.Point(63, 286);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(161, 36);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(126, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 22);
            this.txtId.TabIndex = 13;
            // 
            // txtLokasyonId
            // 
            this.txtLokasyonId.AutoSize = true;
            this.txtLokasyonId.Location = new System.Drawing.Point(32, 40);
            this.txtLokasyonId.Name = "txtLokasyonId";
            this.txtLokasyonId.Size = new System.Drawing.Size(80, 16);
            this.txtLokasyonId.TabIndex = 12;
            this.txtLokasyonId.Text = "Lokasyon Id\r\n";
            this.txtLokasyonId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCapacite
            // 
            this.txtCapacite.AutoSize = true;
            this.txtCapacite.Location = new System.Drawing.Point(52, 150);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(60, 16);
            this.txtCapacite.TabIndex = 25;
            this.txtCapacite.Text = "Kapasite";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(76, 190);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(36, 16);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.Text = "Fiyat";
            // 
            // textDandN
            // 
            this.textDandN.Location = new System.Drawing.Point(126, 222);
            this.textDandN.Name = "textDandN";
            this.textDandN.Size = new System.Drawing.Size(161, 22);
            this.textDandN.TabIndex = 28;
            // 
            // txtDayNight
            // 
            this.txtDayNight.AutoSize = true;
            this.txtDayNight.Location = new System.Drawing.Point(45, 228);
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(67, 16);
            this.txtDayNight.TabIndex = 30;
            this.txtDayNight.Text = "Gün Gece";
            // 
            // txtGuide
            // 
            this.txtGuide.AutoSize = true;
            this.txtGuide.Location = new System.Drawing.Point(60, 261);
            this.txtGuide.Name = "txtGuide";
            this.txtGuide.Size = new System.Drawing.Size(52, 16);
            this.txtGuide.TabIndex = 31;
            this.txtGuide.Text = "Rehber";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(126, 150);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(161, 22);
            this.nudCapacity.TabIndex = 32;
            // 
            // cbmGuide
            // 
            this.cbmGuide.FormattingEnabled = true;
            this.cbmGuide.Location = new System.Drawing.Point(126, 256);
            this.cbmGuide.Name = "cbmGuide";
            this.cbmGuide.Size = new System.Drawing.Size(161, 24);
            this.cbmGuide.TabIndex = 33;
            // 
            // FrmLocaiton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 592);
            this.Controls.Add(this.cbmGuide);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.txtGuide);
            this.Controls.Add(this.txtDayNight);
            this.Controls.Add(this.textDandN);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCtry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtLokasyonId);
            this.Name = "FrmLocaiton";
            this.Text = "FrmLocaiton";
            this.Load += new System.EventHandler(this.FrmLocaiton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCtry;
        private System.Windows.Forms.Label txtCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label txtCity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label txtLokasyonId;
        private System.Windows.Forms.Label txtCapacite;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.TextBox textDandN;
        private System.Windows.Forms.Label txtDayNight;
        private System.Windows.Forms.Label txtGuide;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.ComboBox cbmGuide;
    }
}