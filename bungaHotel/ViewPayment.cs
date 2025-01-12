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
    public partial class ViewPayment : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        public ViewPayment()
        {
            InitializeComponent();
            dgv();
        }

        private void ViewPayment_Load(object sender, EventArgs e)
        {

        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();
            conn.select("select pm.IDPembayaran,pm.tglPembayaran,pm.IDPemesanan,peng.GuestName,kmr.NomorKamar,k.NamaKaryawan,pm.TotalPembayaran,p.Status from Pembayaran pm inner join Pemesanan p on pm.IDPemesanan=p.IDPemesanan inner join Karyawan k " +
                "on pm.IDkaryawan = k.IDKaryawan inner join Kamar kmr on p.IDKamar = kmr.IDKamar inner join Penghuni peng on p.IDPenghuni = peng.GuestID");
            conn.adp.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                string[] row = new string[]
                {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString(),
                    dr[7].ToString(),
                };

                dataGridView1.Rows.Add(row);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
            conn.select("select pm.IDPembayaran,pm.tglPembayaran,pm.IDPemesanan,peng.GuestName,kmr.NomorKamar,k.NamaKaryawan,pm.TotalPembayaran,p.Status from Pembayaran pm inner join Pemesanan p on pm.IDPemesanan=p.IDPemesanan inner join Karyawan k " +
                "on pm.IDkaryawan = k.IDKaryawan inner join Kamar kmr on p.IDKamar = kmr.IDKamar inner join Penghuni peng on p.IDPenghuni = peng.GuestID " +
                "where peng.GuestName like '%"+search.Text+ "%' or kmr.NomorKamar like '%"+search.Text+ "%' or k.NamaKaryawan like '%"+search.Text+"%'  ");
            conn.adp.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                string[] row = new string[]
                {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString(),
                    dr[7].ToString(),
                };

                dataGridView1.Rows.Add(row);
            }
        }
    }
}
