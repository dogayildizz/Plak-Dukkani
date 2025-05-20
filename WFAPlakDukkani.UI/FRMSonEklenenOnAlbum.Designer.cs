namespace WFAPlakDukkani.UI
{
    partial class FRMSonEklenenOnAlbum
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
            dgvSonEklenenOnAlbum = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSonEklenenOnAlbum).BeginInit();
            SuspendLayout();
            // 
            // dgvSonEklenenOnAlbum
            // 
            dgvSonEklenenOnAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonEklenenOnAlbum.Location = new Point(13, 12);
            dgvSonEklenenOnAlbum.Margin = new Padding(4, 3, 4, 3);
            dgvSonEklenenOnAlbum.Name = "dgvSonEklenenOnAlbum";
            dgvSonEklenenOnAlbum.ReadOnly = true;
            dgvSonEklenenOnAlbum.RowHeadersWidth = 51;
            dgvSonEklenenOnAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSonEklenenOnAlbum.Size = new Size(914, 649);
            dgvSonEklenenOnAlbum.TabIndex = 0;
            // 
            // FRMSonEklenenOnAlbum
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 673);
            Controls.Add(dgvSonEklenenOnAlbum);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FRMSonEklenenOnAlbum";
            Text = "FRMSonEklenenOnAlbum";
            Load += FRMSonEklenenOnAlbum_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSonEklenenOnAlbum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSonEklenenOnAlbum;
    }
}