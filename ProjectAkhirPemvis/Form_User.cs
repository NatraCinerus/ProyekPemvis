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
    public partial class Form_User : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "db_pemvis";
        private const String UID = "root";
        private const String PASSWORD = "12345678";
        private static MySqlConnection dbConn;
        private Form frm_login;
        MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1;database=db_pemvis;uid=root;pwd=12345678");

        public Form_User()
        {
            InitializeComponent();
        }

        public Form_User(string username, Form frm1)
        {
            InitializeComponent();
            lbl_username.Text = username;
            this.Owner = frm1;
            frm_login = frm1;
        }

        public void lihatdata()
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "SELECT * FROM buku";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_isbn.Text = "";
            tb_harga.Text = "";
            tb_jml.Text = "";
            tb_judul.Text = "";
            tb_total.Text = "";
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            String isbn = tb_isbn.Text;

            tb_jml.Text = "";
            tb_total.Text = "";

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

        private void totalHarga(object sender, KeyEventArgs e)
        {
            int harga = Int32.Parse(tb_harga.Text);
            int jml = Int32.Parse(tb_jml.Text);
            int total = harga * jml;
            tb_total.Text = total.ToString();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string isbn = tb_isbn.Text;
            string judul = tb_judul.Text;
            string harga = tb_harga.Text;
            string total = tb_total.Text;
            string jml = tb_jml.Text;
            string[] row = new string[] { isbn, judul, harga, jml, total };
            dataGridView1.Rows.Add(row);

            int parse_total = Int32.Parse(total);
            string string_lbl = lbl_total.Text;
            int int_lbl = Int32.Parse(string_lbl);
            int_lbl += parse_total;
            lbl_total.Text = int_lbl.ToString();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in dataGridView1.SelectedCells)
            {
                if (item.Selected)
                {
                    var cek = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cek == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(item.RowIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Anda belum memilih data");
                }
                
            }
            
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string total_belanja = lbl_total.Text;
            string status = "Blm lunas";
            string username = lbl_username.Text;
            string isbn, judul, jml, harga, total_harga;
            if (dataGridView1.Rows.Count < 0)
            {
                MessageBox.Show("Data Kosong");
                return;
            }
            else
            {
                for (int i=0 ; i < (dataGridView1.Rows.Count - 1) ; i++)
                {
                    isbn = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    judul = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    jml = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    harga = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    total_harga = dataGridView1.Rows[i].Cells[4].Value.ToString();

                    String query = string.Format("INSERT INTO transaksi(username, isbn, judul, jml, harga, total_harga, total_belanja, status) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", 
                        username, isbn, judul, jml, harga, total_harga, total_belanja, status);
                    MySqlCommand cmd = new MySqlCommand(query, dbConn);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                    dbConn.Close();
                }
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
        }

        private void form_user_load(object sender, EventArgs e)
        {
            lihatdata();
        }
    }
}
