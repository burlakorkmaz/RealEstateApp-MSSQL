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
    public partial class ArsaBilgileri : Form
    {


        SqlConnection connection = new SqlConnection("          DATA BASE LOCATION           ");


        public ArsaBilgileri()
        {
            InitializeComponent();
            

            ArsaSatilikKiralik.SelectedIndex = 0;
            aratmetrekare.Enabled = false;
            aratucret.Enabled = false;
            aratAd.Enabled = false;
            aratSoyad.Enabled = false;
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void kaydetButonu_Click(object sender, EventArgs e)
        {
                     
            try
            {
                if (Convert.ToInt32(ArsaMkare.Text) <= 0)
                    ArsaMkare.Text = "";
                if (Convert.ToInt32(ArsaUcret.Text) <= 0)
                    ArsaUcret.Text = "";

                SqlCommand command = new SqlCommand("INSERT INTO EstateInfo(HomeType,SquareMeter,Name,Surname,PhoneNumber,RentSale,Price,DeletionNumber) VALUES (@HomeType,@SquareMeter,@Name,@Surname,@PhoneNumber,@RentSale,@Price,@DeletionNumber)", connection);

                // HomeType,SquareMeter,Name,Surname,PhoneNumber,RentSale,Price,LivingRooms,Rooms,Balconies,Floors,Bathroom,ApartmentsCount,DeletionNumber

                command.Parameters.AddWithValue("@HomeType", "Land");
                command.Parameters.AddWithValue("@SquareMeter", Convert.ToInt32(ArsaMkare.Text));
                command.Parameters.AddWithValue("@Name", ArsaAd.Text);
                command.Parameters.AddWithValue("@Surname", ArsaSoyad.Text);
                command.Parameters.AddWithValue("@PhoneNumber", Convert.ToInt32(ArsaTel.Text));
                command.Parameters.AddWithValue("@RentSale", ArsaSatilikKiralik.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(ArsaUcret.Text));
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
       
        private void listeleButonu_Click(object sender, EventArgs e)
        {

           
            if (AratmaSecenegi.SelectedIndex == 0)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EstateInfo WHERE SquareMeter <= @squaremeter  AND Price <= @price AND HomeType = @hometype ", connection);

                command.Parameters.AddWithValue("@squaremeter", Convert.ToInt32(aratmetrekare.Text));
                command.Parameters.AddWithValue("@hometype", "Land");
                command.Parameters.AddWithValue("@price", Convert.ToInt32(aratucret.Text));
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                tablo.DataSource = table;

            }
            else if (AratmaSecenegi.SelectedIndex == 1)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EstateInfo WHERE Name = @name  AND Surname = @surname AND HomeType = @hometype ", connection);

                command.Parameters.AddWithValue("@name", aratAd.Text);
                command.Parameters.AddWithValue("@hometype", "Land");
                command.Parameters.AddWithValue("@surname", aratSoyad.Text);
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                tablo.DataSource = table;
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void aratmetrekare_TextChanged(object sender, EventArgs e)
        {        

        }

        private void AratmaSecenegi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AratmaSecenegi.SelectedIndex == 0)
            {
                aratmetrekare.Enabled = true;
                aratucret.Enabled = true;
                aratAd.Enabled = false;
                aratSoyad.Enabled = false;
            }
            else if (AratmaSecenegi.SelectedIndex == 1)
            {
                aratAd.Enabled = true;
                aratSoyad.Enabled = true;
                aratmetrekare.Enabled = false;
                aratucret.Enabled = false;
            }
        }

        private void geriDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b = new Form1();
            b.Show();
        }

        private void ArsaKayitSil_TextChanged(object sender, EventArgs e)
        {

        }

        private void silButonu_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM EstateInfo WHERE DeletionNumber = @deletionnumber AND HomeType = @delhometype", connection);
            command.Parameters.AddWithValue("@deletionnumber", Convert.ToInt32(ArsaKayitSil.Text));
            command.Parameters.AddWithValue("@delhometype", deleteHomeTypeArsa.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void tablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
