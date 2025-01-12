namespace bungaHotel
{
    partial class BookingRoom
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
            this.guestID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkIN_date = new System.Windows.Forms.DateTimePicker();
            this.cbrtRoomType = new System.Windows.Forms.ComboBox();
            this.tIpeKamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bungaHotelDataSet1 = new bungaHotel.bungaHotelDataSet1();
            this.check = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kamarTableAdapter = new bungaHotel.bungaHotelDataSetTableAdapters.KamarTableAdapter();
            this.bungaHotelDataSet = new bungaHotel.bungaHotelDataSet();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.tIpeKamarTableAdapter = new bungaHotel.bungaHotelDataSet1TableAdapters.TIpeKamarTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.dtp_checkinHour = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.qty = new System.Windows.Forms.TextBox();
            this.longStay = new System.Windows.Forms.TextBox();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.cbrtAdditional = new System.Windows.Forms.ComboBox();
            this.cbrtGuestNama = new System.Windows.Forms.ComboBox();
            this.cbrtBookingType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbrtFloor = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_floor = new System.Windows.Forms.Label();
            this.repair = new System.Windows.Forms.Button();
            this.available = new System.Windows.Forms.Button();
            this.occopied = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.roomPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tafp = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.IDPerbaikanKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfasilitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTIpeKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIpeKamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guestID
            // 
            this.guestID.Location = new System.Drawing.Point(163, 69);
            this.guestID.Name = "guestID";
            this.guestID.Size = new System.Drawing.Size(225, 22);
            this.guestID.TabIndex = 103;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPerbaikanKamar,
            this.idfasilitas,
            this.IDTIpeKamar,
            this.total,
            this.totalitem,
            this.price,
            this.RepairedBy});
            this.dataGridView1.Location = new System.Drawing.Point(10, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 129);
            this.dataGridView1.TabIndex = 102;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // checkIN_date
            // 
            this.checkIN_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkIN_date.Location = new System.Drawing.Point(135, 75);
            this.checkIN_date.Name = "checkIN_date";
            this.checkIN_date.Size = new System.Drawing.Size(200, 22);
            this.checkIN_date.TabIndex = 80;
            this.checkIN_date.ValueChanged += new System.EventHandler(this.checkIN_date_ValueChanged);
            // 
            // cbrtRoomType
            // 
            this.cbrtRoomType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tIpeKamarBindingSource, "IDTipeKamar", true));
            this.cbrtRoomType.FormattingEnabled = true;
            this.cbrtRoomType.Location = new System.Drawing.Point(135, 24);
            this.cbrtRoomType.Name = "cbrtRoomType";
            this.cbrtRoomType.Size = new System.Drawing.Size(172, 24);
            this.cbrtRoomType.TabIndex = 79;
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
            // check
            // 
            this.check.Location = new System.Drawing.Point(335, 103);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 77;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Check In Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Room Type";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkIN_date);
            this.panel1.Controls.Add(this.cbrtRoomType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.check);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(29, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 149);
            this.panel1.TabIndex = 107;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 32);
            this.label2.TabIndex = 101;
            this.label2.Text = "Booking Room Form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(584, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 100;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(998, 59);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(10, 25);
            this.refresh.TabIndex = 105;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // tIpeKamarTableAdapter
            // 
            this.tIpeKamarTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.dtp_checkinHour);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.qty);
            this.panel2.Controls.Add(this.longStay);
            this.panel2.Controls.Add(this.roomNumber);
            this.panel2.Controls.Add(this.guestID);
            this.panel2.Controls.Add(this.cbrtAdditional);
            this.panel2.Controls.Add(this.cbrtGuestNama);
            this.panel2.Controls.Add(this.cbrtBookingType);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.add);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(29, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 466);
            this.panel2.TabIndex = 108;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(554, 107);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 16);
            this.linkLabel2.TabIndex = 104;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Refresh";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // dtp_checkinHour
            // 
            this.dtp_checkinHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_checkinHour.Location = new System.Drawing.Point(163, 182);
            this.dtp_checkinHour.Name = "dtp_checkinHour";
            this.dtp_checkinHour.Size = new System.Drawing.Size(200, 22);
            this.dtp_checkinHour.TabIndex = 80;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(396, 107);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 19);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add New Guest";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(163, 291);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(78, 22);
            this.qty.TabIndex = 103;
            this.qty.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // longStay
            // 
            this.longStay.Location = new System.Drawing.Point(163, 220);
            this.longStay.Name = "longStay";
            this.longStay.Size = new System.Drawing.Size(78, 22);
            this.longStay.TabIndex = 103;
            this.longStay.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // roomNumber
            // 
            this.roomNumber.Location = new System.Drawing.Point(163, 148);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(225, 22);
            this.roomNumber.TabIndex = 103;
            this.roomNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbrtAdditional
            // 
            this.cbrtAdditional.FormattingEnabled = true;
            this.cbrtAdditional.Location = new System.Drawing.Point(163, 250);
            this.cbrtAdditional.Name = "cbrtAdditional";
            this.cbrtAdditional.Size = new System.Drawing.Size(172, 24);
            this.cbrtAdditional.TabIndex = 79;
            // 
            // cbrtGuestNama
            // 
            this.cbrtGuestNama.FormattingEnabled = true;
            this.cbrtGuestNama.Location = new System.Drawing.Point(163, 107);
            this.cbrtGuestNama.Name = "cbrtGuestNama";
            this.cbrtGuestNama.Size = new System.Drawing.Size(172, 24);
            this.cbrtGuestNama.TabIndex = 79;
            this.cbrtGuestNama.SelectedIndexChanged += new System.EventHandler(this.cbrtGuestNama_SelectedIndexChanged);
            // 
            // cbrtBookingType
            // 
            this.cbrtBookingType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tIpeKamarBindingSource, "IDTipeKamar", true));
            this.cbrtBookingType.FormattingEnabled = true;
            this.cbrtBookingType.Location = new System.Drawing.Point(163, 32);
            this.cbrtBookingType.Name = "cbrtBookingType";
            this.cbrtBookingType.Size = new System.Drawing.Size(172, 24);
            this.cbrtBookingType.TabIndex = 79;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 64;
            this.label13.Text = "Qty";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 64;
            this.label12.Text = "Additional Facility";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "Long Stay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "Check-in-Date-Hour";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Room Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Guest Name - Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Guest ID";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(409, 284);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 77;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Booking Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Booking Type";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.cbrtFloor);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txt_floor);
            this.panel3.Controls.Add(this.repair);
            this.panel3.Controls.Add(this.available);
            this.panel3.Controls.Add(this.occopied);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(775, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 513);
            this.panel3.TabIndex = 108;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(129, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 248);
            this.flowLayoutPanel1.TabIndex = 110;
            // 
            // cbrtFloor
            // 
            this.cbrtFloor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tIpeKamarBindingSource, "IDTipeKamar", true));
            this.cbrtFloor.FormattingEnabled = true;
            this.cbrtFloor.Location = new System.Drawing.Point(139, 67);
            this.cbrtFloor.Name = "cbrtFloor";
            this.cbrtFloor.Size = new System.Drawing.Size(172, 24);
            this.cbrtFloor.TabIndex = 79;
            this.cbrtFloor.SelectedIndexChanged += new System.EventHandler(this.cbrtFloor_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(219, 437);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 64;
            this.label17.Text = "Occupied";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(219, 408);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 64;
            this.label16.Text = "Available";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(405, 408);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 16);
            this.label18.TabIndex = 64;
            this.label18.Text = "Repair";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 64;
            this.label14.Text = "Note";
            // 
            // txt_floor
            // 
            this.txt_floor.AutoSize = true;
            this.txt_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_floor.Location = new System.Drawing.Point(7, 75);
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(43, 16);
            this.txt_floor.TabIndex = 64;
            this.txt_floor.Text = "Floor";
            // 
            // repair
            // 
            this.repair.Location = new System.Drawing.Point(298, 401);
            this.repair.Name = "repair";
            this.repair.Size = new System.Drawing.Size(90, 27);
            this.repair.TabIndex = 77;
            this.repair.Text = "Repair";
            this.repair.UseVisualStyleBackColor = true;
            // 
            // available
            // 
            this.available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.available.Location = new System.Drawing.Point(81, 401);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(117, 23);
            this.available.TabIndex = 77;
            this.available.Text = "Available";
            this.available.UseVisualStyleBackColor = false;
            // 
            // occopied
            // 
            this.occopied.BackColor = System.Drawing.Color.Red;
            this.occopied.Location = new System.Drawing.Point(81, 437);
            this.occopied.Name = "occopied";
            this.occopied.Size = new System.Drawing.Size(117, 23);
            this.occopied.TabIndex = 77;
            this.occopied.Text = "Occupied";
            this.occopied.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 64;
            this.label15.Text = "Room Map";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(825, 616);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 64;
            this.label19.Text = "Room Price";
            // 
            // roomPrice
            // 
            this.roomPrice.Location = new System.Drawing.Point(1104, 616);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(174, 22);
            this.roomPrice.TabIndex = 103;
            this.roomPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1058, 616);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 16);
            this.label20.TabIndex = 64;
            this.label20.Text = "Rp.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1058, 644);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 16);
            this.label21.TabIndex = 64;
            this.label21.Text = "Rp.";
            // 
            // tafp
            // 
            this.tafp.Location = new System.Drawing.Point(1104, 644);
            this.tafp.Name = "tafp";
            this.tafp.Size = new System.Drawing.Size(174, 22);
            this.tafp.TabIndex = 103;
            this.tafp.Text = "0";
            this.tafp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1058, 672);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 16);
            this.label22.TabIndex = 64;
            this.label22.Text = "Rp.";
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(1104, 672);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(174, 22);
            this.tax.TabIndex = 103;
            this.tax.Text = "0";
            this.tax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1058, 700);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 16);
            this.label23.TabIndex = 64;
            this.label23.Text = "Rp.";
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(1104, 700);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(174, 22);
            this.totalPrice.TabIndex = 103;
            this.totalPrice.Text = "0";
            this.totalPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(825, 644);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(211, 16);
            this.label24.TabIndex = 64;
            this.label24.Text = "Total Additional Facility Price";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(825, 672);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 16);
            this.label25.TabIndex = 64;
            this.label25.Text = "Tax";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(825, 700);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 16);
            this.label26.TabIndex = 64;
            this.label26.Text = "Total Price";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(1203, 728);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 77;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // IDPerbaikanKamar
            // 
            this.IDPerbaikanKamar.HeaderText = "NO";
            this.IDPerbaikanKamar.MinimumWidth = 6;
            this.IDPerbaikanKamar.Name = "IDPerbaikanKamar";
            this.IDPerbaikanKamar.Width = 125;
            // 
            // idfasilitas
            // 
            this.idfasilitas.HeaderText = "IDAddFacility";
            this.idfasilitas.MinimumWidth = 6;
            this.idfasilitas.Name = "idfasilitas";
            this.idfasilitas.Width = 125;
            // 
            // IDTIpeKamar
            // 
            this.IDTIpeKamar.HeaderText = "Additiional Facility Name";
            this.IDTIpeKamar.MinimumWidth = 6;
            this.IDTIpeKamar.Name = "IDTIpeKamar";
            this.IDTIpeKamar.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total Price";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // totalitem
            // 
            this.totalitem.HeaderText = "Qty";
            this.totalitem.MinimumWidth = 6;
            this.totalitem.Name = "totalitem";
            this.totalitem.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // RepairedBy
            // 
            this.RepairedBy.HeaderText = "Delete";
            this.RepairedBy.MinimumWidth = 6;
            this.RepairedBy.Name = "RepairedBy";
            this.RepairedBy.Width = 125;
            // 
            // BookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 761);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.tafp);
            this.Controls.Add(this.roomPrice);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.panel2);
            this.Name = "BookingRoom";
            this.Text = "BookingRoom";
            this.Load += new System.EventHandler(this.BookingRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIpeKamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bungaHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox guestID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker checkIN_date;
        private System.Windows.Forms.ComboBox cbrtRoomType;
        private System.Windows.Forms.BindingSource tIpeKamarBindingSource;
        private bungaHotelDataSet1 bungaHotelDataSet1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private bungaHotelDataSetTableAdapters.KamarTableAdapter kamarTableAdapter;
        private bungaHotelDataSet bungaHotelDataSet;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refresh;
        private bungaHotelDataSet1TableAdapters.TIpeKamarTableAdapter tIpeKamarTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_checkinHour;
        private System.Windows.Forms.ComboBox cbrtBookingType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox longStay;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.ComboBox cbrtAdditional;
        private System.Windows.Forms.ComboBox cbrtGuestNama;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbrtFloor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txt_floor;
        private System.Windows.Forms.Button repair;
        private System.Windows.Forms.Button available;
        private System.Windows.Forms.Button occopied;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tafp;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPerbaikanKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfasilitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTIpeKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairedBy;
    }
}