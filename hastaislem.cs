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

namespace HASTANERANDEVUPROGRAMI
{
    public partial class hastaislem : Form
    {
        private int _HastaID;
        public hastaislem(int HastaID)
        {
            _HastaID=HastaID;
            InitializeComponent();
            LoadBranslar();
            LoadTetkikSonuclari();
        }

        private void LoadBranslar() 
        {
            ComboBox cmbBrans = (ComboBox)this.Controls["cmbBrans"];
            cmbBrans.Items.Clear();

            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=HastaneRandevuSistemi;Trusted_Connection=True;"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT UzmanlikAlani FROM Doktorlar", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbBrans.Items.Add(reader["UzmanlikAlani"].ToString());
                }
            }

        }

        private void cmbBrans_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cmbBrans = (ComboBox)this.Controls["cmbBrans"];
            ComboBox cmbDoktor = (ComboBox)this.Controls["cmbDoktor"];
            cmbDoktor.Items.Clear();
            if (cmbBrans.SelectedItem == null) return;
            string selectedBrans = cmbBrans.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=HastaneRandevuSistemi;Trusted_Connection=True;"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DoktorID, Ad, Soyad FROM Doktorlar WHERE UzmanlikAlani = @brans", connection);
                cmd.Parameters.AddWithValue("@brans", selectedBrans);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbDoktor.Items.Add(new {Text = $"{reader["Ad"]} {reader["Soyad"]}", Value = reader["DoktorID"] });
                }
            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            ComboBox cmbDoktor = (ComboBox)this.Controls["cmbDoktor"];
            DateTimePicker dtpTarih = (DateTimePicker)this.Controls["dtpTarih"];



            if (cmbDoktor.SelectedItem == null || dtpTarih.Value == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            int _HastaID = Session.HastaID;

            
            var selectedDoktor = (dynamic)cmbDoktor.SelectedItem;
            int DoktorID = selectedDoktor.Value;
            DateTime Tarih = dtpTarih.Value;

           
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=HastaneRandevuSistemi;Integrated Security=True;"))
                {
                    connection.Open();
                    MessageBox.Show("Bağlantı başarılı!");

                    string query = "INSERT INTO Randevular (HastaID, DoktorID, RandevuTarihi,RandevuDurumu) VALUES (@hastaID, @doktorID, @tarih,'Bekliyor')";

                    using (SqlCommand cmdInsert = new SqlCommand(query, connection))
                    {
                        cmdInsert.Parameters.AddWithValue("@hastaID", _HastaID);
                        cmdInsert.Parameters.AddWithValue("@doktorID", DoktorID);
                        cmdInsert.Parameters.AddWithValue("@tarih", Tarih);

                        int rowsAffected = cmdInsert.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Randevu başarıyla alındı.");
                        }
                        else
                        {
                            MessageBox.Show("Randevu kaydedilemedi.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }


            
        }

        private void LoadTetkikSonuclari()
        {
            DataGridView dgvTetkikSonuclari = (DataGridView)this.Controls["dgvTetkikSonuclari"];

            
            dgvTetkikSonuclari.Rows.Clear();
            dgvTetkikSonuclari.Columns.Clear();

            
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=HastaneRandevuSistemi;Trusted_Connection=True;"))
            {
                connection.Open();

                
                string query = @"
            SELECT 
                ts.SonucID, 
                t.TetkikAdi, 
                ts.Sonuc, 
                ts.SonucTarihi 
            FROM 
                TetkikSonuclari ts 
             JOIN 
                Tetkikler t ON ts.TetkikID = t.TetkikID 
             JOIN 
                Hastalar h ON t.HastaID = h.HastaID 
            WHERE 
                h.HastaID = @hastaID";

                
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@hastaID", _HastaID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);  

                
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Tetkik Sonucu Yoktur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
                dgvTetkikSonuclari.DataSource = table;
            }





        }

        
    }
}
