namespace WFAPlakDukkani.UI
{
    partial class FRMIndirimdekiAlbumler
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
            dgvIndirimdekiAlbumler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIndirimdekiAlbumler).BeginInit();
            SuspendLayout();
            // 
            // dgvIndirimdekiAlbumler
            // 
            dgvIndirimdekiAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIndirimdekiAlbumler.Location = new Point(13, 12);
            dgvIndirimdekiAlbumler.Margin = new Padding(4, 3, 4, 3);
            dgvIndirimdekiAlbumler.Name = "dgvIndirimdekiAlbumler";
            dgvIndirimdekiAlbumler.ReadOnly = true;
            dgvIndirimdekiAlbumler.RowHeadersWidth = 51;
            dgvIndirimdekiAlbumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIndirimdekiAlbumler.Size = new Size(914, 649);
            dgvIndirimdekiAlbumler.TabIndex = 0;
            // 
            // FRMIndirimdekiAlbumler
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 673);
            Controls.Add(dgvIndirimdekiAlbumler);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FRMIndirimdekiAlbumler";
            Text = "FRMIndirimdekiAlbumler";
            Load += FRMIndirimdekiAlbumler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIndirimdekiAlbumler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvIndirimdekiAlbumler;
    }
}