using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bungaHotel
{
    class Koneksi
    {
        public static string db = "Data Source=MYBOOKZSERIES;Initial Catalog=bungaHotel;Integrated Security=True;";
        public SqlConnection koneksi = new SqlConnection(db);
        public SqlCommand cmd;
        public SqlDataAdapter adp = new SqlDataAdapter();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataSet ds;

        public void select(string query)
        {
            try
            {
                dt.Clear();
                koneksi.Open();
                cmd = new SqlCommand(query,koneksi);
                adp.SelectCommand = cmd;
                adp.Fill(dt);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                koneksi.Close();
            }
        }

        public void cud(string query)
        {
            try
            {
                koneksi.Open();
                cmd = new SqlCommand(query,koneksi);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                koneksi.Close();
            }
        }

        public void chart(string query)
        {
            try
            {
                koneksi.Open();
                cmd = new SqlCommand(query, koneksi);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}
