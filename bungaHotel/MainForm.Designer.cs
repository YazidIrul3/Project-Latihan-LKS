namespace bungaHotel
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomRepairmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDailyPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHolidayPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAvailabilityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.roomManagementToolStripMenuItem,
            this.priceManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingRoomToolStripMenuItem,
            this.manageBookingToolStripMenuItem,
            this.inputPaymentToolStripMenuItem,
            this.viewPaymentToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // bookingRoomToolStripMenuItem
            // 
            this.bookingRoomToolStripMenuItem.Name = "bookingRoomToolStripMenuItem";
            this.bookingRoomToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.bookingRoomToolStripMenuItem.Text = "Booking Room";
            this.bookingRoomToolStripMenuItem.Click += new System.EventHandler(this.bookingRoomToolStripMenuItem_Click);
            // 
            // manageBookingToolStripMenuItem
            // 
            this.manageBookingToolStripMenuItem.Name = "manageBookingToolStripMenuItem";
            this.manageBookingToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.manageBookingToolStripMenuItem.Text = "Manage Booking";
            this.manageBookingToolStripMenuItem.Click += new System.EventHandler(this.manageBookingToolStripMenuItem_Click);
            // 
            // inputPaymentToolStripMenuItem
            // 
            this.inputPaymentToolStripMenuItem.Name = "inputPaymentToolStripMenuItem";
            this.inputPaymentToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.inputPaymentToolStripMenuItem.Text = "Input Payment";
            this.inputPaymentToolStripMenuItem.Click += new System.EventHandler(this.inputPaymentToolStripMenuItem_Click);
            // 
            // viewPaymentToolStripMenuItem
            // 
            this.viewPaymentToolStripMenuItem.Name = "viewPaymentToolStripMenuItem";
            this.viewPaymentToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.viewPaymentToolStripMenuItem.Text = "View Payment";
            this.viewPaymentToolStripMenuItem.Click += new System.EventHandler(this.viewPaymentToolStripMenuItem_Click);
            // 
            // roomManagementToolStripMenuItem
            // 
            this.roomManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRoomTypeToolStripMenuItem,
            this.manageRoomToolStripMenuItem,
            this.manageRoomFacilityToolStripMenuItem,
            this.manageRoomRepairmentToolStripMenuItem});
            this.roomManagementToolStripMenuItem.Name = "roomManagementToolStripMenuItem";
            this.roomManagementToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.roomManagementToolStripMenuItem.Text = "Room Management";
            // 
            // manageRoomTypeToolStripMenuItem
            // 
            this.manageRoomTypeToolStripMenuItem.Name = "manageRoomTypeToolStripMenuItem";
            this.manageRoomTypeToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.manageRoomTypeToolStripMenuItem.Text = "Manage Room Type";
            this.manageRoomTypeToolStripMenuItem.Click += new System.EventHandler(this.manageRoomTypeToolStripMenuItem_Click);
            // 
            // manageRoomToolStripMenuItem
            // 
            this.manageRoomToolStripMenuItem.Name = "manageRoomToolStripMenuItem";
            this.manageRoomToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.manageRoomToolStripMenuItem.Text = "Manage Room";
            this.manageRoomToolStripMenuItem.Click += new System.EventHandler(this.manageRoomToolStripMenuItem_Click);
            // 
            // manageRoomFacilityToolStripMenuItem
            // 
            this.manageRoomFacilityToolStripMenuItem.Name = "manageRoomFacilityToolStripMenuItem";
            this.manageRoomFacilityToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.manageRoomFacilityToolStripMenuItem.Text = "Manage Room Facility";
            this.manageRoomFacilityToolStripMenuItem.Click += new System.EventHandler(this.manageRoomFacilityToolStripMenuItem_Click);
            // 
            // manageRoomRepairmentToolStripMenuItem
            // 
            this.manageRoomRepairmentToolStripMenuItem.Name = "manageRoomRepairmentToolStripMenuItem";
            this.manageRoomRepairmentToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.manageRoomRepairmentToolStripMenuItem.Text = "Manage Room Repairment";
            this.manageRoomRepairmentToolStripMenuItem.Click += new System.EventHandler(this.manageRoomRepairmentToolStripMenuItem_Click);
            // 
            // priceManagementToolStripMenuItem
            // 
            this.priceManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDailyPriceToolStripMenuItem,
            this.manageHolidayPriceToolStripMenuItem});
            this.priceManagementToolStripMenuItem.Name = "priceManagementToolStripMenuItem";
            this.priceManagementToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.priceManagementToolStripMenuItem.Text = "Price Management";
            // 
            // manageDailyPriceToolStripMenuItem
            // 
            this.manageDailyPriceToolStripMenuItem.Name = "manageDailyPriceToolStripMenuItem";
            this.manageDailyPriceToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.manageDailyPriceToolStripMenuItem.Text = "Manage Daily Price";
            this.manageDailyPriceToolStripMenuItem.Click += new System.EventHandler(this.manageDailyPriceToolStripMenuItem_Click);
            // 
            // manageHolidayPriceToolStripMenuItem
            // 
            this.manageHolidayPriceToolStripMenuItem.Name = "manageHolidayPriceToolStripMenuItem";
            this.manageHolidayPriceToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.manageHolidayPriceToolStripMenuItem.Text = "Manage Holiday Price";
            this.manageHolidayPriceToolStripMenuItem.Click += new System.EventHandler(this.manageHolidayPriceToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.manageGuestToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // manageGuestToolStripMenuItem
            // 
            this.manageGuestToolStripMenuItem.Name = "manageGuestToolStripMenuItem";
            this.manageGuestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageGuestToolStripMenuItem.Text = "Manage Guest";
            this.manageGuestToolStripMenuItem.Click += new System.EventHandler(this.manageGuestToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionReportToolStripMenuItem,
            this.roomAvailabilityReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // transactionReportToolStripMenuItem
            // 
            this.transactionReportToolStripMenuItem.Name = "transactionReportToolStripMenuItem";
            this.transactionReportToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.transactionReportToolStripMenuItem.Text = "Transaction Report";
            this.transactionReportToolStripMenuItem.Click += new System.EventHandler(this.transactionReportToolStripMenuItem_Click);
            // 
            // roomAvailabilityReportToolStripMenuItem
            // 
            this.roomAvailabilityReportToolStripMenuItem.Name = "roomAvailabilityReportToolStripMenuItem";
            this.roomAvailabilityReportToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.roomAvailabilityReportToolStripMenuItem.Text = "Room Availability Report";
            this.roomAvailabilityReportToolStripMenuItem.Click += new System.EventHandler(this.roomAvailabilityReportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 632);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomRepairmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDailyPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHolidayPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomAvailabilityReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPaymentToolStripMenuItem;
    }
}