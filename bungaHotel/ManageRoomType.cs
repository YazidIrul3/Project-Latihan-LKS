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
    public partial class ManageRoomType : Form
    {

        DataTable dt = new DataTable();
        Koneksi conn = new Koneksi();
        public ManageRoomType()
        {
            InitializeComponent();
            dgv();
            add.Enabled = true;
            edit.Enabled = false;
            delete.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ManageRoomType_Load(object sender, EventArgs e)
        {

        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select * from TipeKamar");
            conn.adp.Fill(dt);        
            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ID Room";
            dataGridView1.Columns[1].HeaderText = "Room Name";
            dataGridView1.Columns[2].HeaderText = "Description";
;        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(roomName.Text) || "".Equals(roomID.Text) || "".Equals(description.Text))
                {
                    MessageBox.Show("harus di isi semua");
                }

                conn.cud("insert into TipeKamar (NamaTipeKamar,Deskripsi) values ('"+roomName.Text+"', '"+description.Text+"')");
                MessageBox.Show("added success");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                ManageRoomType form = new ManageRoomType();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            
            roomID.Text = row.Cells[0].Value.ToString();
            roomName.Text = row.Cells[1].Value.ToString();
            description.Text = row.Cells[2].Value.ToString();

            add.Enabled = false;
            edit.Enabled = true;
            delete.Enabled = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(roomName.Text) || "".Equals(roomID.Text) || "".Equals(description.Text))
                {
                    MessageBox.Show("harus di isi semua");
                }
                conn.cud("update TipeKamar set NamaTipeKamar='" + roomName.Text + "', Deskripsi= '" + description.Text + "' where IDTipeKamar = '"+roomID.Text+"'");
                MessageBox.Show("update success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageRoomType form = new ManageRoomType();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("anda yakin ingn hapus ini ?" , "warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {
                

                conn.cud("delete from TipeKamar where IDTipeKamar='"+roomID.Text+"'");
                MessageBox.Show("delete success");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageRoomType form = new ManageRoomType();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select * from TipeKamar where NamaTipeKamar like '%"+textBox1.Text+"%' or IDTipeKamar like '%"+textBox1.Text+"' or " +
                " Deskripsi like '%"+textBox1.Text+"%' ");
            conn.adp.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ID Room";
            dataGridView1.Columns[1].HeaderText = "Room Name";
            dataGridView1.Columns[2].HeaderText = "Description";
        }
    }
}
