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
    public partial class InputPayment : Form
    {

        Koneksi conn = new Koneksi();
        string idKaryawan;
        public InputPayment(string idKaryawan)
        {
            InitializeComponent();
            cb();

            this.idKaryawan = idKaryawan.ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(comboBox1.Text) || "".Equals(payment.Text) || "".Equals(remainingPayment.Text) || "".Equals(balance.Text))
                {
                    MessageBox.Show("harus isi semua");
                } else if (Convert.ToInt32( balance.Text) != 0 ) {
                    MessageBox.Show("balance harus 0");
                }
                else
                {
                    conn.cud("update Pemesanan set Status = 'I' where IDPemesanan='" + ((comboItem)comboBox1.SelectedItem).text + "'");
                    conn.cud("insert into Pembayaran (tglPembayaran,IDPemesanan,IDKaryawan,TotalPembayaran) values ('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + ((comboItem)comboBox1.SelectedItem).text + "', " +
                        "'" + idKaryawan + "', '" + payment.Text + "')");

                    MessageBox.Show("payment success");
                }
            } catch (Exception ex) { 
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                InputPayment form = new InputPayment(idKaryawan);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void cb()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            comboBox1.Items.Clear();
            conn.select("select IDPemesanan, TotalBayar from Pemesanan where Status != 'I' and Status != 'C'");
            conn.adp.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                comboBox1.DisplayMember = "price";
                comboBox1.DisplayMember = "text";
                comboBox1.Items.Add(new comboItem() { text= dr[0].ToString(), price = dr[1].ToString() });
            }
        }

        private void InputPayment_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            remainingPayment.Text = ((comboItem)comboBox1.SelectedItem).price;
        }

        private void payment_TextChanged(object sender, EventArgs e)
        {
            if("" !=payment.Text)
            {
                    int rp = Int32.Parse(remainingPayment.Text);
                    int p = Int32.Parse(payment.Text);

                    balance.Text= (p - rp).ToString();
            }
        }
    }
}
