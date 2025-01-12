namespace bungaHotel
{
    partial class ViewPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bungaHotelDataSet1 = new bungaHotel.bungaHotelDataSet1();
            this.tIpeKamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamarTableAdapter = new bungaHotel.bungaHotelDataSetTableAdapters.KamarTableAdapter();
            this.bungaHotelDataSet = new bungaHotel.bungaHotelDataSet();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.search = new System.Windows.Forms.TextBox();
            this.tIpeKamarTableAdapter = new bungaHotel.bungaHotelDataSet1TableAdapters.TIpeKamarTableAdapter();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIpeKamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 32);
            this.label2.TabIndex = 98;
            this.label2.Text = "View Payment Form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(599, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 97;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(479, 102);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 101;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.IDKamar,
            this.Column1,
            this.rooNo,
            this.BeginDate,
            this.roomType,
            this.floor,
            this.EndDate});
            this.dataGridView1.Location = new System.Drawing.Point(29, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 286);
            this.dataGridView1.TabIndex = 99;
            // 
            // bungaHotelDataSet1
            // 
            this.bungaHotelDataSet1.DataSetName = "bungaHotelDataSet1";
            this.bungaHotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIpeKamarBindingSource
            // 
            this.tIpeKamarBindingSource.DataMember = "TIpeKamar";
            this.tIpeKamarBindingSource.DataSource = this.bungaHotelDataSet1;
            // 
            // kamarTableAdapter
            // 
            this.kamarTableAdapter.ClearBeforeFill = true;
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
            // search
            // 
            this.search.Location = new System.Drawing.Point(120, 102);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(353, 22);
            this.search.TabIndex = 100;
            // 
            // tIpeKamarTableAdapter
            // 
            this.tIpeKamarTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentID
            // 
            this.PaymentID.HeaderText = "Payment ID";
            this.PaymentID.MinimumWidth = 6;
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Width = 125;
            // 
            // IDKamar
            // 
            this.IDKamar.HeaderText = "Payment Date";
            this.IDKamar.MinimumWidth = 6;
            this.IDKamar.Name = "IDKamar";
            this.IDKamar.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BookingID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // rooNo
            // 
            this.rooNo.HeaderText = "Guest Name";
            this.rooNo.MinimumWidth = 6;
            this.rooNo.Name = "rooNo";
            this.rooNo.Width = 125;
            // 
            // BeginDate
            // 
            this.BeginDate.HeaderText = "Room No";
            this.BeginDate.MinimumWidth = 6;
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Width = 125;
            // 
            // roomType
            // 
            this.roomType.HeaderText = "Employee Name";
            this.roomType.MinimumWidth = 6;
            this.roomType.Name = "roomType";
            this.roomType.Width = 125;
            // 
            // floor
            // 
            this.floor.HeaderText = "Payment";
            this.floor.MinimumWidth = 6;
            this.floor.Name = "floor";
            this.floor.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Status";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 125;
            // 
            // ViewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Name = "ViewPayment";
            this.Text = "ViewPayment";
            this.Load += new System.EventHandler(this.ViewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIpeKamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bungaHotelDataSet1 bungaHotelDataSet1;
        private System.Windows.Forms.BindingSource tIpeKamarBindingSource;
        private bungaHotelDataSetTableAdapters.KamarTableAdapter kamarTableAdapter;
        private bungaHotelDataSet bungaHotelDataSet;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private System.Windows.Forms.TextBox search;
        private bungaHotelDataSet1TableAdapters.TIpeKamarTableAdapter tIpeKamarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}