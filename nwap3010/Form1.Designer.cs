namespace nwap3010
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            nupbirimfiyat = new NumericUpDown();
            cmbtedarik = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cmbkategori = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txturunad = new TextBox();
            txturunid = new TextBox();
            btnguncel = new Button();
            btnbul = new Button();
            btnsil = new Button();
            btnkaydet = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupbirimfiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(nupbirimfiyat);
            panel1.Controls.Add(cmbtedarik);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbkategori);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txturunad);
            panel1.Controls.Add(txturunid);
            panel1.Controls.Add(btnguncel);
            panel1.Controls.Add(btnbul);
            panel1.Controls.Add(btnsil);
            panel1.Controls.Add(btnkaydet);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 177);
            panel1.TabIndex = 1;
            // 
            // nupbirimfiyat
            // 
            nupbirimfiyat.Location = new Point(102, 138);
            nupbirimfiyat.Name = "nupbirimfiyat";
            nupbirimfiyat.Size = new Size(120, 23);
            nupbirimfiyat.TabIndex = 5;
            // 
            // cmbtedarik
            // 
            cmbtedarik.FormattingEnabled = true;
            cmbtedarik.Items.AddRange(new object[] { "Deneme", "deneme1" });
            cmbtedarik.Location = new Point(102, 100);
            cmbtedarik.Name = "cmbtedarik";
            cmbtedarik.Size = new Size(176, 23);
            cmbtedarik.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 135);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 3;
            label5.Text = "Birim Fiyatı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 106);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Tedarikçi Adı";
            // 
            // cmbkategori
            // 
            cmbkategori.FormattingEnabled = true;
            cmbkategori.Location = new Point(102, 71);
            cmbkategori.Name = "cmbkategori";
            cmbkategori.Size = new Size(176, 23);
            cmbkategori.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 77);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Kategori Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 42);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Ürün ID";
            // 
            // txturunad
            // 
            txturunad.Location = new Point(102, 42);
            txturunad.Name = "txturunad";
            txturunad.Size = new Size(183, 23);
            txturunad.TabIndex = 2;
            // 
            // txturunid
            // 
            txturunid.Location = new Point(102, 13);
            txturunid.Name = "txturunid";
            txturunid.Size = new Size(100, 23);
            txturunid.TabIndex = 2;
            // 
            // btnguncel
            // 
            btnguncel.Location = new Point(513, 111);
            btnguncel.Name = "btnguncel";
            btnguncel.Size = new Size(75, 23);
            btnguncel.TabIndex = 1;
            btnguncel.Text = "Güncelle";
            btnguncel.UseVisualStyleBackColor = true;
            // 
            // btnbul
            // 
            btnbul.Location = new Point(513, 82);
            btnbul.Name = "btnbul";
            btnbul.Size = new Size(75, 23);
            btnbul.TabIndex = 1;
            btnbul.Text = "Bul";
            btnbul.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(393, 45);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(224, 23);
            btnsil.TabIndex = 1;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(393, 13);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(224, 23);
            btnkaydet.TabIndex = 1;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(862, 502);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 679);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Kuzey Yeli VT";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupbirimfiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txturunad;
        private TextBox txturunid;
        private Button btnkaydet;
        private DataGridView dataGridView1;
        private NumericUpDown nupbirimfiyat;
        private ComboBox cmbtedarik;
        private Label label5;
        private Label label4;
        private ComboBox cmbkategori;
        private Label label3;
        private Button btnguncel;
        private Button btnbul;
        private Button btnsil;
    }
}