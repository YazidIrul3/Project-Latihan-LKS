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
    public partial class ManageBooking : Form
    {

        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        public ManageBooking()
        {
            InitializeComponent();

            dgv();
        }

        private void ManageBooking_Load(object sender, EventArgs e)
        {

        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();
            conn.select("select p.IDPemesanan,p.tglPemesanan,p.waktuMasukHotel,g.GuestName,g.PhoneNumber, k.NomorKamar,p.Status from Pemesanan p inner join Penghuni g on p.IDPenghuni = g.GuestID " +
                "inner join Kamar k on p.IDKamar = k.IDKamar");

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
                };

                dataGridView1.Rows.Add(row);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            if(e.ColumnIndex == 6)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if(row.Cells[0].Value.ToString() != "" || row.Cells[0].Value.ToString() != null)
                {

                    string id = row.Cells[0].Value.ToString();
                string status = "C";

                DialogResult result = MessageBox.Show("yakin cancel pesanan", "warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                    {
                        conn.cud("update Pemesanan set Status = '"+status+"' where IDPemesanan = '"+id+"'");
                        MessageBox.Show("berhasil cancel booking ngan");
                    }
                }
            }
            } catch (Exception ex) {
                //MessageBox.Show(ex.Message.ToString());
            } finally
            {
                ManageBooking manageBooking = new ManageBooking();
                this.Hide();
                manageBooking.ShowDialog();
                this.Close();
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
            conn.select("select p.IDPemesanan,p.tglPemesanan,g.GuestName,g.PhoneNumber, k.NomorKamar,p.Status from Pemesanan p inner join Penghuni g on p.IDPenghuni = g.GuestID " +
                "inner join Kamar k on p.IDKamar = k.IDKamar where k.NomorKamar like '%" + search.Text+ "%' or g.GuestName like '%" + search.Text+"%' ");

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
                };

                dataGridView1.Rows.Add(row);

            }
        }
    }
}
