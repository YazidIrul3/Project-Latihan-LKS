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
    public partial class ManageEmployee : Form
    {

        DataTable dt = new DataTable();
        Koneksi koneksi = new Koneksi();
        string gender,id;
        public ManageEmployee()
        {
            InitializeComponent();
            dgv();

            add.Enabled = true;
            edit.Enabled = false;
            delete.Enabled = false;
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            koneksi.select("select * from Karyawan");
            koneksi.adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Employee ID";
            dataGridView1.Columns[1].HeaderText = "Employee Name";
            dataGridView1.Columns[4].HeaderText = "Date Of Birth";
            dataGridView1.Columns[5].HeaderText = "Gender";
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if("".Equals(eName.Text) || "".Equals(password.Text) || "".Equals(date.Text) || "".Equals(gender)  )
                {
                    MessageBox.Show("isi semua kolom");
                } else
                {
                    if(male.Checked)
                    {
                        gender = "M";
                    } else
                    {
                        gender = "F";
                    }

                    koneksi.cud("insert into Karyawan(NamaKaryawan,Email,Password,tblLahir,JenisKelamin) values ('"+eName.Text+"','"+email.Text+"'" +
                        ", '"+password.Text+"','"+date.Value.ToString("yyyy-MM-dd") + "', '"+gender+"')");
                    MessageBox.Show("added Success");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                ManageEmployee form = new ManageEmployee();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void eName_TextChanged(object sender, EventArgs e)
        {
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            female.Checked = false;
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            male.Checked = false;

        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(eName.Text) || "".Equals(password.Text) || "".Equals(date.Text) || "".Equals(gender))
                {
                    MessageBox.Show("isi semua kolom");
                }
                else
                {
                    if (male.Checked)
                    {
                        gender = "M";
                    }
                    else
                    {
                        gender = "F";
                    }

                    koneksi.cud("update Karyawan set NamaKaryawan='"+eName.Text+"',Email='"+eName.Text+"',Password='"+password.Text+"',tblLahir='"+date.Value.ToString("yyyy-MM-dd")+"',JenisKelamin='"+gender+"' where IDKaryawan='"+id+"'");
                    MessageBox.Show("Update Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageEmployee form = new ManageEmployee();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Yakin Hapus?","warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(DialogResult.Yes == result)
                {

                    koneksi.cud("delete from Karyawan where IDKaryawan='" + id + "'");
                    MessageBox.Show("Delete Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                ManageEmployee form = new ManageEmployee();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            koneksi.select("select * from Karyawan where NamaKaryawan LIKE'%" + textBox1.Text + "%' or Email LIKE '%" + textBox1.Text + "%'");
            koneksi.adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Employee ID";
            dataGridView1.Columns[1].HeaderText = "Employee Name";
            dataGridView1.Columns[4].HeaderText = "Date Of Birth";
            dataGridView1.Columns[5].HeaderText = "Gender";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            id = row.Cells[0].Value.ToString();

            eName.Text = row.Cells[1].Value.ToString();
            email.Text = row.Cells[2].Value.ToString();
            password.Text = row.Cells[3].Value.ToString();
            date.Text = row.Cells[4].Value.ToString();
            
            if(row.Cells[5].Value.ToString() == "M")
            {
                male.Checked = true;
                gender = "M";

            } else
            {
                female.Checked = true;
                gender = "F";
            }

            add.Enabled = false;
            edit.Enabled = true;
            delete.Enabled = true;
        }
    }

   
}
