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
    public partial class ManageRoomFacility : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        int i = 1;
        public ManageRoomFacility()
        {
            InitializeComponent();

            dgv();
            cb();
            i = 1;
        }

        private void roomID_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select ftbk.IDFasilitas,tk.IDTipeKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,f.NamaFasilitas from FasilitasBerdasarkanTipeKamar" +
                " ftbk inner join TipeKamar tk on ftbk.IDTipeKamar = tk.IDTipeKamar inner join Kamar k on tk.IDTipeKamar = k.IDTipeKamar inner join" +
                " Fasilitas f on ftbk.IDFasilitas = f.IDFasilitas where k.NomorKamar like '%" + textBox1.Text + "%' or f.NamaFasilitas like '%" + textBox1.Text + "%'");

            conn.adp.Fill(dt);
            //dataGridView1.DataSource = dt;
            dataGridView1.Rows.Clear();

            foreach (DataRow dtr in dt.Rows)
            {
                string[] row = new string[]
                {
                    i.ToString(),
                    dtr[0].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString(),


                };

                dataGridView1.Rows.Add(row);
                
            }
        }

        private void ManageRoomFacility_Load(object sender, EventArgs e)
        {

        }

        private void cb ()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            cbrt1.Items.Clear();

            conn.select("select * from TipeKamar");
            conn.adp.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                cbrt1.DisplayMember = "value";
                cbrt1.DisplayMember = "text";
                cbrt1.Items.Add(new comboItem() { text = dr[1].ToString(), value= dr[0].ToString() } );
            }

            DataTable dt2 = new DataTable();
            dt2.Clear();
            cbrt2.Items.Clear();

            conn.select("select * from Fasilitas");
            conn.adp.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                cbrt2.DisplayMember = "value";
                cbrt2.DisplayMember = "text";
                cbrt2.Items.Add(new comboItem() { text = dr[1].ToString(), value= dr[0].ToString() } );
            }
        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select ftbk.IDFasilitas,tk.IDTipeKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,f.NamaFasilitas from FasilitasBerdasarkanTipeKamar" +
                " ftbk inner join TipeKamar tk on ftbk.IDTipeKamar = tk.IDTipeKamar inner join Kamar k on tk.IDTipeKamar = k.IDTipeKamar inner join" +
                " Fasilitas f on ftbk.IDFasilitas = f.IDFasilitas");

            conn.adp.Fill(dt);
            //dataGridView1.DataSource = dt;
            dataGridView1.Rows.Clear();

            foreach (DataRow dtr in dt.Rows)
            {
                string[] row = new string[]
                {
                    i.ToString(),
                    dtr[0].ToString(),
                    dtr[2].ToString(),
                    dtr[3].ToString(),
                    dtr[4].ToString(),
                    dtr[5].ToString(),


                };

                dataGridView1.Rows.Add(row);
                i++;
            }

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            ManageRoomFacility form = new ManageRoomFacility();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                conn.cud("insert into FasilitasBerdasarkanTipeKamar (IDFasilitas,IDTipeKamar) values ('" + ((comboItem)cbrt2.SelectedItem).value+"','"+ ((comboItem)cbrt1.SelectedItem).value+"')");
                    MessageBox.Show("add success");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                ManageRoomFacility form = new ManageRoomFacility();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            if(e.ColumnIndex == 6)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show("Yakin Hapus ? ", "warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(DialogResult.Yes == result)
                {
                    conn.cud("delete from FasilitasBerdasarkanTipeKamar where IDFasilitas='" + id + "'");
                    MessageBox.Show("delete success");
                }
            }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                ManageRoomFacility form = new ManageRoomFacility();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
