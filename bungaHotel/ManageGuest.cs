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
    public partial class ManageGuest : Form
    {
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        string id;
        public ManageGuest()
        {
            InitializeComponent();
            dgv();
            cbitem();

            add.Enabled = true;
            edit.Enabled = false;
            delete.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbitem()
        {
            DataTable item = new DataTable();
            item.Clear();
            vehicleType.Items.Clear();
            conn.select("select * from TipeKendaraan");
            conn.adp.Fill(item);

            foreach(DataRow row in item.Rows)
            {
                vehicleType.DisplayMember = "value";
                vehicleType.DisplayMember = "text";
                vehicleType.Items.Add(new comboItem(){text = row[1].ToString(), value = row[0].ToString()});
            }
        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();
            conn.select("select * from Penghuni left join TipeKendaraan on Penghuni.IDTipeKendaraan=TipeKendaraan.IDTIpeKendaraan");
            conn.adp.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ID Guest";
            dataGridView1.Columns[1].HeaderText = "Guest Name";
            dataGridView1.Columns[2].HeaderText = "ID Card Number";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Phone Number";
            dataGridView1.Columns[5].HeaderText = "Vehicle License Number";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Vehicle Type";
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(gName.Text) || "".Equals(vehicleNO.Text) || "".Equals(vehicleType.Text) || "".Equals(email.Text) || "".Equals(noHP.Text)
                    || "".Equals(IDCardNumber.Text))
                {
                    MessageBox.Show("isi semua kolom");
                }
                else
                {
                    conn.cud("insert into Penghuni (GuestName,IDCardNumber,Email,PhoneNumber,PlatNoKendaraan,IDTipeKendaraan) values" +
                        " ('"+gName.Text+"', '"+IDCardNumber.Text+"','"+email.Text+"','"+noHP.Text+"', '"+vehicleNO.Text+"','"+((comboItem)vehicleType.SelectedItem).value+"')");

                    MessageBox.Show("add success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageGuest form = new ManageGuest();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Yakin hapus?", "warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(DialogResult.Yes == result)
                {
                conn.cud("delete from Penghuni where GuestID = '" + id + "'");
                    MessageBox.Show("delete success");
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageGuest form = new ManageGuest();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];

            id = row.Cells[0].Value.ToString();
            gName.Text = row.Cells[1].Value.ToString();
            noHP.Text = row.Cells[4].Value.ToString();
            IDCardNumber.Text = row.Cells[2].Value.ToString();
            email.Text = row.Cells[3].Value.ToString();
            vehicleType.Text = row.Cells[8].Value.ToString();
            vehicleNO.Text = row.Cells[5].Value.ToString();

            add.Enabled = false;
            edit.Enabled = true;
            delete.Enabled = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(gName.Text) || "".Equals(vehicleNO.Text) || "".Equals(vehicleType.Text) || "".Equals(email.Text) || "".Equals(noHP.Text)
                    || "".Equals(IDCardNumber.Text))
                {
                    MessageBox.Show("isi semua kolom");
                }
                else
                {
                    conn.cud("update Penghuni set GuestName = '"+ gName.Text + "', IDCardNumber= '" + IDCardNumber.Text + "',Email='" + email.Text + "'" +
                        ",PhoneNumber= '" + noHP.Text + "', PlatNoKendaraan= '" + vehicleNO.Text + "', IDTipeKendaraan='" + ((comboItem)vehicleType.SelectedItem).value + "'");

                    MessageBox.Show("update success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageGuest form = new ManageGuest();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
            conn.select("select * from Penghuni left join TipeKendaraan on Penghuni.IDTipeKendaraan=TipeKendaraan.IDTIpeKendaraan where Email LiKE '%"
                +textBox1.Text+"%' or GuestName LIKE '%"+textBox1.Text+"%' or PhoneNumber LIKE '%"+textBox1.Text+"%'");
            conn.adp.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "ID Guest";
            dataGridView1.Columns[1].HeaderText = "Guest Name";
            dataGridView1.Columns[2].HeaderText = "ID Card Number";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Phone Number";
            dataGridView1.Columns[5].HeaderText = "Vehicle License Number";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Vehicle Type";
        }

        private void load_Click(object sender, EventArgs e)
        {

        }
    }
}
