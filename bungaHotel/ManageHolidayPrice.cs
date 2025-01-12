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
    public partial class ManageHolidayPrice : Form
    {

        DataTable dt = new DataTable();
        Koneksi conn = new Koneksi();
        string idhf, idrt;
        Boolean newItem = true;
        public ManageHolidayPrice()
        {
            InitializeComponent();

            dgv();
            cb();
            add.Text = "Add";
            newItem = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void cb()
        {
            DataTable dt2 = new DataTable();
            dt2.Clear();
            cbrt1.Items.Clear();

            conn.select("select * from TipeKamar");
            conn.adp.Fill(dt2);

            foreach (DataRow dr in dt2.Rows )
            {
                cbrt1.DisplayMember = "value";
                cbrt1.DisplayMember = "text";
                cbrt1.Items.Add(new comboItem() { text = dr[1].ToString(), value = dr[0].ToString() } );
            }
        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();
            conn.select("select hf.IDHargaFluktuatif,tk.IDTipeKamar,tk.NamaTIpeKamar,hk.HargaKamar,hf.Persentasi,hk.HargaKamar + (hf.Persentasi * hk.HargaKamar/100)" +
                " as 'Final Price', hf.tglMulai,hf.tglSelesai from HargaFLuktuatif hf inner join " +
                "TipeKamar tk on hf.IDTipeKamar = tk.IDTipeKamar inner join HargaKamar hk on tk.IDTipeKamar = hk.IDTipeKamar");
            conn.adp.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow dtr in dt.Rows)
            {
                string[] row = new string[]
                {
                    dtr[0].ToString(),
                    dtr[1].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString(),
                    dtr[6].ToString(),
                    dtr[7].ToString(),
                };

                dataGridView1.Rows.Add(row);
            }
        }

        private void restart ()
        {
            ManageHolidayPrice form = new ManageHolidayPrice();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void ManageHolidayPrice_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if(newItem)
                {

                conn.cud("insert into HargaFLuktuatif (Persentasi,tglMulai,tglSelesai,IDTipeKamar) values ('" + txt_persen.Text+"'," +
                    "'"+begin_date.Value.ToString("yyyy-MM-dd") +"', '"+end_date.Value.ToString("yyyy-MM-dd") +"', '"+((comboItem) cbrt1.SelectedItem).value +"' )");

                MessageBox.Show("add success");
                } else
                {
                    if(cbrt1.SelectedIndex < 0)
                    {
                        conn.cud("update HargaFLuktuatif set Persentasi='" + txt_persen.Text + "', tglMulai=" +
                            "'" + begin_date.Value.ToString("yyyy-MM-dd") + "',tglSelesai= '" + end_date.Value.ToString("yyyy-MM-dd") + "', " +
                            "IDTipeKamar= '" + idrt + "' ");
                MessageBox.Show("update success");
                    } else
                    {
                        conn.cud("update HargaFLuktuatif set Persentasi='" + txt_persen.Text + "', tglMulai=" +
                           "'" + begin_date.Value.ToString("yyyy-MM-dd") + "',tglSelesai= '" + end_date.Value.ToString("yyyy-MM-dd") + "', " +
                           "IDTipeKamar= '" + ((comboItem)cbrt1.SelectedItem).value + "' ");
                        MessageBox.Show("update success");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                restart();
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
            conn.select("select hf.IDHargaFluktuatif,tk.IDTipeKamar,tk.NamaTIpeKamar,hk.HargaKamar,hf.Persentasi,hk.HargaKamar + " +
                "(hf.Persentasi * hk.HargaKamar/100) as 'Final Price', hf.tglMulai,hf.tglSelesai from HargaFLuktuatif hf inner join " +
                "TipeKamar tk on hf.IDTipeKamar = tk.IDTipeKamar inner join HargaKamar hk on tk.IDTipeKamar = hk.IDTipeKamar inner join Kamar k on tk.IDTipeKamar = k.IDTIpeKamar " +
                "where  k.IDKamar like '%" +search.Text+ "%' or k.Lantai like '%" +search.Text+ "%' or k.NomorKamar like '%" +search.Text+"%'" +
                " or tk.NamaTipeKamar like '%" +search.Text+"%'");
            conn.adp.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow dtr in dt.Rows)
            {
                string[] row = new string[]
                {
                    dtr[0].ToString(),
                    dtr[1].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString(),
                    dtr[6].ToString(),
                    dtr[7].ToString(),
                };

                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idhf = row.Cells[0].Value.ToString();
                idrt = row.Cells[1].Value.ToString();

                begin_date.Text = row.Cells[6].Value.ToString();
                end_date.Text = row.Cells[7].Value.ToString();
                txt_persen.Text = row.Cells[4].Value.ToString();
                cbrt1.Text = row.Cells[2].Value.ToString();

                newItem = false;
                add.Text = "Edit";
            }

            if(e.ColumnIndex ==  8)
            {
                try
                {
                    DialogResult result = MessageBox.Show("yakin hapus?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        conn.cud("delete from HargaFLuktuatif where IDHargaFluktuatif = '" + idhf + "'");
                    MessageBox.Show("delete success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    restart();
                }
              
            }
        }
    }
}
