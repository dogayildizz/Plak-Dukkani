namespace WFAPlakDukkani.UI
{
    partial class FRMSatisiDevamEdenAlbumler
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
            dgvSatisiDevamEdenAlbumler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSatisiDevamEdenAlbumler).BeginInit();
            SuspendLayout();
            // 
            // dgvSatisiDevamEdenAlbumler
            // 
            dgvSatisiDevamEdenAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatisiDevamEdenAlbumler.Location = new Point(12, 12);
            dgvSatisiDevamEdenAlbumler.Name = "dgvSatisiDevamEdenAlbumler";
            dgvSatisiDevamEdenAlbumler.ReadOnly = true;
            dgvSatisiDevamEdenAlbumler.RowHeadersWidth = 51;
            dgvSatisiDevamEdenAlbumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSatisiDevamEdenAlbumler.Size = new Size(916, 649);
            dgvSatisiDevamEdenAlbumler.TabIndex = 0;
            // 
            // FRMSatisiDevamEdenAlbumler
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 673);
            Controls.Add(dgvSatisiDevamEdenAlbumler);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FRMSatisiDevamEdenAlbumler";
            Text = "FRMSatisiDevamEdenAlbumler";
            Load += FRMSatisiDevamEdenAlbumler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSatisiDevamEdenAlbumler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSatisiDevamEdenAlbumler;
    }
}