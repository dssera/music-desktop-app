﻿namespace UI
{
    partial class ArtistScreenForm
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
            this.dataGridViewMySongs = new System.Windows.Forms.DataGridView();
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.buttonSearchYourSongs = new System.Windows.Forms.Button();
            this.textBoxSearchYourSongs = new System.Windows.Forms.TextBox();
            this.labelYourSongs = new System.Windows.Forms.Label();
            this.tabPageAllSongs = new System.Windows.Forms.TabPage();
            this.dataGridViewAllSongs = new System.Windows.Forms.DataGridView();
            this.buttonSearchAllSongs = new System.Windows.Forms.Button();
            this.textBoxSearchAllSongs = new System.Windows.Forms.TextBox();
            this.labelAllSongs = new System.Windows.Forms.Label();
            this.tabPagePlaylists = new System.Windows.Forms.TabPage();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.labelYourPlaylists = new System.Windows.Forms.Label();
            this.dataGridViewPlaylistSongs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewMyAlbums = new System.Windows.Forms.DataGridView();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.labelAllAlbums = new System.Windows.Forms.Label();
            this.dataGridViewAlbum = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewAllAlbums = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelEmailValue = new System.Windows.Forms.Label();
            this.labelFullNameValue = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSongsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnChange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageYourSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySongs)).BeginInit();
            this.tabPageAllSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSongs)).BeginInit();
            this.tabPagePlaylists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylistSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyAlbums)).BeginInit();
            this.tabPageAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAlbums)).BeginInit();
            this.tabPageProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageYourSongs);
            this.tabControl1.Controls.Add(this.tabPageAllSongs);
            this.tabControl1.Controls.Add(this.tabPagePlaylists);
            this.tabControl1.Controls.Add(this.tabPageAlbums);
            this.tabControl1.Controls.Add(this.tabPageProfile);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 415);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageYourSongs
            // 
            this.tabPageYourSongs.Controls.Add(this.dataGridViewMySongs);
            this.tabPageYourSongs.Controls.Add(this.buttonAddSong);
            this.tabPageYourSongs.Controls.Add(this.buttonSearchYourSongs);
            this.tabPageYourSongs.Controls.Add(this.textBoxSearchYourSongs);
            this.tabPageYourSongs.Controls.Add(this.labelYourSongs);
            this.tabPageYourSongs.Location = new System.Drawing.Point(4, 24);
            this.tabPageYourSongs.Name = "tabPageYourSongs";
            this.tabPageYourSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYourSongs.Size = new System.Drawing.Size(995, 387);
            this.tabPageYourSongs.TabIndex = 0;
            this.tabPageYourSongs.Text = "Мои песни";
            this.tabPageYourSongs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMySongs
            // 
            this.dataGridViewMySongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMySongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.ColumnArtist,
            this.ColumnDuration,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewButtonColumn5,
            this.dataGridViewButtonColumn6,
            this.dataGridViewButtonColumn7});
            this.dataGridViewMySongs.Location = new System.Drawing.Point(11, 63);
            this.dataGridViewMySongs.Name = "dataGridViewMySongs";
            this.dataGridViewMySongs.RowTemplate.Height = 25;
            this.dataGridViewMySongs.Size = new System.Drawing.Size(725, 318);
            this.dataGridViewMySongs.TabIndex = 9;
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.Location = new System.Drawing.Point(498, 33);
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.Size = new System.Drawing.Size(142, 23);
            this.buttonAddSong.TabIndex = 8;
            this.buttonAddSong.Text = "Добавить песню";
            this.buttonAddSong.UseVisualStyleBackColor = true;
            // 
            // buttonSearchYourSongs
            // 
            this.buttonSearchYourSongs.Location = new System.Drawing.Point(117, 34);
            this.buttonSearchYourSongs.Name = "buttonSearchYourSongs";
            this.buttonSearchYourSongs.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchYourSongs.TabIndex = 6;
            this.buttonSearchYourSongs.Text = "Поиск";
            this.buttonSearchYourSongs.UseVisualStyleBackColor = true;
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
            this.labelYourSongs.Location = new System.Drawing.Point(11, 12);
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
            this.tabPageAllSongs.Size = new System.Drawing.Size(995, 387);
            this.tabPageAllSongs.TabIndex = 1;
            this.tabPageAllSongs.Text = "Все песни";
            this.tabPageAllSongs.UseVisualStyleBackColor = true;
            this.tabPageAllSongs.Click += new System.EventHandler(this.tabPageAllSongs_Click);
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
            this.dataGridViewAllSongs.Size = new System.Drawing.Size(658, 321);
            this.dataGridViewAllSongs.TabIndex = 11;
            // 
            // buttonSearchAllSongs
            // 
            this.buttonSearchAllSongs.Location = new System.Drawing.Point(117, 34);
            this.buttonSearchAllSongs.Name = "buttonSearchAllSongs";
            this.buttonSearchAllSongs.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchAllSongs.TabIndex = 10;
            this.buttonSearchAllSongs.Text = "button2";
            this.buttonSearchAllSongs.UseVisualStyleBackColor = true;
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
            this.labelAllSongs.Location = new System.Drawing.Point(14, 13);
            this.labelAllSongs.Name = "labelAllSongs";
            this.labelAllSongs.Size = new System.Drawing.Size(65, 15);
            this.labelAllSongs.TabIndex = 8;
            this.labelAllSongs.Text = "Все песни:";
            // 
            // tabPagePlaylists
            // 
            this.tabPagePlaylists.Controls.Add(this.buttonAddPlaylist);
            this.tabPagePlaylists.Controls.Add(this.labelYourPlaylists);
            this.tabPagePlaylists.Controls.Add(this.dataGridViewPlaylistSongs);
            this.tabPagePlaylists.Controls.Add(this.dataGridViewMyAlbums);
            this.tabPagePlaylists.Location = new System.Drawing.Point(4, 24);
            this.tabPagePlaylists.Name = "tabPagePlaylists";
            this.tabPagePlaylists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaylists.Size = new System.Drawing.Size(995, 387);
            this.tabPagePlaylists.TabIndex = 2;
            this.tabPagePlaylists.Text = "Мои альбомы";
            this.tabPagePlaylists.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlaylist
            // 
            this.buttonAddPlaylist.Location = new System.Drawing.Point(327, 18);
            this.buttonAddPlaylist.Name = "buttonAddPlaylist";
            this.buttonAddPlaylist.Size = new System.Drawing.Size(148, 23);
            this.buttonAddPlaylist.TabIndex = 14;
            this.buttonAddPlaylist.Text = "Добавить плейлист";
            this.buttonAddPlaylist.UseVisualStyleBackColor = true;
            // 
            // labelYourPlaylists
            // 
            this.labelYourPlaylists.AutoSize = true;
            this.labelYourPlaylists.Location = new System.Drawing.Point(10, 25);
            this.labelYourPlaylists.Name = "labelYourPlaylists";
            this.labelYourPlaylists.Size = new System.Drawing.Size(105, 15);
            this.labelYourPlaylists.TabIndex = 13;
            this.labelYourPlaylists.Text = "Ваши плейлисты:";
            // 
            // dataGridViewPlaylistSongs
            // 
            this.dataGridViewPlaylistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylistSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn3});
            this.dataGridViewPlaylistSongs.Location = new System.Drawing.Point(481, 54);
            this.dataGridViewPlaylistSongs.Name = "dataGridViewPlaylistSongs";
            this.dataGridViewPlaylistSongs.RowTemplate.Height = 25;
            this.dataGridViewPlaylistSongs.Size = new System.Drawing.Size(369, 355);
            this.dataGridViewPlaylistSongs.TabIndex = 12;
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
            // dataGridViewMyAlbums
            // 
            this.dataGridViewMyAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSongsCount,
            this.ColumnPlays,
            this.ColumnPlay,
            this.ColumnChange,
            this.ColumnDelete});
            this.dataGridViewMyAlbums.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewMyAlbums.Name = "dataGridViewMyAlbums";
            this.dataGridViewMyAlbums.RowTemplate.Height = 25;
            this.dataGridViewMyAlbums.Size = new System.Drawing.Size(469, 355);
            this.dataGridViewMyAlbums.TabIndex = 0;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Controls.Add(this.labelAllAlbums);
            this.tabPageAlbums.Controls.Add(this.dataGridViewAlbum);
            this.tabPageAlbums.Controls.Add(this.dataGridViewAllAlbums);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 24);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbums.Size = new System.Drawing.Size(995, 387);
            this.tabPageAlbums.TabIndex = 3;
            this.tabPageAlbums.Text = "Альбомы";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // labelAllAlbums
            // 
            this.labelAllAlbums.AutoSize = true;
            this.labelAllAlbums.Location = new System.Drawing.Point(9, 19);
            this.labelAllAlbums.Name = "labelAllAlbums";
            this.labelAllAlbums.Size = new System.Drawing.Size(83, 15);
            this.labelAllAlbums.TabIndex = 17;
            this.labelAllAlbums.Text = "Все альбомы:";
            // 
            // dataGridViewAlbum
            // 
            this.dataGridViewAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewButtonColumn2});
            this.dataGridViewAlbum.Location = new System.Drawing.Point(393, 48);
            this.dataGridViewAlbum.Name = "dataGridViewAlbum";
            this.dataGridViewAlbum.RowTemplate.Height = 25;
            this.dataGridViewAlbum.Size = new System.Drawing.Size(369, 355);
            this.dataGridViewAlbum.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Играть";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 75;
            // 
            // dataGridViewAllAlbums
            // 
            this.dataGridViewAllAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewButtonColumn4});
            this.dataGridViewAllAlbums.Location = new System.Drawing.Point(5, 48);
            this.dataGridViewAllAlbums.Name = "dataGridViewAllAlbums";
            this.dataGridViewAllAlbums.RowTemplate.Height = 25;
            this.dataGridViewAllAlbums.Size = new System.Drawing.Size(372, 355);
            this.dataGridViewAllAlbums.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Исполнитель";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Text = "Играть";
            this.dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn4.Width = 75;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.labelEmail);
            this.tabPageProfile.Controls.Add(this.labelFullName);
            this.tabPageProfile.Controls.Add(this.labelEmailValue);
            this.tabPageProfile.Controls.Add(this.labelFullNameValue);
            this.tabPageProfile.Controls.Add(this.buttonLogOut);
            this.tabPageProfile.Controls.Add(this.labelUsername);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 24);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(995, 387);
            this.tabPageProfile.TabIndex = 4;
            this.tabPageProfile.Text = "Профиль";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(23, 74);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(83, 21);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Ваше имя:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFullName.Location = new System.Drawing.Point(23, 111);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(97, 21);
            this.labelFullName.TabIndex = 4;
            this.labelFullName.Text = "Ваша почта:";
            // 
            // labelEmailValue
            // 
            this.labelEmailValue.AutoSize = true;
            this.labelEmailValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmailValue.Location = new System.Drawing.Point(132, 111);
            this.labelEmailValue.Name = "labelEmailValue";
            this.labelEmailValue.Size = new System.Drawing.Size(48, 21);
            this.labelEmailValue.TabIndex = 3;
            this.labelEmailValue.Text = "Email";
            // 
            // labelFullNameValue
            // 
            this.labelFullNameValue.AutoSize = true;
            this.labelFullNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFullNameValue.Location = new System.Drawing.Point(132, 74);
            this.labelFullNameValue.Name = "labelFullNameValue";
            this.labelFullNameValue.Size = new System.Drawing.Size(77, 21);
            this.labelFullNameValue.TabIndex = 2;
            this.labelFullNameValue.Text = "FullName";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(817, 22);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(157, 23);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Выйти из аккаунта";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(21, 20);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(99, 28);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Название";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // ColumnArtist
            // 
            this.ColumnArtist.HeaderText = "Исполнитель";
            this.ColumnArtist.Name = "ColumnArtist";
            // 
            // ColumnDuration
            // 
            this.ColumnDuration.HeaderText = "Время";
            this.ColumnDuration.Name = "ColumnDuration";
            this.ColumnDuration.Width = 75;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Прослушивания";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 105;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.HeaderText = "";
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            this.dataGridViewButtonColumn5.Text = "Играть";
            this.dataGridViewButtonColumn5.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn5.Width = 75;
            // 
            // dataGridViewButtonColumn6
            // 
            this.dataGridViewButtonColumn6.FillWeight = 80F;
            this.dataGridViewButtonColumn6.HeaderText = "";
            this.dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
            this.dataGridViewButtonColumn6.Text = "Изменить";
            this.dataGridViewButtonColumn6.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn7
            // 
            this.dataGridViewButtonColumn7.FillWeight = 80F;
            this.dataGridViewButtonColumn7.HeaderText = "";
            this.dataGridViewButtonColumn7.Name = "dataGridViewButtonColumn7";
            this.dataGridViewButtonColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn7.Text = "Удалить";
            this.dataGridViewButtonColumn7.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Исполнитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Время";
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
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSongsCount
            // 
            this.ColumnSongsCount.HeaderText = "Исполнитель";
            this.ColumnSongsCount.Name = "ColumnSongsCount";
            this.ColumnSongsCount.Width = 50;
            // 
            // ColumnPlays
            // 
            this.ColumnPlays.HeaderText = "Прослушивания";
            this.ColumnPlays.Name = "ColumnPlays";
            this.ColumnPlays.Width = 105;
            // 
            // ColumnPlay
            // 
            this.ColumnPlay.HeaderText = "";
            this.ColumnPlay.Name = "ColumnPlay";
            this.ColumnPlay.Text = "Играть";
            this.ColumnPlay.UseColumnTextForButtonValue = true;
            this.ColumnPlay.Width = 75;
            // 
            // ColumnChange
            // 
            this.ColumnChange.FillWeight = 80F;
            this.ColumnChange.HeaderText = "";
            this.ColumnChange.Name = "ColumnChange";
            this.ColumnChange.Text = "Изменить";
            this.ColumnChange.UseColumnTextForButtonValue = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.FillWeight = 80F;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDelete.Text = "Удалить";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // ArtistScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1002, 419);
            this.Controls.Add(this.tabControl1);
            this.Name = "ArtistScreenForm";
            this.Text = "ArtistForm";
            this.Load += new System.EventHandler(this.ArtistForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageYourSongs.ResumeLayout(false);
            this.tabPageYourSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySongs)).EndInit();
            this.tabPageAllSongs.ResumeLayout(false);
            this.tabPageAllSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSongs)).EndInit();
            this.tabPagePlaylists.ResumeLayout(false);
            this.tabPagePlaylists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylistSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyAlbums)).EndInit();
            this.tabPageAlbums.ResumeLayout(false);
            this.tabPageAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAlbums)).EndInit();
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageYourSongs;
        private Button buttonSearchYourSongs;
        private TextBox textBoxSearchYourSongs;
        private Label labelYourSongs;
        private TabPage tabPageAllSongs;
        private DataGridView dataGridViewAllSongs;
        private Button buttonSearchAllSongs;
        private TextBox textBoxSearchAllSongs;
        private Label labelAllSongs;
        private TabPage tabPagePlaylists;
        private Button buttonAddPlaylist;
        private Label labelYourPlaylists;
        private DataGridView dataGridViewPlaylistSongs;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridView dataGridViewMyAlbums;
        private TabPage tabPageAlbums;
        private Label labelAllAlbums;
        private DataGridView dataGridViewAlbum;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridView dataGridViewAllAlbums;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private TabPage tabPageProfile;
        private Label labelEmail;
        private Label labelFullName;
        private Label labelEmailValue;
        private Label labelFullNameValue;
        private Button buttonLogOut;
        private Label labelUsername;
        private Button buttonAddSong;
        private DataGridView dataGridViewMySongs;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn ColumnArtist;
        private DataGridViewTextBoxColumn ColumnDuration;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewButtonColumn dataGridViewButtonColumn5;
        private DataGridViewButtonColumn dataGridViewButtonColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn ColumnAdd;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnSongsCount;
        private DataGridViewTextBoxColumn ColumnPlays;
        private DataGridViewButtonColumn ColumnPlay;
        private DataGridViewButtonColumn ColumnChange;
        private DataGridViewButtonColumn ColumnDelete;
    }
}