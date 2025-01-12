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
    public partial class ManageRoomForm : Form
    {

        DataTable dt = new DataTable();
        Koneksi conn = new Koneksi();

        string idrt;
        public ManageRoomForm()
        {
            InitializeComponent();

            dgv();
            cb();

            add.Enabled = true;
            edit.Enabled = false;
            delete.Enabled = false;

        }

        private void roomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageRoomForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bungaHotelDataSet1.TIpeKamar' table. You can move, or remove it, as needed.
            this.tIpeKamarTableAdapter.Fill(this.bungaHotelDataSet1.TIpeKamar);
            // TODO: This line of code loads data into the 'bungaHotelDataSet.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter.Fill(this.bungaHotelDataSet.Kamar);

        }


        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select k.IDKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,k.IDTipeKamar from Kamar as k left join TipeKamar as tk on k.IDTipeKamar=tk.IDTipeKamar");
            conn.adp.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].HeaderText = "Room ID";
            dataGridView1.Columns[1].HeaderText = "Room Type Name";
            dataGridView1.Columns[2].HeaderText = "Room Number";
            dataGridView1.Columns[3].HeaderText = "Floor";
            dataGridView1.Columns[4].Visible = false;
        }

       
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(cbrt.Text) || "".Equals(floor.Text) || "".Equals(roomNumber.Text)) {
                    MessageBox.Show("ada yang belum diisi");
                } else
                {
                    conn.cud("insert into Kamar (NomorKamar,Lantai,IDTipeKamar) values ('"+roomNumber.Text+"', '"+floor.Text+"'," +
                        "'"+ ((comboItem)cbrt.SelectedItem).value+"')");
                    MessageBox.Show("add success");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                ManageRoomForm form = new ManageRoomForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        public void cb()
        {
            DataTable items = new DataTable();
            items.Clear();
            cbrt.Items.Clear();
            conn.select("select * from TipeKamar");
            conn.adp.Fill(items);

            foreach (DataRow row in items.Rows)
            {
                cbrt.DisplayMember = "value";
                cbrt.DisplayMember = "text";
                cbrt.Items.Add(new comboItem()
                {
                    value = row[0].ToString(),
                    text = row[1].ToString()
                }
                );
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(cbrt.Text) || "".Equals(floor.Text) || "".Equals(roomNumber.Text))
                {
                    MessageBox.Show("ada yang belum diisi");
                }
                else
                {
                    if(cbrt.SelectedIndex < 0)
                    {
                    conn.cud("update Kamar set NomorKamar= '" + roomNumber.Text + "', Lantai= '" + floor.Text + "', IDTipeKamar=" +
                        "'" + idrt + "' where IDKamar='"+roomID.Text+"'");
                    MessageBox.Show("update success");
                    } else
                    {
                        conn.cud("update Kamar set NomorKamar= '" + roomNumber.Text + "', Lantai= '" + floor.Text + "', IDTipeKamar=" +
                       "'" + ((comboItem)cbrt.SelectedItem).value + "' where IDKamar='" + roomID.Text + "'");
                        MessageBox.Show("update success");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageRoomForm form = new ManageRoomForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                roomID.Text = row.Cells[0].Value.ToString();
                roomNumber.Text = row.Cells[2].Value.ToString();
                floor.Text = row.Cells[3].Value.ToString();
                idrt = row.Cells[1].Value.ToString();
                cbrt.Text =row.Cells[1].Value.ToString();

                add.Enabled = false;
                edit.Enabled = true;
                delete.Enabled = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("yakin hapus ?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    conn.cud("delete from Kamar where IDKamar='" + roomID.Text + "'");
                    MessageBox.Show("delete success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageRoomForm form = new ManageRoomForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();

            conn.select("select k.IDKamar,tk.NamaTipeKamar,k.NomorKamar,k.Lantai,k.IDTipeKamar from Kamar as k left join TipeKamar as tk on k.IDTipeKamar=tk.IDTipeKamar where tk.IDTipeKamar like '%"+textBox1.Text+ "%' or tk.NamaTipeKamar like '%"+textBox1.Text+ "%' or t.k.Deskripsi like '%"+textBox1.Text+"%'");
            conn.adp.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].HeaderText = "Room ID";
            dataGridView1.Columns[1].HeaderText = "Room Type Name";
            dataGridView1.Columns[2].HeaderText = "Room Number";
            dataGridView1.Columns[3].HeaderText = "Floor";
            dataGridView1.Columns[4].Visible = false;
        }
    }
}
