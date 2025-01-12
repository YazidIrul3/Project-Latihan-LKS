namespace bungaHotel
{
    partial class ManageRoomRepairment
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_note = new System.Windows.Forms.RichTextBox();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.begin_date = new System.Windows.Forms.DateTimePicker();
            this.cbrt1 = new System.Windows.Forms.ComboBox();
            this.tIpeKamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bungaHotelDataSet1 = new bungaHotel.bungaHotelDataSet1();
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tIpeKamarTableAdapter = new bungaHotel.bungaHotelDataSet1TableAdapters.TIpeKamarTableAdapter();
            this.bungaHotelDataSet = new bungaHotel.bungaHotelDataSet();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamarTableAdapter = new bungaHotel.bungaHotelDataSetTableAdapters.KamarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDPerbaikanKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIpeKamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_note);
            this.panel1.Controls.Add(this.end_date);
            this.panel1.Controls.Add(this.begin_date);
            this.panel1.Controls.Add(this.cbrt1);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(37, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 211);
            this.panel1.TabIndex = 89;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(461, 44);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(303, 89);
            this.txt_note.TabIndex = 81;
            this.txt_note.Text = "";
            // 
            // end_date
            // 
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.Location = new System.Drawing.Point(135, 111);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 22);
            this.end_date.TabIndex = 80;
            this.end_date.ValueChanged += new System.EventHandler(this.begin_date_ValueChanged);
            // 
            // begin_date
            // 
            this.begin_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.begin_date.Location = new System.Drawing.Point(135, 75);
            this.begin_date.Name = "begin_date";
            this.begin_date.Size = new System.Drawing.Size(200, 22);
            this.begin_date.TabIndex = 80;
            this.begin_date.ValueChanged += new System.EventHandler(this.begin_date_ValueChanged);
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
            this.add.Location = new System.Drawing.Point(689, 156);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 77;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Note";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 32);
            this.label2.TabIndex = 83;
            this.label2.Text = "Manage Room Repairment Form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(592, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 82;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(1006, 70);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 87;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(472, 307);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 86;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(113, 307);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(353, 22);
            this.search.TabIndex = 85;
            this.search.TextChanged += new System.EventHandler(this.roomID_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 88;
            // 
            // tIpeKamarTableAdapter
            // 
            this.tIpeKamarTableAdapter.ClearBeforeFill = true;
            // 
            // bungaHotelDataSet
            // 
            this.bungaHotelDataSet.DataSetName = "bungaHotelDataSet";
            this.bungaHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamarBindingSource
            // 
            this.kamarBindingSource.DataMember = "Kamar";
            this.kamarBindingSource.DataSource = this.bungaHotelDataSet;
            // 
            // kamarTableAdapter
            // 
            this.kamarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPerbaikanKamar,
            this.IDKamar,
            this.roomType,
            this.rooNo,
            this.floor,
            this.BeginDate,
            this.EndDate,
            this.RepairedBy,
            this.Note,
            this.finish});
            this.dataGridView1.Location = new System.Drawing.Point(22, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 289);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDPerbaikanKamar
            // 
            this.IDPerbaikanKamar.HeaderText = "ID Perbaikan Kamar";
            this.IDPerbaikanKamar.MinimumWidth = 6;
            this.IDPerbaikanKamar.Name = "IDPerbaikanKamar";
            this.IDPerbaikanKamar.Width = 125;
            // 
            // IDKamar
            // 
            this.IDKamar.HeaderText = "ID Kamar";
            this.IDKamar.MinimumWidth = 6;
            this.IDKamar.Name = "IDKamar";
            this.IDKamar.Width = 125;
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
            this.rooNo.HeaderText = "Room No";
            this.rooNo.MinimumWidth = 6;
            this.rooNo.Name = "rooNo";
            this.rooNo.Width = 125;
            // 
            // floor
            // 
            this.floor.HeaderText = "Floor";
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
            this.RepairedBy.HeaderText = "Repaired By";
            this.RepairedBy.MinimumWidth = 6;
            this.RepairedBy.Name = "RepairedBy";
            this.RepairedBy.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // finish
            // 
            this.finish.HeaderText = "Finish";
            this.finish.MinimumWidth = 6;
            this.finish.Name = "finish";
            this.finish.Width = 125;
            // 
            // ManageRoomRepairment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.load);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageRoomRepairment";
            this.Text = "ManageRoomRepairment";
            this.Load += new System.EventHandler(this.ManageRoomRepairment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIpeKamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbrt1;
        private System.Windows.Forms.BindingSource tIpeKamarBindingSource;
        private bungaHotelDataSet1 bungaHotelDataSet1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox textBox1;
        private bungaHotelDataSet1TableAdapters.TIpeKamarTableAdapter tIpeKamarTableAdapter;
        private bungaHotelDataSet bungaHotelDataSet;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private bungaHotelDataSetTableAdapters.KamarTableAdapter kamarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker begin_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_note;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPerbaikanKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn finish;
    }
}