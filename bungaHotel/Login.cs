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
    public partial class Login : Form
    {

        Koneksi Koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string idKaryawan;
        public Login()
        {
            InitializeComponent();
            txt_email.Text = "coba@gmail.com";
            txt_password.Text = "1234";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if("".Equals(txt_email.Text) || "".Equals(txt_password.Text) ){
                MessageBox.Show("data ada yang belum diisi");
            }
            else
            {
                Koneksi.select("select IDKaryawan,Email,Password from Karyawan where Email ='" + txt_email.Text + 
                    "' and Password='"+txt_password.Text+"'");
                Koneksi.adp.Fill(dt);

                if(Koneksi.dt.Rows.Count <= 0 )
                {
                    MessageBox.Show("wrong account");
                } else
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        idKaryawan = row[0].ToString();
                    }

                    MainForm mf = new MainForm(idKaryawan);
                    this.Hide();
                    mf.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
