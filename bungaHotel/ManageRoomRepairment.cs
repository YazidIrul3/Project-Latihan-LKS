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
    public partial class ManageRoomRepairment : Form
    {
        string idKaryawan,idpk,idk;
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        bool newItem = true;
        public ManageRoomRepairment(string idKaryawan)
        {
            InitializeComponent();
            this.idKaryawan = idKaryawan;

            dgv();
            cb();

            add.Text = "Add";
            newItem = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void begin_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ManageRoomRepairment_Load(object sender, EventArgs e)
        {

        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select pk.IDPerbaikanKamar,k.IDKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,pk.TgMulai,pk.TgSelesai," +
                "kry.NamaKaryawan,pk.Note from PerbaikanKamar pk inner join Kamar k on pk.IDKamar = k.IDKamar inner join" +
                " Karyawan kry on pk.IDKaryawan = kry.IDKaryawan inner join TipeKamar tk on k.IDTipeKamar = tk.IDTipeKamar ");
            conn.adp.Fill(dt);
            //dataGridView1.DataSource = dt;
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
                    dtr[8].ToString(),
                };
                dataGridView1.Rows.Add(row);
            };
        }

        private void restrat()
        {
            ManageRoomRepairment form = new ManageRoomRepairment(idKaryawan);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            restrat();
        }

        private void cb()
        {
            DataTable dt2 = new DataTable();
            dt2.Clear();
            cbrt1.Items.Clear();
            conn.select("select NomorKamar,IDKamar from Kamar");
            conn.adp.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                cbrt1.DisplayMember = "text";
                cbrt1.DisplayMember = "value";

                cbrt1.Items.Add(new comboItem() { text = dr[0].ToString(), value = dr[1].ToString() } );
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select pk.IDPerbaikanKamar,k.IDKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,pk.TgMulai,pk.TgSelesai," +
                "kry.NamaKaryawan,pk.Note from PerbaikanKamar pk inner join Kamar k on pk.IDKamar = k.IDKamar inner join" +
                " Karyawan kry on pk.IDKaryawan = kry.IDKaryawan inner join TipeKamar tk on k.IDTipeKamar = tk.IDTipeKamar " +
                "where tk.NamaTipeKamar like '%"+textBox1.Text+ "%' or k.NomorKamar  like '%"+textBox1.Text+"%' or tk.IDTipeKamar " +
                " like '%"+textBox1.Text+"%'");
            conn.adp.Fill(dt);
            //dataGridView1.DataSource = dt;
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
                    dtr[8].ToString(),
                };
                dataGridView1.Rows.Add(row);
            };
        }

        private void roomID_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select pk.IDPerbaikanKamar,k.IDKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,pk.TgMulai,pk.TgSelesai," +
                "kry.NamaKaryawan,pk.Note from PerbaikanKamar pk inner join Kamar k on pk.IDKamar = k.IDKamar inner join" +
                " Karyawan kry on pk.IDKaryawan = kry.IDKaryawan inner join TipeKamar tk on k.IDTipeKamar = tk.IDTipeKamar " +
                "where tk.NamaTipeKamar like '%" + search.Text + "%' or k.NomorKamar  like '%" + search.Text + "%' or tk.IDTipeKamar " +
                " like '%" + search.Text + "%'");
            conn.adp.Fill(dt);
            //dataGridView1.DataSource = dt;
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
                    dtr[8].ToString(),
                };
                dataGridView1.Rows.Add(row);
            };
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(cbrt1.Text) || "".Equals(end_date.Text) || "".Equals(begin_date.Text) || "".Equals(txt_note.Text))
                {
                    MessageBox.Show("ada yang belum diisi");
                } else
                {

                    if(newItem == true)
                    {

                conn.cud("insert into PerbaikanKamar (TgMulai,TgSelesai,Note,IDKamar,IDKaryawan) values ('"+begin_date.Value.ToString("yyyy-MM-dd") +"'," +
                    "'"+end_date.Value.ToString("yyyy-MM-dd")+"', '"+txt_note.Text+"','"+((comboItem) cbrt1.SelectedItem).value+"', '"+idKaryawan+"')");

                MessageBox.Show("add success");
                    } 
                    if(newItem == false)
                    {
                        if(cbrt1.SelectedIndex < 0)
                        {
                            conn.cud("update PerbaikanKamar set IDKamar='" + idk + "', TgMulai='" + begin_date.Value.ToString("yyyy-MM-dd") + "'," +
                         "TgSelesai='" + end_date.Value.ToString("yyyy-MM-dd") + "',Note='"+txt_note.Text+"' where IDPerbaikanKamar='" + idpk + "'");
                            MessageBox.Show("update success");

                        } else
                        {
                        conn.cud("update PerbaikanKamar set IDKamar='"+ ((comboItem)cbrt1.SelectedItem).value+"', TgMulai='"+begin_date.Value.ToString("yyyy-MM-dd")+"'," +
                            "TgSelesai='"+end_date.Value.ToString("yyyy-MM-dd")+ "',Note='"+txt_note.Text+"' where IDPerbaikanKamar='" + idpk+"'");
                MessageBox.Show("update success");
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                restrat();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    idpk = row.Cells[0].Value.ToString();
                    idk = row.Cells[1].Value.ToString();
                    begin_date.Text = row.Cells[5].Value.ToString();
                    end_date.Text = row.Cells[6].Value.ToString();
                    cbrt1.Text = row.Cells[3].Value.ToString();
                    txt_note.Text = row.Cells[8].Value.ToString();

                    add.Text = "Edit";
                    newItem = false;
                }

                if (e.ColumnIndex == 9)
                {
                    DialogResult result = MessageBox.Show("Yakin Hapus?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        conn.cud("delete from PerbaikanKamar where IDPerbaikanKamar= '" + idpk + "'");

                        MessageBox.Show("delete success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                restrat();
            }
           
        }
    }
}
