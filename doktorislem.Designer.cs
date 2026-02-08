namespace HASTANERANDEVUPROGRAMI
{
    partial class doktorislem
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
            this.dvgRandevular = new System.Windows.Forms.DataGridView();
            this.txtHastaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbTetkikAdi = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbTetkikAciklama = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTetkikSonucKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoktorID = new System.Windows.Forms.TextBox();
            this.dtpTetkikTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.clbTetkikSonuc = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtTetkikID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(426, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastalar";
            // 
            // dvgRandevular
            // 
            this.dvgRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRandevular.Location = new System.Drawing.Point(429, 48);
            this.dvgRandevular.Name = "dvgRandevular";
            this.dvgRandevular.Size = new System.Drawing.Size(359, 390);
            this.dvgRandevular.TabIndex = 1;
            this.dvgRandevular.SelectionChanged += new System.EventHandler(this.dvgRandevular_SelectionChanged);
            // 
            // txtHastaID
            // 
            this.txtHastaID.Location = new System.Drawing.Point(266, 11);
            this.txtHastaID.Name = "txtHastaID";
            this.txtHastaID.ReadOnly = true;
            this.txtHastaID.Size = new System.Drawing.Size(100, 20);
            this.txtHastaID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(192, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "HastaID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tetkik Adı";
            // 
            // clbTetkikAdi
            // 
            this.clbTetkikAdi.BackColor = System.Drawing.SystemColors.Window;
            this.clbTetkikAdi.FormattingEnabled = true;
            this.clbTetkikAdi.Items.AddRange(new object[] {
            "MR",
            "Röntgen",
            "Kan Testi"});
            this.clbTetkikAdi.Location = new System.Drawing.Point(15, 227);
            this.clbTetkikAdi.Name = "clbTetkikAdi";
            this.clbTetkikAdi.Size = new System.Drawing.Size(120, 49);
            this.clbTetkikAdi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tetkik Açıklama";
            // 
            // rtbTetkikAciklama
            // 
            this.rtbTetkikAciklama.Location = new System.Drawing.Point(15, 152);
            this.rtbTetkikAciklama.Name = "rtbTetkikAciklama";
            this.rtbTetkikAciklama.Size = new System.Drawing.Size(201, 51);
            this.rtbTetkikAciklama.TabIndex = 4;
            this.rtbTetkikAciklama.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(16, 282);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 35);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTetkikSonucKaydet
            // 
            this.btnTetkikSonucKaydet.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnTetkikSonucKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTetkikSonucKaydet.Location = new System.Drawing.Point(237, 282);
            this.btnTetkikSonucKaydet.Name = "btnTetkikSonucKaydet";
            this.btnTetkikSonucKaydet.Size = new System.Drawing.Size(120, 48);
            this.btnTetkikSonucKaydet.TabIndex = 5;
            this.btnTetkikSonucKaydet.Text = "Tetkik Sonuç Kaydet";
            this.btnTetkikSonucKaydet.UseVisualStyleBackColor = false;
            this.btnTetkikSonucKaydet.Click += new System.EventHandler(this.btnTetkikSonucKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "DoktorID";
            // 
            // txtDoktorID
            // 
            this.txtDoktorID.Location = new System.Drawing.Point(86, 10);
            this.txtDoktorID.Name = "txtDoktorID";
            this.txtDoktorID.ReadOnly = true;
            this.txtDoktorID.Size = new System.Drawing.Size(100, 20);
            this.txtDoktorID.TabIndex = 2;
            this.txtDoktorID.WordWrap = false;
            // 
            // dtpTetkikTarihi
            // 
            this.dtpTetkikTarihi.Location = new System.Drawing.Point(16, 98);
            this.dtpTetkikTarihi.Name = "dtpTetkikTarihi";
            this.dtpTetkikTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpTetkikTarihi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tetkik Tarihi";
            // 
            // clbTetkikSonuc
            // 
            this.clbTetkikSonuc.FormattingEnabled = true;
            this.clbTetkikSonuc.Items.AddRange(new object[] {
            "Normal",
            "Anormal",
            "Takip Gerekli"});
            this.clbTetkikSonuc.Location = new System.Drawing.Point(237, 227);
            this.clbTetkikSonuc.Name = "clbTetkikSonuc";
            this.clbTetkikSonuc.Size = new System.Drawing.Size(120, 49);
            this.clbTetkikSonuc.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(234, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tetkik Sonuç";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(16, 323);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 35);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtTetkikID
            // 
            this.txtTetkikID.Location = new System.Drawing.Point(794, 64);
            this.txtTetkikID.Name = "txtTetkikID";
            this.txtTetkikID.ReadOnly = true;
            this.txtTetkikID.Size = new System.Drawing.Size(10, 20);
            this.txtTetkikID.TabIndex = 7;
            this.txtTetkikID.Visible = false;
            // 
            // doktorislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTetkikID);
            this.Controls.Add(this.dtpTetkikTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTetkikSonucKaydet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rtbTetkikAciklama);
            this.Controls.Add(this.clbTetkikSonuc);
            this.Controls.Add(this.clbTetkikAdi);
            this.Controls.Add(this.txtDoktorID);
            this.Controls.Add(this.txtHastaID);
            this.Controls.Add(this.dvgRandevular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "doktorislem";
            this.Text = "doktorislem";
            this.Load += new System.EventHandler(this.doktorislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRandevular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgRandevular;
        private System.Windows.Forms.TextBox txtHastaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbTetkikAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbTetkikAciklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTetkikSonucKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoktorID;
        private System.Windows.Forms.DateTimePicker dtpTetkikTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbTetkikSonuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTetkikID;
    }
}