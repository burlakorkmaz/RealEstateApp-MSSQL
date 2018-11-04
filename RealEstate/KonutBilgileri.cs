using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace RealEstate
{
    public partial class KonutBilgileri : Form
    {

        SqlConnection connection = new SqlConnection("          DATA BASE LOCATION           ");

        public KonutBilgileri()
        {

           

            InitializeComponent();

            KonutSatilikKiralik.SelectedIndex = 0;
            Konutaratmetrekare.Enabled = false;
            Konutaratucret.Enabled = false;
            KonutaratAd.Enabled = false;
            KonutaratSoyad.Enabled = false;
        }
      
        private void KonutkaydetButonu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(KonutMkare.Text) <= 0)
                    KonutMkare.Text = "";
                if (Convert.ToInt32(KonutUcret.Text) <= 0)
                    KonutUcret.Text = "";
   

                SqlCommand command = new SqlCommand("INSERT INTO EstateInfo(HomeType,SquareMeter,Name,Surname,PhoneNumber,RentSale,Price,LivingRooms,Rooms,Balconies,Floors,DeletionNumber) VALUES (@HomeType,@SquareMeter,@Name,@Surname,@PhoneNumber,@RentSale,@Price,@LivingRooms,@Rooms,@Balconies,@Floors,@DeletionNumber)", connection);

                // HomeType,SquareMeter,Name,Surname,PhoneNumber,RentSale,Price,LivingRooms,Rooms,Balconies,Floors,Bathroom,ApartmentsCount,DeletionNumber

                command.Parameters.AddWithValue("@HomeType", "House");
                command.Parameters.AddWithValue("@SquareMeter", Convert.ToInt32(KonutMkare.Text));
                command.Parameters.AddWithValue("@Name", KonutAd.Text);
                command.Parameters.AddWithValue("@Surname", KonutSoyad.Text);
                command.Parameters.AddWithValue("@PhoneNumber", Convert.ToInt32(KonutTel.Text));
                command.Parameters.AddWithValue("@RentSale", KonutSatilikKiralik.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(KonutUcret.Text));
                command.Parameters.AddWithValue("@LivingRooms", Convert.ToInt32(KonutSalonSayisi.Text));
                command.Parameters.AddWithValue("@Rooms", Convert.ToInt32(KonutOdaSayisi.Text));
                command.Parameters.AddWithValue("@Balconies", Convert.ToInt32(KonutBalkonSayisi.Text));
                command.Parameters.AddWithValue("@Floors", KonutKatSayisi.Text);
                command.Parameters.AddWithValue("@DeletionNumber", DeletionID.deletion);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                DeletionID.deletion++;   // deletion number


                MessageBox.Show("Added.");
            }
            catch
            {
                MessageBox.Show("Please check your values!");
            }

        }

        private void KonutlisteleButonu_Click(object sender, EventArgs e)
        {
            
            if (KonutAratmaSecenegi.SelectedIndex == 0)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EstateInfo WHERE SquareMeter <= @squaremeter  AND Price <= @price AND HomeType = @hometype ", connection);

                command.Parameters.AddWithValue("@squaremeter", Convert.ToInt32(Konutaratmetrekare.Text));
                command.Parameters.AddWithValue("@hometype", "House");
                command.Parameters.AddWithValue("@price", Convert.ToInt32(Konutaratucret.Text));
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                Konuttablo.DataSource = table;
            }
            else if (KonutAratmaSecenegi.SelectedIndex == 1)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EstateInfo WHERE Name = @name  AND Surname = @surname AND HomeType = @hometype ", connection);

                command.Parameters.AddWithValue("@name", KonutaratAd.Text);
                command.Parameters.AddWithValue("@hometype", "House");
                command.Parameters.AddWithValue("@surname", KonutaratSoyad.Text);
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                Konuttablo.DataSource = table;
            }
        }

        private void KonutAratmaSecenegi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KonutAratmaSecenegi.SelectedIndex == 0)
            {
                Konutaratmetrekare.Enabled = true;
                Konutaratucret.Enabled = true;
                KonutaratAd.Enabled = false;
                KonutaratSoyad.Enabled = false;
            }
            else if (KonutAratmaSecenegi.SelectedIndex == 1)
            {
                KonutaratAd.Enabled = true;
                KonutaratSoyad.Enabled = true;
                Konutaratmetrekare.Enabled = false;
                Konutaratucret.Enabled = false;
            }
        }

        private void KonutgeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 c = new Form1();
            c.Show();
        }

        private void KonutsilButonu_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM EstateInfo WHERE DeletionNumber = @deletionnumber AND HomeType = @delhometype", connection);
            command.Parameters.AddWithValue("@deletionnumber", Convert.ToInt32(KonutKayitSil.Text));
            command.Parameters.AddWithValue("@delhometype", deleteHometypeKonut.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
