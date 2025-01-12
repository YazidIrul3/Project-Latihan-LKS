using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bungaHotel
{
    public partial class MainForm : Form
    {
        string idKaryawan;
        public MainForm(string idKaryawan)
        {
            InitializeComponent();
            this.idKaryawan = idKaryawan;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword(idKaryawan);
            form.ShowDialog();
       
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            MessageBox.Show("Telah berhasil logout");
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageRoomRepairmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomRepairment form = new ManageRoomRepairment(idKaryawan);
            form.ShowDialog();
        }

        private void manageHolidayPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageHolidayPrice form = new ManageHolidayPrice();
            form.ShowDialog();
        }

        private void bookingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingRoom form = new BookingRoom(idKaryawan);
            form.ShowDialog();
        }

        private void manageBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBooking form = new ManageBooking();
            form.ShowDialog();
        }

        private void inputPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPayment form = new InputPayment(idKaryawan);
            form.ShowDialog();
        }

        private void viewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPayment form = new ViewPayment();
            form.ShowDialog();
        }

        private void manageDailyPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee form = new ManageEmployee();
            form.ShowDialog();
        }

        private void manageGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageGuest form = new ManageGuest();
            form.ShowDialog();
        }

        private void manageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomForm form = new ManageRoomForm();
            form.ShowDialog();
        }

        private void manageRoomFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomFacility form = new ManageRoomFacility();
            form.ShowDialog();
        }

        private void transactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manageRoomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomType form = new ManageRoomType();
            form.ShowDialog();
        }

        private void roomAvailabilityReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
