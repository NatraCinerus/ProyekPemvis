using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhirPemvis
{
    public partial class form_admin : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "db_pemvis";
        private const String UID = "root";
        private const String PASSWORD = "12345678";
        private static MySqlConnection dbConn;
        private Form frm_login;
        MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1;database=db_pemvis;uid=root;pwd=12345678");
        public form_admin()
        {
            InitializeComponent();
        }

        public form_admin(string username, Form frm1)
        {
            InitializeComponent();
            lbl_username.Text = username;
            this.Owner = frm1;
            frm_login = frm1;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);

            String isbn = tb_isbn.Text;
            String judul = tb_judul.Text;
            String pengarang = tb_pengarang.Text;
            String harga = tb_harga.Text;
            if (String.IsNullOrEmpty(isbn) || String.IsNullOrEmpty(judul))
            {
                MessageBox.Show("ISBN atau Judul kosong");
                return;
            }
            else
            {
                dbConn.Open();
                String query = string.Format("INSERT INTO buku(isbn, judul, pengarang, harga) VALUES('{0}','{1}','{2}','{3}')", isbn, judul, pengarang, harga);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Buku Berhasil Ditambahkan");
            }
        }

        public void lihatdataBuku()
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "SELECT * FROM buku";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        public void lihatdataTransaksi()
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "SELECT * FROM transaksi";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            lihatdataBuku();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            String isbn = tb_isbn.Text;

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);

            if (String.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("ID Kosong");
                return;
            }
            else
            {
                dbConn.Open();
                String query = string.Format("SELECT * FROM buku WHERE isbn = '{0}'", isbn);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tb_judul.Text = reader.GetString(1);
                        tb_pengarang.Text = reader.GetString(2);
                        tb_harga.Text = reader.GetString(3);
                    }
                    dbConn.Close();
                }
                else
                {
                    MessageBox.Show("ISBN tidak ada");
                    dbConn.Close();
                }

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String isbn = tb_isbn.Text;
            String judul = tb_judul.Text;
            String harga = tb_harga.Text;
            String pengarang = tb_pengarang.Text;

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);

            if (String.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("ISBN kosong");
                return;
            }
            else
            {
                String query = string.Format("UPDATE buku SET isbn = '{0}', judul = '{1}', pengarang = '{2}', harga = '{3}' WHERE isbn = '{4}'", isbn, judul, pengarang, harga, isbn);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Data berhasil diubah");
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            String isbn = tb_isbn.Text;

            if (String.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("ISBN kosong");
                return;
            }
            else
            {
                var cek = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cek == DialogResult.Yes)
                {
                    String query = string.Format("DELETE FROM buku WHERE isbn = '{0}'", isbn);
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                    dbConn.Close();
                }
            }
        }

        private void form_admin_Load(object sender, EventArgs e)
        {
            lihatdataBuku();
            lihatdataTransaksi();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_isbn.Text = "";
            tb_judul.Text = "";
            tb_pengarang.Text = "";
            tb_harga.Text = "";
        }

        private void btn_refresh_trans_Click(object sender, EventArgs e)
        {
            lihatdataTransaksi();
        }

        private void btn_lunas_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);

            string username = tb_username.Text;
            MessageBox.Show(username);
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username kosong");
                return;
            }
            else
            {
                String query = string.Format("UPDATE transaksi SET status = 'lunas' WHERE username = '{0}'", username);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Data berhasil diubah");
            }
        }
    }
}
