namespace WFAPlakDukkani.UI
{
    partial class FRMSanatcilar
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
            label1 = new Label();
            txtSanatciAdi = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            dgvSanatcilar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSanatcilar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 1;
            label1.Text = "Sanatçı / Grup İsmi";
            // 
            // txtSanatciAdi
            // 
            txtSanatciAdi.Location = new Point(472, 154);
            txtSanatciAdi.Margin = new Padding(4, 3, 4, 3);
            txtSanatciAdi.Name = "txtSanatciAdi";
            txtSanatciAdi.Size = new Size(355, 32);
            txtSanatciAdi.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(585, 418);
            btnGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(141, 45);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(585, 357);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(141, 45);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(585, 295);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(141, 45);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvSanatcilar
            // 
            dgvSanatcilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanatcilar.Location = new Point(38, 46);
            dgvSanatcilar.Name = "dgvSanatcilar";
            dgvSanatcilar.ReadOnly = true;
            dgvSanatcilar.RowHeadersWidth = 51;
            dgvSanatcilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanatcilar.Size = new Size(310, 535);
            dgvSanatcilar.TabIndex = 4;
            dgvSanatcilar.CellClick += dgvSanatcilar_CellClick;
            // 
            // FRMSanatcilar
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 238, 220);
            ClientSize = new Size(940, 673);
            Controls.Add(dgvSanatcilar);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtSanatciAdi);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMSanatcilar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMSanatcilar";
            ((System.ComponentModel.ISupportInitialize)dgvSanatcilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtSanatciAdi;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dgvSanatcilar;
    }
}