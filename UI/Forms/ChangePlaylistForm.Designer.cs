namespace UI.Forms
{
    partial class ChangePlaylistForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelCreatePlaylist = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewPlaylistSongs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSearchAllSongs = new System.Windows.Forms.Button();
            this.textBoxSearchAllSongs = new System.Windows.Forms.TextBox();
            this.labelAllSongs = new System.Windows.Forms.Label();
            this.dataGridViewAllSongs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylistSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(675, 83);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 19);
            this.labelTitle.TabIndex = 29;
            this.labelTitle.Text = "Название:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(753, 81);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 23);
            this.textBoxTitle.TabIndex = 28;
            // 
            // labelCreatePlaylist
            // 
            this.labelCreatePlaylist.AutoSize = true;
            this.labelCreatePlaylist.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreatePlaylist.Location = new System.Drawing.Point(12, 9);
            this.labelCreatePlaylist.Name = "labelCreatePlaylist";
            this.labelCreatePlaylist.Size = new System.Drawing.Size(254, 25);
            this.labelCreatePlaylist.TabIndex = 27;
            this.labelCreatePlaylist.Text = "Редактирование плейлиста:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(859, 81);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(185, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Сохранить плейлист";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewPlaylistSongs
            // 
            this.dataGridViewPlaylistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylistSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn3});
            this.dataGridViewPlaylistSongs.Location = new System.Drawing.Point(675, 112);
            this.dataGridViewPlaylistSongs.Name = "dataGridViewPlaylistSongs";
            this.dataGridViewPlaylistSongs.RowTemplate.Height = 25;
            this.dataGridViewPlaylistSongs.Size = new System.Drawing.Size(369, 321);
            this.dataGridViewPlaylistSongs.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Text = "Играть";
            this.dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn3.Width = 75;
            // 
            // buttonSearchAllSongs
            // 
            this.buttonSearchAllSongs.Location = new System.Drawing.Point(117, 76);
            this.buttonSearchAllSongs.Name = "buttonSearchAllSongs";
            this.buttonSearchAllSongs.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchAllSongs.TabIndex = 24;
            this.buttonSearchAllSongs.Text = "Поиск";
            this.buttonSearchAllSongs.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchAllSongs
            // 
            this.textBoxSearchAllSongs.Location = new System.Drawing.Point(11, 76);
            this.textBoxSearchAllSongs.Name = "textBoxSearchAllSongs";
            this.textBoxSearchAllSongs.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchAllSongs.TabIndex = 23;
            // 
            // labelAllSongs
            // 
            this.labelAllSongs.AutoSize = true;
            this.labelAllSongs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAllSongs.Location = new System.Drawing.Point(11, 43);
            this.labelAllSongs.Name = "labelAllSongs";
            this.labelAllSongs.Size = new System.Drawing.Size(83, 21);
            this.labelAllSongs.TabIndex = 22;
            this.labelAllSongs.Text = "Все песни:";
            // 
            // dataGridViewAllSongs
            // 
            this.dataGridViewAllSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxTitle,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1,
            this.ColumnAdd,
            this.ColumnDelete});
            this.dataGridViewAllSongs.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewAllSongs.Name = "dataGridViewAllSongs";
            this.dataGridViewAllSongs.RowTemplate.Height = 25;
            this.dataGridViewAllSongs.Size = new System.Drawing.Size(645, 321);
            this.dataGridViewAllSongs.TabIndex = 21;
            this.dataGridViewAllSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllSongs_CellContentClick);
            // 
            // dataGridViewTextBoxTitle
            // 
            this.dataGridViewTextBoxTitle.HeaderText = "Title";
            this.dataGridViewTextBoxTitle.Name = "dataGridViewTextBoxTitle";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Играть";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "";
            this.ColumnAdd.Name = "ColumnAdd";
            this.ColumnAdd.Text = "Добавить";
            this.ColumnAdd.UseColumnTextForButtonValue = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "Удалить";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // ChangePlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelCreatePlaylist);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewPlaylistSongs);
            this.Controls.Add(this.buttonSearchAllSongs);
            this.Controls.Add(this.textBoxSearchAllSongs);
            this.Controls.Add(this.labelAllSongs);
            this.Controls.Add(this.dataGridViewAllSongs);
            this.Name = "ChangePlaylistForm";
            this.Text = "ChangePlaylistForm";
            this.Load += new System.EventHandler(this.ChangePlaylistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylistSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxTitle;
        private Label labelCreatePlaylist;
        private Button buttonSave;
        private DataGridView dataGridViewPlaylistSongs;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private Button buttonSearchAllSongs;
        private TextBox textBoxSearchAllSongs;
        private Label labelAllSongs;
        private DataGridView dataGridViewAllSongs;
        private DataGridViewTextBoxColumn dataGridViewTextBoxTitle;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn ColumnAdd;
        private DataGridViewButtonColumn ColumnDelete;
    }
}