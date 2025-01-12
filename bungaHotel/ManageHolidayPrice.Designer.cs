namespace bungaHotel
{
    partial class ManageHolidayPrice
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
            this.tIpeKamarTableAdapter = new bungaHotel.bungaHotelDataSet1TableAdapters.TIpeKamarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bungaHotelDataSet = new bungaHotel.bungaHotelDataSet();
            this.kamarTableAdapter = new bungaHotel.bungaHotelDataSetTableAdapters.KamarTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_persen = new System.Windows.Forms.TextBox();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.begin_date = new System.Windows.Forms.DateTimePicker();
            this.cbrt1 = new System.Windows.Forms.ComboBox();
            this.tIpeKamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bungaHotelDataSet1 = new bungaHotel.bungaHotelDataSet1();
            this.add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDPerbaikanKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTIpeKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIpeKamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tIpeKamarTableAdapter
            // 
            this.tIpeKamarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 32);
            this.label2.TabIndex = 92;
            this.label2.Text = "Manage Room Repairment Form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(567, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 91;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(981, 55);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 96;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // kamarBindingSource
            // 
            this.kamarBindingSource.DataMember = "Kamar";
            this.kamarBindingSource.DataSource = this.bungaHotelDataSet;
            // 
            // bungaHotelDataSet
            // 
            this.bungaHotelDataSet.DataSetName = "bungaHotelDataSet";
            this.bungaHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamarTableAdapter
            // 
            this.kamarTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_persen);
            this.panel1.Controls.Add(this.end_date);
            this.panel1.Controls.Add(this.begin_date);
            this.panel1.Controls.Add(this.cbrt1);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 211);
            this.panel1.TabIndex = 98;
            // 
            // txt_persen
            // 
            this.txt_persen.Location = new System.Drawing.Point(135, 152);
            this.txt_persen.Name = "txt_persen";
            this.txt_persen.Size = new System.Drawing.Size(149, 22);
            this.txt_persen.TabIndex = 81;
            // 
            // end_date
            // 
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.Location = new System.Drawing.Point(135, 111);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 22);
            this.end_date.TabIndex = 80;
            // 
            // begin_date
            // 
            this.begin_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.begin_date.Location = new System.Drawing.Point(135, 75);
            this.begin_date.Name = "begin_date";
            this.begin_date.Size = new System.Drawing.Size(200, 22);
            this.begin_date.TabIndex = 80;
            // 
            // cbrt1
            // 
            this.cbrt1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tIpeKamarBindingSource, "IDTipeKamar", true));
            this.cbrt1.FormattingEnabled = true;
            this.cbrt1.Location = new System.Drawing.Point(135, 24);
            this.cbrt1.Name = "cbrt1";
            this.cbrt1.Size = new System.Drawing.Size(172, 24);
            this.cbrt1.TabIndex = 79;
            // 
            // tIpeKamarBindingSource
            // 
            this.tIpeKamarBindingSource.DataMember = "TIpeKamar";
            this.tIpeKamarBindingSource.DataSource = this.bungaHotelDataSet1;
            // 
            // bungaHotelDataSet1
            // 
            this.bungaHotelDataSet1.DataSetName = "bungaHotelDataSet1";
            this.bungaHotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(458, 158);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 77;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Persentase";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "End Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Begin Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Room Number";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(447, 292);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 95;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(88, 298);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(353, 22);
            this.search.TabIndex = 94;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPerbaikanKamar,
            this.IDTIpeKamar,
            this.roomType,
            this.rooNo,
            this.IDKamar,
            this.floor,
            this.BeginDate,
            this.EndDate,
            this.RepairedBy});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 245);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDPerbaikanKamar
            // 
            this.IDPerbaikanKamar.HeaderText = "ID Harga Fluktuatif";
            this.IDPerbaikanKamar.MinimumWidth = 6;
            this.IDPerbaikanKamar.Name = "IDPerbaikanKamar";
            this.IDPerbaikanKamar.Width = 125;
            // 
            // IDTIpeKamar
            // 
            this.IDTIpeKamar.HeaderText = "ID TIpe Kamar";
            this.IDTIpeKamar.MinimumWidth = 6;
            this.IDTIpeKamar.Name = "IDTIpeKamar";
            this.IDTIpeKamar.Width = 125;
            // 
            // roomType
            // 
            this.roomType.HeaderText = "Room Type Name";
            this.roomType.MinimumWidth = 6;
            this.roomType.Name = "roomType";
            this.roomType.Width = 125;
            // 
            // rooNo
            // 
            this.rooNo.HeaderText = "Room Price";
            this.rooNo.MinimumWidth = 6;
            this.rooNo.Name = "rooNo";
            this.rooNo.Width = 125;
            // 
            // IDKamar
            // 
            this.IDKamar.HeaderText = "Persentase";
            this.IDKamar.MinimumWidth = 6;
            this.IDKamar.Name = "IDKamar";
            this.IDKamar.Width = 125;
            // 
            // floor
            // 
            this.floor.HeaderText = "Final Price";
            this.floor.MinimumWidth = 6;
            this.floor.Name = "floor";
            this.floor.Width = 125;
            // 
            // BeginDate
            // 
            this.BeginDate.HeaderText = "Begin Date";
            this.BeginDate.MinimumWidth = 6;
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 125;
            // 
            // RepairedBy
            // 
            this.RepairedBy.HeaderText = "Delete";
            this.RepairedBy.MinimumWidth = 6;
            this.RepairedBy.Name = "RepairedBy";
            this.RepairedBy.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 97;
            // 
            // ManageHolidayPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "ManageHolidayPrice";
            this.Text = "ManageHolidayPrice";
            this.Load += new System.EventHandler(this.ManageHolidayPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIpeKamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bungaHotelDataSet1TableAdapters.TIpeKamarTableAdapter tIpeKamarTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private bungaHotelDataSet bungaHotelDataSet;
        private bungaHotelDataSetTableAdapters.KamarTableAdapter kamarTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_persen;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker begin_date;
        private System.Windows.Forms.ComboBox cbrt1;
        private System.Windows.Forms.BindingSource tIpeKamarBindingSource;
        private bungaHotelDataSet1 bungaHotelDataSet1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPerbaikanKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTIpeKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairedBy;
    }
}