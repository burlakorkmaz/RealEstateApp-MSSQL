namespace RealEstate
{
    partial class ArsaBilgileri
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
            this.components = new System.ComponentModel.Container();
            this.ArsaMkare = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArsaAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArsaSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ArsaTel = new System.Windows.Forms.TextBox();
            this.kaydetButonu = new System.Windows.Forms.Button();
            this.ArsalisteleButonu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ArsaUcret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ArsaSatilikKiralik = new System.Windows.Forms.ComboBox();
            this.silButonu = new System.Windows.Forms.Button();
            this.geriDön = new System.Windows.Forms.Button();
            this.tablo = new System.Windows.Forms.DataGridView();
            this.aratmetrekare = new System.Windows.Forms.TextBox();
            this.aratucret = new System.Windows.Forms.TextBox();
            this.AratmaSecenegi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aratAd = new System.Windows.Forms.TextBox();
            this.aratSoyad = new System.Windows.Forms.TextBox();
            this.ArsaKayitSil = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteHomeTypeArsa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ArsaMkare
            // 
            this.ArsaMkare.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArsaMkare.Location = new System.Drawing.Point(171, 18);
            this.ArsaMkare.Multiline = true;
            this.ArsaMkare.Name = "ArsaMkare";
            this.ArsaMkare.Size = new System.Drawing.Size(137, 31);
            this.ArsaMkare.TabIndex = 0;
            this.ArsaMkare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Square Meter : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ArsaAd
            // 
            this.ArsaAd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArsaAd.Location = new System.Drawing.Point(171, 73);
            this.ArsaAd.Multiline = true;
            this.ArsaAd.Name = "ArsaAd";
            this.ArsaAd.Size = new System.Drawing.Size(137, 31);
            this.ArsaAd.TabIndex = 3;
            this.ArsaAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname :";
            // 
            // ArsaSoyad
            // 
            this.ArsaSoyad.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArsaSoyad.Location = new System.Drawing.Point(171, 130);
            this.ArsaSoyad.Multiline = true;
            this.ArsaSoyad.Name = "ArsaSoyad";
            this.ArsaSoyad.Size = new System.Drawing.Size(137, 31);
            this.ArsaSoyad.TabIndex = 5;
            this.ArsaSoyad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number :";
            // 
            // ArsaTel
            // 
            this.ArsaTel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArsaTel.Location = new System.Drawing.Point(171, 184);
            this.ArsaTel.Multiline = true;
            this.ArsaTel.Name = "ArsaTel";
            this.ArsaTel.Size = new System.Drawing.Size(137, 31);
            this.ArsaTel.TabIndex = 7;
            // 
            // kaydetButonu
            // 
            this.kaydetButonu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButonu.Location = new System.Drawing.Point(12, 462);
            this.kaydetButonu.Name = "kaydetButonu";
            this.kaydetButonu.Size = new System.Drawing.Size(137, 78);
            this.kaydetButonu.TabIndex = 9;
            this.kaydetButonu.Text = "ADD";
            this.kaydetButonu.UseVisualStyleBackColor = true;
            this.kaydetButonu.Click += new System.EventHandler(this.kaydetButonu_Click);
            // 
            // ArsalisteleButonu
            // 
            this.ArsalisteleButonu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArsalisteleButonu.Location = new System.Drawing.Point(350, 18);
            this.ArsalisteleButonu.Name = "ArsalisteleButonu";
            this.ArsalisteleButonu.Size = new System.Drawing.Size(137, 31);
            this.ArsalisteleButonu.TabIndex = 10;
            this.ArsalisteleButonu.Text = "LIST";
            this.ArsalisteleButonu.UseVisualStyleBackColor = true;
            this.ArsalisteleButonu.Click += new System.EventHandler(this.listeleButonu_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price :";
            // 
            // ArsaUcret
            // 
            this.ArsaUcret.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArsaUcret.Location = new System.Drawing.Point(171, 331);
            this.ArsaUcret.Multiline = true;
            this.ArsaUcret.Name = "ArsaUcret";
            this.ArsaUcret.Size = new System.Drawing.Size(137, 31);
            this.ArsaUcret.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "For Rent / For Sale :";
            // 
            // ArsaSatilikKiralik
            // 
            this.ArsaSatilikKiralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArsaSatilikKiralik.FormattingEnabled = true;
            this.ArsaSatilikKiralik.Items.AddRange(new object[] {
            "For Rent",
            "For Sale"});
            this.ArsaSatilikKiralik.Location = new System.Drawing.Point(171, 239);
            this.ArsaSatilikKiralik.Name = "ArsaSatilikKiralik";
            this.ArsaSatilikKiralik.Size = new System.Drawing.Size(137, 28);
            this.ArsaSatilikKiralik.TabIndex = 14;
            this.ArsaSatilikKiralik.Text = "Choose";
            this.ArsaSatilikKiralik.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // silButonu
            // 
            this.silButonu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButonu.Location = new System.Drawing.Point(411, 462);
            this.silButonu.Name = "silButonu";
            this.silButonu.Size = new System.Drawing.Size(137, 78);
            this.silButonu.TabIndex = 16;
            this.silButonu.Text = "Delete registration";
            this.silButonu.UseVisualStyleBackColor = true;
            this.silButonu.Click += new System.EventHandler(this.silButonu_Click);
            // 
            // geriDön
            // 
            this.geriDön.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.geriDön.Location = new System.Drawing.Point(171, 462);
            this.geriDön.Name = "geriDön";
            this.geriDön.Size = new System.Drawing.Size(137, 78);
            this.geriDön.TabIndex = 18;
            this.geriDön.Text = "BACK";
            this.geriDön.UseVisualStyleBackColor = true;
            this.geriDön.Click += new System.EventHandler(this.geriDön_Click);
            // 
            // tablo
            // 
            this.tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo.Location = new System.Drawing.Point(350, 151);
            this.tablo.Name = "tablo";
            this.tablo.Size = new System.Drawing.Size(764, 211);
            this.tablo.TabIndex = 19;
            this.tablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablo_CellContentClick);
            // 
            // aratmetrekare
            // 
            this.aratmetrekare.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aratmetrekare.Location = new System.Drawing.Point(691, 16);
            this.aratmetrekare.Multiline = true;
            this.aratmetrekare.Name = "aratmetrekare";
            this.aratmetrekare.Size = new System.Drawing.Size(137, 31);
            this.aratmetrekare.TabIndex = 20;
            this.aratmetrekare.TextChanged += new System.EventHandler(this.aratmetrekare_TextChanged);
            // 
            // aratucret
            // 
            this.aratucret.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aratucret.Location = new System.Drawing.Point(691, 58);
            this.aratucret.Multiline = true;
            this.aratucret.Name = "aratucret";
            this.aratucret.Size = new System.Drawing.Size(137, 31);
            this.aratucret.TabIndex = 21;
            // 
            // AratmaSecenegi
            // 
            this.AratmaSecenegi.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AratmaSecenegi.FormattingEnabled = true;
            this.AratmaSecenegi.Items.AddRange(new object[] {
            "Square Meter and Price",
            "Name and Surname"});
            this.AratmaSecenegi.Location = new System.Drawing.Point(350, 62);
            this.AratmaSecenegi.Name = "AratmaSecenegi";
            this.AratmaSecenegi.Size = new System.Drawing.Size(173, 31);
            this.AratmaSecenegi.TabIndex = 22;
            this.AratmaSecenegi.Text = "Search Type";
            this.AratmaSecenegi.SelectedIndexChanged += new System.EventHandler(this.AratmaSecenegi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(548, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Square Meter : ";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(548, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 31);
            this.label8.TabIndex = 24;
            this.label8.Text = "Price : ";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(834, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 31);
            this.label9.TabIndex = 25;
            this.label9.Text = "Name :";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(834, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 31);
            this.label10.TabIndex = 26;
            this.label10.Text = "Surname :";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // aratAd
            // 
            this.aratAd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aratAd.Location = new System.Drawing.Point(977, 14);
            this.aratAd.Multiline = true;
            this.aratAd.Name = "aratAd";
            this.aratAd.Size = new System.Drawing.Size(137, 31);
            this.aratAd.TabIndex = 28;
            // 
            // aratSoyad
            // 
            this.aratSoyad.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aratSoyad.Location = new System.Drawing.Point(977, 58);
            this.aratSoyad.Multiline = true;
            this.aratSoyad.Name = "aratSoyad";
            this.aratSoyad.Size = new System.Drawing.Size(137, 31);
            this.aratSoyad.TabIndex = 29;
            // 
            // ArsaKayitSil
            // 
            this.ArsaKayitSil.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArsaKayitSil.Location = new System.Drawing.Point(563, 509);
            this.ArsaKayitSil.Multiline = true;
            this.ArsaKayitSil.Name = "ArsaKayitSil";
            this.ArsaKayitSil.Size = new System.Drawing.Size(137, 31);
            this.ArsaKayitSil.TabIndex = 30;
            this.ArsaKayitSil.TextChanged += new System.EventHandler(this.ArsaKayitSil_TextChanged);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(563, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 31);
            this.label11.TabIndex = 31;
            this.label11.Text = "Deletion number :";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(728, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 31);
            this.label12.TabIndex = 32;
            this.label12.Text = "Home Type :";
            // 
            // deleteHomeTypeArsa
            // 
            this.deleteHomeTypeArsa.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteHomeTypeArsa.Location = new System.Drawing.Point(728, 509);
            this.deleteHomeTypeArsa.Multiline = true;
            this.deleteHomeTypeArsa.Name = "deleteHomeTypeArsa";
            this.deleteHomeTypeArsa.Size = new System.Drawing.Size(137, 31);
            this.deleteHomeTypeArsa.TabIndex = 33;
            // 
            // ArsaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 584);
            this.Controls.Add(this.deleteHomeTypeArsa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ArsaKayitSil);
            this.Controls.Add(this.aratSoyad);
            this.Controls.Add(this.aratAd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AratmaSecenegi);
            this.Controls.Add(this.aratucret);
            this.Controls.Add(this.aratmetrekare);
            this.Controls.Add(this.tablo);
            this.Controls.Add(this.geriDön);
            this.Controls.Add(this.silButonu);
            this.Controls.Add(this.ArsaSatilikKiralik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ArsaUcret);
            this.Controls.Add(this.ArsalisteleButonu);
            this.Controls.Add(this.kaydetButonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArsaTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArsaSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArsaAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArsaMkare);
            this.Name = "ArsaBilgileri";
            this.Text = "ArsaBilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArsaMkare;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArsaAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArsaSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ArsaTel;
        private System.Windows.Forms.Button kaydetButonu;
        private System.Windows.Forms.Button ArsalisteleButonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ArsaUcret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ArsaSatilikKiralik;
        private System.Windows.Forms.Button silButonu;
        private System.Windows.Forms.Button geriDön;
        private System.Windows.Forms.DataGridView tablo;
        private System.Windows.Forms.TextBox aratmetrekare;
        private System.Windows.Forms.TextBox aratucret;
        private System.Windows.Forms.ComboBox AratmaSecenegi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox aratAd;
        private System.Windows.Forms.TextBox aratSoyad;
        private System.Windows.Forms.TextBox ArsaKayitSil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox deleteHomeTypeArsa;
    }
}