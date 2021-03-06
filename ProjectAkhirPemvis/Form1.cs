﻿using MySql.Data.MySqlClient;
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
    public partial class form_login : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "db_pemvis";
        private const String UID = "root";
        private const String PASSWORD = "12345678";
        private static MySqlConnection dbConn;
        public form_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = tb_username.Text;
            String password = tb_password.Text;
            String level = "";

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;

            String connString = builder.ToString();

            dbConn = new MySqlConnection(connString);


            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau Password Kosong");
                return;
            }
            else
            {
                dbConn.Open();
                String query = string.Format("SELECT * FROM user WHERE username = '{0}' AND password = '{1}'", username, password);
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   level = reader.GetString("level");
                    if (level == "admin")
                    {
                        MessageBox.Show("Login Berhasil");
                        Form frm_admin = new form_admin(username, this);
                        frm_admin.Show();
                    }
                    else if (level == "user")
                    {
                        MessageBox.Show("Login Berhasil");
                        Form frm_user = new Form_User(username, this);
                        frm_user.Show();
                        //this.Hide();
                    }

                }
                dbConn.Close();

            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.ShowDialog();
        }
    }
}
