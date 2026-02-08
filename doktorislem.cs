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
using static HASTANERANDEVUPROGRAMI.session2;
using static HASTANERANDEVUPROGRAMI.Sesssion;

namespace HASTANERANDEVUPROGRAMI
{
    public partial class doktorislem : Form
    {
        
        public doktorislem()
        {
            InitializeComponent();
        }

        private void doktorislem_Load(object sender, EventArgs e)
        {
            txtDoktorID.Text = session2.DoktorID.ToString();
            LoadDoktorHastalar();
        }

        private void LoadDoktorHastalar()
        {
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=HastaneRandevuSistemi;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();

                    
                    string query = @"
                SELECT 
                    Randevular.RandevuID AS [Randevu No],
                    Hastalar.HastaID AS [Hasta ID],
                    Hastalar.Ad AS [Hasta Adı],
                    Hastalar.Soyad AS [Hasta Soyadı],
                    Randevular.RandevuTarihi AS [Randevu Tarihi]
                FROM Randevular
                INNER JOIN Hastalar ON Randevular.HastaID = Hastalar.HastaID
                WHERE Randevular.DoktorID = @doktorID";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@doktorID", session2.DoktorID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                   
                    dvgRandevular.DataSource = dataTable;
                    dvgRandevular.AutoGenerateColumns = true;

                    
                    dvgRandevular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dvgRandevular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dvgRandevular.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int hastaID = Convert.ToInt32(txtHastaID.Text);
            int doktorID = Convert.ToInt32(txtDoktorID.Text);
            string tetkikAciklama = rtbTetkikAciklama.Text;
            DateTime tetkikTarihi = dtpTetkikTarihi.Value;

            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=HastaneRandevuSistemi;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();

                    
                    string insertTetkikQuery = @"
                INSERT INTO Tetkikler (TetkikAdi, TetkikAciklama, TetkikTarihi, HastaID, DoktorID)
                VALUES ('Tetkik', @tetkikAciklama, @tetkikTarihi, @hastaID, @doktorID);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdTetkik = new SqlCommand(insertTetkikQuery, connection);
                    cmdTetkik.Parameters.AddWithValue("@tetkikAciklama", tetkikAciklama);
                    cmdTetkik.Parameters.AddWithValue("@tetkikTarihi", tetkikTarihi);
                    cmdTetkik.Parameters.AddWithValue("@hastaID", hastaID);
                    cmdTetkik.Parameters.AddWithValue("@doktorID", doktorID);

                   
                    int tetkikID = Convert.ToInt32(cmdTetkik.ExecuteScalar());

                    
                    txtTetkikID.Text = tetkikID.ToString();

                    MessageBox.Show("Tetkik başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHastaID.Text) || dtpTetkikTarihi.Value == null || string.IsNullOrEmpty(rtbTetkikAciklama.Text) || clbTetkikAdi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int hastaID = Convert.ToInt32(txtHastaID.Text);
            int doktorID = Convert.ToInt32(txtDoktorID.Text);
            string tetkikAdi = clbTetkikAdi.SelectedItem.ToString();
            string tetkikAciklama = rtbTetkikAciklama.Text;
            DateTime tetkikTarihi = dtpTetkikTarihi.Value;

            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=HastaneRandevuSistemi;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Tetkikler (TetkikAdi, TetkikAciklama, TetkikTarihi, HastaID, DoktorID)
                VALUES (@tetkikAdi, @tetkikAciklama, @tetkikTarihi, @hastaID, @doktorID)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tetkikAdi", tetkikAdi);
                    cmd.Parameters.AddWithValue("@tetkikAciklama", tetkikAciklama);
                    cmd.Parameters.AddWithValue("@tetkikTarihi", tetkikTarihi);
                    cmd.Parameters.AddWithValue("@hastaID", hastaID);
                    cmd.Parameters.AddWithValue("@doktorID", doktorID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tetkik bilgileri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tetkik bilgileri kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTetkikSonucKaydet_Click(object sender, EventArgs e)
        {
            int tetkikID = Convert.ToInt32(txtTetkikID.Text);
            string tetkikSonuc = clbTetkikSonuc.SelectedItem.ToString();
            DateTime sonucTarihi = DateTime.Now;

            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=HastaneRandevuSistemi;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();

                    
                    string insertTetkikSonucQuery = @"
                INSERT INTO TetkikSonuclari (TetkikID, Sonuc, SonucTarihi)
                VALUES (@tetkikID, @sonuc, @sonucTarihi)";

                    SqlCommand cmdSonuc = new SqlCommand(insertTetkikSonucQuery, connection);
                    cmdSonuc.Parameters.AddWithValue("@tetkikID", tetkikID);
                    cmdSonuc.Parameters.AddWithValue("@sonuc", tetkikSonuc);
                    cmdSonuc.Parameters.AddWithValue("@sonucTarihi", sonucTarihi);

                    int rowsAffected = cmdSonuc.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tetkik sonucu başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tetkik sonucu kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dvgRandevular_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgRandevular.CurrentRow != null)
            {
              
                txtHastaID.Text = dvgRandevular.CurrentRow.Cells["Hasta ID"].Value.ToString();
            }
        }
    }
    
}
