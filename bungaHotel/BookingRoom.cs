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
    public partial class BookingRoom : Form
    {

        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        string idKaryawan,idrt,hargakamar,hargainsert,ihf,idroompesan,idpem;
        int i;
        public BookingRoom(string idKaryawan)
        {
            InitializeComponent();
            roomPrice.Text = "o";

            cb();
            flowLayoutPanel1.Controls.Clear();
            txt_floor.Enabled = false;
            this.idKaryawan = idKaryawan;
            i = 1;

        }

        private void add_Click(object sender, EventArgs e)
        {
            if("".Equals(cbrtRoomType.Text))
            {
                MessageBox.Show("harus isi combo box");
            } else
            {

            idrt = ((comboItem)cbrtRoomType.SelectedItem).value;
            viewFloor();
            txt_floor.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            cbrtRoomType.Items.Clear();
            conn.select("select * from TipeKamar");
            conn.adp.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                cbrtRoomType.DisplayMember = "value";
                cbrtRoomType.DisplayMember = "text";
                cbrtRoomType.Items.Add(new comboItem() { text = dr[1].ToString(), value= dr[0].ToString() });
            }

            DataTable dt2 = new DataTable();
            dt2.Clear();
            cbrtBookingType.Items.Clear();
            conn.select("select * from JenisPemesanan");
            conn.adp.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                cbrtBookingType.DisplayMember = "value";
                cbrtBookingType.DisplayMember = "text";
                cbrtBookingType.Items.Add(new comboItem() { text = dr[1].ToString(), value = dr[0].ToString() });
            }

            DataTable dt3 = new DataTable();
            dt3.Clear();
            cbrtGuestNama.Items.Clear();
            conn.select("select * from Penghuni");
            conn.adp.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                cbrtGuestNama.DisplayMember = "value";
                cbrtGuestNama.DisplayMember = "text";
                cbrtGuestNama.Items.Add(new comboItem() { text = dr[1].ToString(), value = dr[0].ToString() });
            }


            DataTable dt4 = new DataTable();
            dt4.Clear();
            cbrtAdditional.Items.Clear();
            conn.select("select * from FasilitasTambahan");
            conn.adp.Fill(dt4);

            foreach (DataRow dr in dt4.Rows)
            {
                cbrtAdditional.DisplayMember = "value";
                cbrtAdditional.DisplayMember = "text";
                cbrtAdditional.Items.Add(new comboItem() { text = dr[1].ToString(), value = dr[0].ToString(), price = dr[2].ToString() });
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void viewFloor()
        {
            DataTable vf = new DataTable();
            vf.Clear();
            cbrtFloor.Items.Clear();
            conn.select("select distinct Lantai from Kamar where IDTipeKamar like '" + idrt + "'");
            conn.adp.Fill(vf);

            foreach(DataRow dataRow in vf.Rows)
            {
                cbrtFloor.Items.Add(dataRow[0].ToString());
            }
        }
        private void segar()
        {
            BookingRoom form = new BookingRoom(idKaryawan);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
             
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookingRoom_Load(object sender, EventArgs e)
        {

        }

        private void add_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((comboItem)cbrtAdditional.SelectedItem).price);
            int b = Convert.ToInt32(qty.Text);
            int c = a *  b;

            string[] data = new string[] { 
                i.ToString(),
                ((comboItem)cbrtAdditional.SelectedItem).value.ToString(),
                ((comboItem)cbrtAdditional.SelectedItem).text.ToString(),
                c.ToString(),
                qty.Text.ToString(),
                a.ToString(),
            };

            dataGridView1.Rows.Add(data);
            i++;

            int ts = Int32.Parse(tafp.Text);
            int total = ts + c;
            tafp.Text = total.ToString();

            int ts1 = Int32.Parse(tafp.Text);
            int ttlpc = Int32.Parse(totalPrice.Text);
            int total2 = ts1 + ttlpc;
            totalPrice.Text = total2.ToString();
        }

        private void checkIN_date_ValueChanged(object sender, EventArgs e)
        {
            DataTable cek = new DataTable();
            conn.select("select hf.IDHargaFluktuatif,hk.HargaKamar + (hf.Persentasi * hk.HargaKamar/100) as 'final price' from HargaFLuktuatif hf " +
                "inner join TipeKamar tk on hf.IDTipeKamar = tk.IDTipeKamar inner join HargaKamar hk on tk.IDTipeKamar = hk.IDTipeKamar " +
                "where hf.tglMulai <= '"+checkIN_date.Value.ToString("yyyy-MM-dd") + "' and hf.tglSelesai >= '"+checkIN_date.Value.ToString("yyyy-MM-dd") + "' " +
                "and hf.IDTipeKamar='" + idrt+"'");
            conn.adp.Fill(cek);

            if(cek.Rows.Count != 0)
            {
                string aa = "0";
                foreach(DataRow dtr in cek.Rows)
                {
                    aa = dtr[1].ToString();
                    ihf = dtr[0].ToString();
                }

                roomPrice.Text = aa;
                hargainsert = aa;

                int a = Int32.Parse(roomPrice.Text);
                int b = Int32.Parse(tafp.Text);
                int c = a + b;

                int ttlpricetax = c / 10;
                tax.Text = ttlpricetax.ToString();

                int d =Int32.Parse(tax.Text);
                int total = c + d;
                totalPrice.Text = total.ToString();
;            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageGuest f = new ManageGuest();
            f.ShowDialog();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(cbrtBookingType.Text) || "".Equals(guestID.Text) || "".Equals(cbrtGuestNama.Text) || "".Equals(roomNumber.Text))
                {
                    MessageBox.Show("fill all textbox");
                } else
                {
                    string dtime = DateTime.Now.ToString("yyyy-MM-dd");
                    string sts = "b";
                    conn.cud("insert into Pemesanan (IDJenisPemesanan,tglPemesanan,waktuMasukHotel,IDPenghuni,IDKamar,HargaPerMalam,IDHargaFluktuatif," +
                        "LamaTinggal,Status,IDKaryawan,TotalBayar) values  ('"+((comboItem)cbrtBookingType.SelectedItem).value+"', " +
                        "'"+dtp_checkinHour.Value.ToString("yyyy-MM-dd") +"', '"+guestID.Text+"', '"+idroompesan+"', '"+hargainsert+"', " +
                        "'"+ihf+"','"+longStay.Text+"','"+sts+"','"+idKaryawan+"','"+totalPrice.Text+"')");
                   
                    DataTable cekidp = new DataTable();
                    conn.select("select top 1 * from Pemesanan order by IDPemesanan");
                    conn.adp.Fill(cekidp);

                    foreach(DataRow dr in cekidp.Rows)
                    {
                        idpem = dr[0].ToString();
                    }

                    int dgr = dataGridView1.Rows.Count;

                    if(dgr > 0)
                    {
                        for(int i = 0; i < dgr; i++)
                        {
                            conn.cud("insert into PemesananDetail (IDPemesanan,IDFasilitasTambahan,JumlahFasilitasTambahan,HargaSatuan) values ('"+ 
                                idpem+"', '"+Convert.ToInt32( dataGridView1.Rows[i].Cells["idfasilitas"].Value)+"' , '"+Convert.ToInt32( dataGridView1.Rows[i].Cells["totalitem"].Value)+"'," +
                                "'"+Convert.ToInt32( dataGridView1.Rows[i].Cells["price"].Value)+"')");
                        }
                    }
                }  

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                MessageBox.Show("booking success");
                segar();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt3 = new DataTable();
            dt3.Clear();
            cbrtGuestNama.Items.Clear();
            conn.select("select * from Penghuni");
            conn.adp.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                cbrtGuestNama.DisplayMember = "value";
                cbrtGuestNama.DisplayMember = "text";
                cbrtGuestNama.Items.Add(new comboItem() { text = dr[1].ToString(), value = dr[0].ToString() });
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int a = Convert.ToInt32(row.Cells[3].Value);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                dataGridView1.Refresh();

                i = 1;

                int ts = Int32.Parse(tafp.Text);
                int total = ts - a;
                tafp.Text = total.ToString();

                int allttlp = Int32.Parse(totalPrice.Text.ToString());
                totalPrice.Text = (allttlp - a).ToString(); 
            }
        }

        private void cbrtGuestNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            guestID.Text = ((comboItem)cbrtGuestNama.SelectedItem).value.ToString();
        }

        private void cbrtFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            conn.select("select max(kmr.IDKamar) as idKamar,max(pk.IDPerbaikanKamar) as idPerbaikan," +
                "max(kmr.NomorKamar) as noKamar, max(pm.Status) as status,max(hk.HargaKamar) as hargaKamar from Kamar kmr " +
                "inner join PerbaikanKamar pk on (kmr.IDKamar=pk.IDPerbaikanKamar and ('" + checkIN_date.Value.ToString("yyyy-MM-dd") + "' between pk.TgMulai and pk.TgSelesai)) " +
                "inner join Pemesanan pm on (kmr.IDKamar=pm.IDKamar and ('"+checkIN_date.Value.ToString("yyyy-MM-dd") +"'"  +
                "between pm.waktuMasukHotel and DATEADD(day,1,waktuMasukHotel))) inner join HargaKamar hk " +
                " on kmr.IDTipeKamar = hk.IDTipeKamar where Lantai = '" + idrt+"' and " +
                "kmr.IDTipeKamar='"+((comboItem) cbrtRoomType.SelectedItem).value+"' group by kmr.IDKamar");

            if(conn.dt.Rows.Count != 0)
            {
                for (int i = 0; i < conn.dt.Rows.Count; i++)
                {
                    string noKamar = conn.dt.Rows[i]["noKamar"].ToString();
                    string idKamar = conn.dt.Rows[i]["idKamar"].ToString();
                    string status = conn.dt.Rows[i]["status"].ToString();
                    string idPerbaikan = conn.dt.Rows[i]["idPerbaikan"].ToString();
                    string harga = conn.dt.Rows[i]["hargaKamar"].ToString();

                    Button b = new Button();
                    b.Name = "ID" + idKamar;
                    b.Text = noKamar;
                    b.Tag = harga;

                    if(idPerbaikan != "")
                    {
                        b.ForeColor = Color.Maroon;
                        b.BackColor = Color.White;
                    } else if(status.Equals("B") || status.Equals("I") ){ 
                        b.ForeColor = Color.Red;
                        b.BackColor = Color.White;
                    } else if (status.Equals("C") || status.Equals(""))
                    {
                        b.ForeColor = Color.Blue;
                        b.BackColor = Color.White;
                    }

                    b.Click += new System.EventHandler(roomClick);
                    flowLayoutPanel1.Controls.Add(b);
                }
            }
        }

        void roomClick(object s,EventArgs e)
        {
            Button thisbtn = (Button)s;
            if(thisbtn.BackColor == Color.White)
            {
                MessageBox.Show("kamar" + thisbtn.Text + "sedang DiPerbaiki");
            } else if (thisbtn.BackColor == Color.Blue)
            {
                hargakamar = thisbtn.Tag.ToString();
                hargainsert = hargakamar;
                roomPrice.Text = thisbtn.Tag.ToString();
                totalPrice.Text = thisbtn.Tag.ToString();
                roomNumber.Text = thisbtn.Text;
                idroompesan = thisbtn.Name.Substring(2);


                int a = Int32.Parse(roomPrice.Text.ToString());
                int b = Int32.Parse(tafp.Text.ToString());
                int c = a+b;
                int ttlpricetax = c / 10;
                tax.Text = ttlpricetax.ToString();

                int d = Int32.Parse(tax.Text);
                int total = c + d;
                totalPrice.Text = total.ToString();
            } else
            {
                MessageBox.Show("Kamar" + thisbtn.Text + "Sedang dipakai");
            }
        }
    }
}
