namespace ProjectAkhirPemvis
{
    partial class form_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.tb_judul = new System.Windows.Forms.TextBox();
            this.tb_pengarang = new System.Windows.Forms.TextBox();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panel Perpustakaan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username : ";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(155, 80);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(27, 13);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "user";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 256);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Judul";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pengarang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Harga";
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(179, 143);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(129, 20);
            this.tb_isbn.TabIndex = 9;
            // 
            // tb_judul
            // 
            this.tb_judul.Location = new System.Drawing.Point(179, 180);
            this.tb_judul.Name = "tb_judul";
            this.tb_judul.Size = new System.Drawing.Size(129, 20);
            this.tb_judul.TabIndex = 10;
            // 
            // tb_pengarang
            // 
            this.tb_pengarang.Location = new System.Drawing.Point(179, 215);
            this.tb_pengarang.Name = "tb_pengarang";
            this.tb_pengarang.Size = new System.Drawing.Size(129, 20);
            this.tb_pengarang.TabIndex = 11;
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(179, 253);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(129, 20);
            this.tb_harga.TabIndex = 12;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(233, 299);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 13;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(152, 299);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(233, 328);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 15;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(152, 328);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(71, 299);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 17;
            this.btn_get.Text = "Get Data";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 363);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.tb_pengarang);
            this.Controls.Add(this.tb_judul);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_admin";
            this.Text = "Panel Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.TextBox tb_judul;
        private System.Windows.Forms.TextBox tb_pengarang;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_get;
    }
}