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
    public partial class DaireBilgileri : Form
    {

        SqlConnection connection = new SqlConnection("          DATA BASE LOCATION           ");

        public DaireBilgileri()
        {
            InitializeComponent();

            DaireSatilikKiralik.SelectedIndex = 0;
            DaireBanyoVarYok.SelectedIndex = 0;
            Dairearatmetrekare.Enabled = false;
            Dairearatucret.Enabled = false;
            DairearatAd.Enabled = false;
            DairearatSoyad.Enabled = false;

        }
       

        private void DairekaydetButonu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(DaireMkare.Text) <= 0)
                    DaireMkare.Text = "";
                if (Convert.ToInt32(DaireUcret.Text) <= 0)
                    DaireUcret.Text = "";


                SqlCommand command = new SqlCommand("INSERT INTO EstateInfo(HomeType,SquareMeter,Name,Surname,PhoneNumber,RentSale,Price,LivingRooms,Rooms,Balconies,Bathroom,DeletionNumber) VALUES (@HomeType,@SquareMeter,@Name,@Surname,@PhoneNumber,@RentSale,@Price,@LivingRooms,@Rooms,@Balconies,@Bathroom,@DeletionNumber)", connection);

                // HomeType,SquareMeter,Name,Surname,PhoneNumber,RentSale,Price,LivingRooms,Rooms,Balconies,Floors,Bathroom,ApartmentsCount,DeletionNumber

                command.Parameters.AddWithValue("@HomeType", "Apartment");
                command.Parameters.AddWithValue("@SquareMeter", Convert.ToInt32(DaireMkare.Text));
                command.Parameters.AddWithValue("@Name", DaireAd.Text);
                command.Parameters.AddWithValue("@Surname", DaireSoyad.Text);
                command.Parameters.AddWithValue("@PhoneNumber", Convert.ToInt32(DaireTel.Text));
                command.Parameters.AddWithValue("@RentSale", DaireSatilikKiralik.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(DaireUcret.Text));
                command.Parameters.AddWithValue("@LivingRooms", Convert.ToInt32(DaireSalonSayisi.Text));
                command.Parameters.AddWithValue("@Rooms", Convert.ToInt32(DaireOdaSayisi.Text));
                command.Parameters.AddWithValue("@Balconies", Convert.ToInt32(DaireBalkonSayisi.Text));
                command.Parameters.AddWithValue("@Bathroom", DaireBanyoVarYok.Text);
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

        private void DairegeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 c = new Form1();
            c.Show();
        }

        private void DairelisteleButonu_Click(object sender, EventArgs e)
        {
           
            if (DaireAratmaSecenegi.SelectedIndex == 0)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EstateInfo WHERE SquareMeter <= @squaremeter  AND Price <= @price AND HomeType = @hometype ", connection);

                command.Parameters.AddWithValue("@squaremeter", Convert.ToInt32(Dairearatmetrekare.Text));
                command.Parameters.AddWithValue("@hometype", "Apartment");
                command.Parameters.AddWithValue("@price", Convert.ToInt32(Dairearatucret.Text));
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                Dairetablo.DataSource = table;
            }
            else if (DaireAratmaSecenegi.SelectedIndex == 1)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EstateInfo WHERE Name = @name  AND Surname = @surname AND HomeType = @hometype ", connection);

                command.Parameters.AddWithValue("@name", DairearatAd.Text);
                command.Parameters.AddWithValue("@hometype", "Apartment");
                command.Parameters.AddWithValue("@surname", DairearatSoyad.Text);
                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adap.Fill(table);
                Dairetablo.DataSource = table;
            }


        }

        private void Dairetablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DaireAratmaSecenegi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DaireAratmaSecenegi.SelectedIndex == 0)
            {
                Dairearatmetrekare.Enabled = true;
                Dairearatucret.Enabled = true;
                DairearatAd.Enabled = false;
                DairearatSoyad.Enabled = false;
            }
            else if (DaireAratmaSecenegi.SelectedIndex == 1)
            {
                DairearatAd.Enabled = true;
                DairearatSoyad.Enabled = true;
                Dairearatmetrekare.Enabled = false;
                Dairearatucret.Enabled = false;
            }
        }

        private void DairesilButonu_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM EstateInfo WHERE DeletionNumber = @deletionnumber AND HomeType = @delhometype", connection);
            command.Parameters.AddWithValue("@deletionnumber", Convert.ToInt32(DaireKayitSil.Text));
            command.Parameters.AddWithValue("@delhometype", deleteHometypeDaire.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DaireWcVarYok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
