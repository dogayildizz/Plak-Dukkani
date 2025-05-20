namespace WFAPlakDukkani.UI
{
    partial class FRMSatisiDurmusAlbumler
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
            dgvSatisiDurmusAlbumler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSatisiDurmusAlbumler).BeginInit();
            SuspendLayout();
            // 
            // dgvSatisiDurmusAlbumler
            // 
            dgvSatisiDurmusAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatisiDurmusAlbumler.Location = new Point(12, 12);
            dgvSatisiDurmusAlbumler.Name = "dgvSatisiDurmusAlbumler";
            dgvSatisiDurmusAlbumler.RowHeadersWidth = 51;
            dgvSatisiDurmusAlbumler.Size = new Size(916, 649);
            dgvSatisiDurmusAlbumler.TabIndex = 0;
            // 
            // FRMSatisiDurmusAlbumler
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 673);
            Controls.Add(dgvSatisiDurmusAlbumler);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FRMSatisiDurmusAlbumler";
            Text = "FRMSatisiDurmusAlbumler";
            Load += FRMSatisiDurmusAlbumler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSatisiDurmusAlbumler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSatisiDurmusAlbumler;
    }
}