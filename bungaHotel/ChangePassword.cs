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
    public partial class ChangePassword : Form
    {
        string idKaryawan, oldP;
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        public ChangePassword(string idKaryawan)
        {
            InitializeComponent();
            this.idKaryawan = idKaryawan;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                conn.select("select * from Karyawan where IDKaryawan = '" + idKaryawan + "'");
                conn.adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    oldP = row[3].ToString();
                }

                if ("".Equals(oldPassword.Text) || "".Equals(confirmPassword.Text) || "".Equals(newPassword.Text))
                {
                    MessageBox.Show("ada yang belum diisi");
                }
                else
                {
                    if (oldPassword.Text != oldP.ToString())
                    {
                        MessageBox.Show("wrong old password");
                    }
                    else if (confirmPassword.Text != newPassword.Text)
                    {
                        MessageBox.Show("confirm password salah");
                    }
                    else
                    {
                        conn.cud("update Karyawan set Password='" + confirmPassword.Text + "' where IDKaryawan='" + idKaryawan + "'");
                        MessageBox.Show("update password success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                oldPassword.Text = "";
                newPassword.Text = "";
                confirmPassword.Text = "";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
        }
    }
}
