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
    public partial class Form2 : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "db_pemvis";
        private const String UID = "root";
        private const String PASSWORD = "12345678";
        private static MySqlConnection dbConn;
        private form_login frm_login;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(form_login frmLogin)
        {
            InitializeComponent();
            frm_login = frmLogin;
            this.Owner = frm_login;
        }
        private void Koneksi()
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.Server = SERVER;
            build.Database = DATABASE;
            build.UserID = UID;
            build.Password = PASSWORD;

            String connString = build.ToString();

            dbConn = new MySqlConnection(connString);
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            Koneksi();
            String username = tbUser.Text;
            String password = tbPassword.Text;
            String level = "user";
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau Password kosong");
                return;
            }
            else
            {
                String query = string.Format("INSERT INTO user(username, password, level) VALUES('{0}','{1}','{2}')", username, password, level);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Pendaftaran berhasil");
            }
        }

    }
}

