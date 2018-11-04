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
    public partial class ApartmanBilgileri : Form
    {

        

        SqlConnection connection = new SqlConnection("          DATA BASE LOCATION           ");

        public ApartmanBilgileri()
        {
            InitializeComponent();
            ApartmanSatilikKiralik.SelectedIndex = 0;
            Apartmanaratmetrekare.Enabled = false;
            Apartmanaratucret.Enabled = false;
            ApartmanaratAd.Enabled = false;
            ApartmanaratSoyad.Enabled = false;
        }
       
        private void ApartmankaydetButonu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ApartmanMkare.Text) <= 0)
                    ApartmanMkare.Text = "";
                if (Convert.ToInt32(ApartmanUcret.Text) <= 0)
                    ApartmanUcret.Text = "";
                
                SqlCommand command = new SqlCommand("INSERT INTO EstateInfo(HomeType,SquareMeter,Name,Surname,PhoneNumber,RentSale,Price,LivingRooms,Rooms,Balconies,ApartmentsCount,DeletionNumber) VALUES (@HomeType,@SquareMeter,@Name,@Surname,@PhoneNumber,@RentSale,@Price,@LivingRooms,@Rooms,@Balconies,@ApartmentsCount,@DeletionNumber)", connection);

                // HomeType,SquareMeter,Name,Surname,PhoneNumber,RentSale,Price,LivingRooms,Rooms,Balconies,Floors,Bathroom,ApartmentsCount,DeletionNumber

                command.Parameters.AddWithValue("@HomeType", "Building");
                command.Parameters.AddWithValue("@SquareMeter", Convert.ToInt32(ApartmanMkare.Text));
                command.Parameters.AddWithValue("@Name", ApartmanAd.Text);
                command.Parameters.AddWithValue("@Surname", ApartmanSoyad.Text);
                command.Parameters.AddWithValue("@PhoneNumber", Convert.ToInt32(ApartmanTel.Text));
                command.Parameters.AddWithValue("@RentSale", ApartmanSatilikKiralik.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(ApartmanUcret.Text));
                command.Parameters.AddWithValue("@LivingRooms", Convert.ToInt32(ApartmanSalonSayisi.Text));
                command.Parameters.AddWithValue("@Rooms", Convert.ToInt32(ApartmanOdaSayisi.Text));
                command.Parameters.AddWithValue("@Balconies", Convert.ToInt32(ApartmanBalkonSayisi.Text));
                command.Parameters.AddWithValue("@ApartmentsCount", ApartmanDaireSayisi.Text);
                command.Parameters.AddWithValue("@DeletionNumber",DeletionID.deletion);

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

        private void ApartmanAratmaSecenegi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ApartmanAratmaSecenegi.SelectedIndex == 0)
            {
                Apartmanaratmetrekare.Enabled = true;
                Apartmanaratucret.Enabled = true;
                ApartmanaratAd.Enabled = false;
                ApartmanaratSoyad.Enabled = false;
            }
            else if (ApartmanAratmaSecenegi.SelectedIndex == 1)
            {
                ApartmanaratAd.Enabled = true;
                ApartmanaratSoyad.Enabled = true;
                Apartmanaratmetrekare.Enabled = false;
                Apartmanaratucret.Enabled = false;
            }
        }

        private void ApartmangeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 c = new Form1();
            c.Show();
        }

        private void ApartmanlisteleButonu_Click(object sender, EventArgs e)
        {       
            if (ApartmanAratmaSecenegi.SelectedIndex == 0)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EstateInfo WHERE SquareMeter <= @squaremeter  AND Price <= @price AND HomeType = @hometype  ", connection);

                command.Parameters.AddWithValue("@squaremeter", Convert.ToInt32(Apartmanaratmetrekare.Text));
                command.Parameters.AddWithValue("@hometype", "Building");
                command.Parameters.AddWithValue("@price", Convert.ToInt32(Apartmanaratucret.Text));
                
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                Apartmantablo.DataSource = table;               
            }        
            else if (ApartmanAratmaSecenegi.SelectedIndex == 1)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EstateInfo WHERE Name = @name  AND Surname = @surname AND HomeType = @hometype " , connection);

                command.Parameters.AddWithValue("@name", ApartmanaratAd.Text);
                command.Parameters.AddWithValue("@hometype", "Building");
                command.Parameters.AddWithValue("@surname",ApartmanaratSoyad.Text);
                
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                Apartmantablo.DataSource = table;
            }           
        }
        private void ApartmansilButonu_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM EstateInfo WHERE DeletionNumber = @deletionnumber AND HomeType = @delhometype", connection);
            command.Parameters.AddWithValue("@deletionnumber", Convert.ToInt32(ApartmanKayitSil.Text));
            command.Parameters.AddWithValue("@delhometype", deleteHometype.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();          
        }
        }
}

