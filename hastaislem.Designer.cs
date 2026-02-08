namespace HASTANERANDEVUPROGRAMI
{
    partial class hastaislem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTetkikSonuclari = new System.Windows.Forms.DataGridView();
            this.hastaneRandevuSistemiDataSet = new HASTANERANDEVUPROGRAMI.HastaneRandevuSistemiDataSet();
            this.hastaneRandevuSistemiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTetkikSonuclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneRandevuSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneRandevuSistemiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş Seçiniz";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(151, 62);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(134, 21);
            this.cmbBrans.TabIndex = 1;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doktor Seçiniz";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(151, 106);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(134, 21);
            this.cmbDoktor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(85, 153);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 2;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAl.ForeColor = System.Drawing.Color.Red;
            this.btnRandevuAl.Location = new System.Drawing.Point(85, 258);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(151, 52);
            this.btnRandevuAl.TabIndex = 3;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(348, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tetkik Sonuçlarınız";
            // 
            // dgvTetkikSonuclari
            // 
            this.dgvTetkikSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTetkikSonuclari.Location = new System.Drawing.Point(351, 61);
            this.dgvTetkikSonuclari.Name = "dgvTetkikSonuclari";
            this.dgvTetkikSonuclari.Size = new System.Drawing.Size(437, 155);
            this.dgvTetkikSonuclari.TabIndex = 4;

            // hastaneRandevuSistemiDataSet
            // 
            this.hastaneRandevuSistemiDataSet.DataSetName = "HastaneRandevuSistemiDataSet";
            this.hastaneRandevuSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneRandevuSistemiDataSetBindingSource
            // 
            this.hastaneRandevuSistemiDataSetBindingSource.DataSource = this.hastaneRandevuSistemiDataSet;
            this.hastaneRandevuSistemiDataSetBindingSource.Position = 0;
            // 
            // hastaislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTetkikSonuclari);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label1);
            this.Name = "hastaislem";
            this.Text = "hastaislem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTetkikSonuclari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneRandevuSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneRandevuSistemiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTetkikSonuclari;
        private System.Windows.Forms.BindingSource hastaneRandevuSistemiDataSetBindingSource;
        private HastaneRandevuSistemiDataSet hastaneRandevuSistemiDataSet;
    }
}