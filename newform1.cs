using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HASTANERANDEVUPROGRAMI.Sesssion;
using static HASTANERANDEVUPROGRAMI.session2;

namespace HASTANERANDEVUPROGRAMI
{
    public partial class newform1 : Form
    {
        string connectionString = "Server=localhost;Database=HastaneRandevuSistemi;Integrated Security=True;";
        public newform1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string kulad = textBox1.Text;
            string sifre = textBox2.Text;

            if (string.IsNullOrEmpty(kulad) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş bırakılamaz");
                return;

            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Hastalar WHERE HastaID = @kulad AND TCKimlikNo = @sifre";
                    SqlCommand cmdHasta = new SqlCommand(query, connection);
                    cmdHasta.Parameters.AddWithValue("@kulad", kulad);
                    cmdHasta.Parameters.AddWithValue("@sifre", sifre);

                    SqlDataReader readerHasta = cmdHasta.ExecuteReader();


                    if (readerHasta.Read())
                    {
                        int HastaID = Convert.ToInt32(readerHasta["HastaID"]);
                        Session.HastaID = Convert.ToInt32(readerHasta["HastaID"]);
                        readerHasta.Close();

                        hastaislem hastaislem = new hastaislem(HastaID);
                        hastaislem.ShowDialog();
                        this.Hide();
                        return;
                    }
                    int _HastaID = Session.HastaID;
                    MessageBox.Show($"Giriş yapan HastaID: {_HastaID}");
                    readerHasta.Close();

                    string queryDoktor = "SELECT * FROM Doktorlar WHERE DoktorID = @kulad AND TelefonNO = @sifre";
                    SqlCommand doktor = new SqlCommand(queryDoktor, connection);
                    doktor.Parameters.AddWithValue("@kulad", kulad);
                    doktor.Parameters.AddWithValue("@sifre", sifre);


                    SqlDataReader readerdoktor = doktor.ExecuteReader();
                    if (readerdoktor.Read())
                    {
                        int DoktorID = Convert.ToInt32(readerdoktor["DoktorID"]);
                        session2.DoktorID = Convert.ToInt32(readerdoktor["DoktorID"]);

                        
                        MessageBox.Show($"Giriş yapan DoktorID: {DoktorID}");

                        readerdoktor.Close();
                        doktorislem doktorislem = new doktorislem();
                        doktorislem.ShowDialog();
                        this.Hide();
                        return;
                    }
                    
                   

                    else
                    {
                        MessageBox.Show("Geçersiz giriş bilgileri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bağlantı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
