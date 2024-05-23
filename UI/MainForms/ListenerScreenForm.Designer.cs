namespace UI
{
    partial class ListenerScreenForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageYourSongs = new System.Windows.Forms.TabPage();
            this.dataGridViewUserSongs = new System.Windows.Forms.DataGridView();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSearchYourSongs = new System.Windows.Forms.Button();
            this.textBoxSearchYourSongs = new System.Windows.Forms.TextBox();
            this.labelYourSongs = new System.Windows.Forms.Label();
            this.tabPageAllSongs = new System.Windows.Forms.TabPage();
            this.dataGridViewAllSongs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSearchAllSongs = new System.Windows.Forms.Button();
            this.textBoxSearchAllSongs = new System.Windows.Forms.TextBox();
            this.labelAllSongs = new System.Windows.Forms.Label();
            this.tabPagePlaylists = new System.Windows.Forms.TabPage();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.labelYourPlaylists = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSongsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageYourSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSongs)).BeginInit();
            this.tabPageAllSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSongs)).BeginInit();
            this.tabPagePlaylists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageYourSongs);
            this.tabControl1.Controls.Add(this.tabPageAllSongs);
            this.tabControl1.Controls.Add(this.tabPagePlaylists);
            this.tabControl1.Controls.Add(this.tabPageAlbums);
            this.tabControl1.Controls.Add(this.tabPageProfile);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 444);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseEnter += new System.EventHandler(this.tabControl1_MouseEnter);
            // 
            // tabPageYourSongs
            // 
            this.tabPageYourSongs.Controls.Add(this.dataGridViewUserSongs);
            this.tabPageYourSongs.Controls.Add(this.buttonSearchYourSongs);
            this.tabPageYourSongs.Controls.Add(this.textBoxSearchYourSongs);
            this.tabPageYourSongs.Controls.Add(this.labelYourSongs);
            this.tabPageYourSongs.Location = new System.Drawing.Point(4, 24);
            this.tabPageYourSongs.Name = "tabPageYourSongs";
            this.tabPageYourSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYourSongs.Size = new System.Drawing.Size(904, 416);
            this.tabPageYourSongs.TabIndex = 0;
            this.tabPageYourSongs.Text = "Ваши песни";
            this.tabPageYourSongs.UseVisualStyleBackColor = true;
            this.tabPageYourSongs.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridViewUserSongs
            // 
            this.dataGridViewUserSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitle,
            this.ColumnArtist,
            this.ColumnDuration,
            this.ColumnButton});
            this.dataGridViewUserSongs.Location = new System.Drawing.Point(11, 87);
            this.dataGridViewUserSongs.Name = "dataGridViewUserSongs";
            this.dataGridViewUserSongs.RowTemplate.Height = 25;
            this.dataGridViewUserSongs.Size = new System.Drawing.Size(446, 321);
            this.dataGridViewUserSongs.TabIndex = 7;
            this.dataGridViewUserSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserSongs_CellContentClick);
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            // 
            // ColumnArtist
            // 
            this.ColumnArtist.HeaderText = "Artist";
            this.ColumnArtist.Name = "ColumnArtist";
            // 
            // ColumnDuration
            // 
            this.ColumnDuration.HeaderText = "";
            this.ColumnDuration.Name = "ColumnDuration";
            // 
            // ColumnButton
            // 
            this.ColumnButton.HeaderText = "";
            this.ColumnButton.Name = "ColumnButton";
            this.ColumnButton.Text = "Играть";
            this.ColumnButton.UseColumnTextForButtonValue = true;
            // 
            // buttonSearchYourSongs
            // 
            this.buttonSearchYourSongs.Location = new System.Drawing.Point(117, 34);
            this.buttonSearchYourSongs.Name = "buttonSearchYourSongs";
            this.buttonSearchYourSongs.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchYourSongs.TabIndex = 6;
            this.buttonSearchYourSongs.Text = "Поиск";
            this.buttonSearchYourSongs.UseVisualStyleBackColor = true;
            this.buttonSearchYourSongs.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSearchYourSongs
            // 
            this.textBoxSearchYourSongs.Location = new System.Drawing.Point(11, 34);
            this.textBoxSearchYourSongs.Name = "textBoxSearchYourSongs";
            this.textBoxSearchYourSongs.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchYourSongs.TabIndex = 5;
            // 
            // labelYourSongs
            // 
            this.labelYourSongs.AutoSize = true;
            this.labelYourSongs.Location = new System.Drawing.Point(8, 9);
            this.labelYourSongs.Name = "labelYourSongs";
            this.labelYourSongs.Size = new System.Drawing.Size(77, 15);
            this.labelYourSongs.TabIndex = 4;
            this.labelYourSongs.Text = "Ваши песни:";
            // 
            // tabPageAllSongs
            // 
            this.tabPageAllSongs.Controls.Add(this.dataGridViewAllSongs);
            this.tabPageAllSongs.Controls.Add(this.buttonSearchAllSongs);
            this.tabPageAllSongs.Controls.Add(this.textBoxSearchAllSongs);
            this.tabPageAllSongs.Controls.Add(this.labelAllSongs);
            this.tabPageAllSongs.Location = new System.Drawing.Point(4, 24);
            this.tabPageAllSongs.Name = "tabPageAllSongs";
            this.tabPageAllSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllSongs.Size = new System.Drawing.Size(904, 416);
            this.tabPageAllSongs.TabIndex = 1;
            this.tabPageAllSongs.Text = "Все песни";
            this.tabPageAllSongs.UseVisualStyleBackColor = true;
            this.tabPageAllSongs.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridViewAllSongs
            // 
            this.dataGridViewAllSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1,
            this.ColumnAdd});
            this.dataGridViewAllSongs.Location = new System.Drawing.Point(11, 87);
            this.dataGridViewAllSongs.Name = "dataGridViewAllSongs";
            this.dataGridViewAllSongs.RowTemplate.Height = 25;
            this.dataGridViewAllSongs.Size = new System.Drawing.Size(547, 321);
            this.dataGridViewAllSongs.TabIndex = 11;
            this.dataGridViewAllSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllSongs_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.dataGridViewButtonColumn1.Text = "";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "+";
            this.ColumnAdd.Name = "ColumnAdd";
            // 
            // buttonSearchAllSongs
            // 
            this.buttonSearchAllSongs.Location = new System.Drawing.Point(117, 34);
            this.buttonSearchAllSongs.Name = "buttonSearchAllSongs";
            this.buttonSearchAllSongs.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchAllSongs.TabIndex = 10;
            this.buttonSearchAllSongs.Text = "button2";
            this.buttonSearchAllSongs.UseVisualStyleBackColor = true;
            this.buttonSearchAllSongs.Click += new System.EventHandler(this.buttonSearchAllSongs_Click);
            // 
            // textBoxSearchAllSongs
            // 
            this.textBoxSearchAllSongs.Location = new System.Drawing.Point(11, 34);
            this.textBoxSearchAllSongs.Name = "textBoxSearchAllSongs";
            this.textBoxSearchAllSongs.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearchAllSongs.TabIndex = 9;
            // 
            // labelAllSongs
            // 
            this.labelAllSongs.AutoSize = true;
            this.labelAllSongs.Location = new System.Drawing.Point(11, 10);
            this.labelAllSongs.Name = "labelAllSongs";
            this.labelAllSongs.Size = new System.Drawing.Size(65, 15);
            this.labelAllSongs.TabIndex = 8;
            this.labelAllSongs.Text = "Все песни:";
            // 
            // tabPagePlaylists
            // 
            this.tabPagePlaylists.Controls.Add(this.buttonAddPlaylist);
            this.tabPagePlaylists.Controls.Add(this.labelYourPlaylists);
            this.tabPagePlaylists.Controls.Add(this.dataGridView2);
            this.tabPagePlaylists.Controls.Add(this.dataGridView1);
            this.tabPagePlaylists.Location = new System.Drawing.Point(4, 24);
            this.tabPagePlaylists.Name = "tabPagePlaylists";
            this.tabPagePlaylists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaylists.Size = new System.Drawing.Size(904, 416);
            this.tabPagePlaylists.TabIndex = 2;
            this.tabPagePlaylists.Text = "Плейлисты";
            this.tabPagePlaylists.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlaylist
            // 
            this.buttonAddPlaylist.Location = new System.Drawing.Point(201, 18);
            this.buttonAddPlaylist.Name = "buttonAddPlaylist";
            this.buttonAddPlaylist.Size = new System.Drawing.Size(148, 23);
            this.buttonAddPlaylist.TabIndex = 14;
            this.buttonAddPlaylist.Text = "Добавить плейлист";
            this.buttonAddPlaylist.UseVisualStyleBackColor = true;
            this.buttonAddPlaylist.Click += new System.EventHandler(this.buttonAddPlaylist_Click);
            // 
            // labelYourPlaylists
            // 
            this.labelYourPlaylists.AutoSize = true;
            this.labelYourPlaylists.Location = new System.Drawing.Point(7, 22);
            this.labelYourPlaylists.Name = "labelYourPlaylists";
            this.labelYourPlaylists.Size = new System.Drawing.Size(105, 15);
            this.labelYourPlaylists.TabIndex = 13;
            this.labelYourPlaylists.Text = "Ваши плейлисты:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(355, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(368, 355);
            this.dataGridView2.TabIndex = 12;
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
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 75;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSongsCount,
            this.ColumnPlay});
            this.dataGridView1.Location = new System.Drawing.Point(6, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(343, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSongsCount
            // 
            this.ColumnSongsCount.HeaderText = "Кол-во";
            this.ColumnSongsCount.Name = "ColumnSongsCount";
            this.ColumnSongsCount.Width = 50;
            // 
            // ColumnPlay
            // 
            this.ColumnPlay.HeaderText = "";
            this.ColumnPlay.Name = "ColumnPlay";
            this.ColumnPlay.Text = "Играть";
            this.ColumnPlay.Width = 75;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 24);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbums.Size = new System.Drawing.Size(904, 416);
            this.tabPageAlbums.TabIndex = 3;
            this.tabPageAlbums.Text = "Альбомы";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Location = new System.Drawing.Point(4, 24);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(904, 416);
            this.tabPageProfile.TabIndex = 4;
            this.tabPageProfile.Text = "Профиль";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // ListenerScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListenerScreenForm";
            this.Text = "ListenerScreen";
            this.Load += new System.EventHandler(this.ListenerScreenForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageYourSongs.ResumeLayout(false);
            this.tabPageYourSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSongs)).EndInit();
            this.tabPageAllSongs.ResumeLayout(false);
            this.tabPageAllSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSongs)).EndInit();
            this.tabPagePlaylists.ResumeLayout(false);
            this.tabPagePlaylists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageYourSongs;
        private TabPage tabPageAllSongs;
        private TabPage tabPagePlaylists;
        private TabPage tabPageAlbums;
        private TabPage tabPageProfile;
        private DataGridView dataGridViewUserSongs;
        private Button buttonSearchYourSongs;
        private TextBox textBoxSearchYourSongs;
        private Label labelYourSongs;
        private DataGridView dataGridViewAllSongs;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn ColumnAdd;
        private Button buttonSearchAllSongs;
        private TextBox textBoxSearchAllSongs;
        private Label labelAllSongs;
        private DataGridViewTextBoxColumn ColumnTitle;
        private DataGridViewTextBoxColumn ColumnArtist;
        private DataGridViewTextBoxColumn ColumnDuration;
        private DataGridViewButtonColumn ColumnButton;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnSongsCount;
        private DataGridViewButtonColumn ColumnPlay;
        private Button buttonAddPlaylist;
        private Label labelYourPlaylists;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}