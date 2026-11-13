namespace MusicRentalWinForms
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.labtxtAlbumId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtAlbumId = new System.Windows.Forms.TextBox();
            this.txtRentalId = new System.Windows.Forms.TextBox();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnDeleteMusic = new System.Windows.Forms.Button();
            this.btnViewRentals = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnViewMusic = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AlbumT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(45, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Album Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(226, 9);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(36, 16);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(381, 23);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 16);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(583, 43);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 16);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(45, 112);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(51, 16);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "user_Id";
            // 
            // labtxtAlbumId
            // 
            this.labtxtAlbumId.AutoSize = true;
            this.labtxtAlbumId.Location = new System.Drawing.Point(259, 103);
            this.labtxtAlbumId.Name = "labtxtAlbumId";
            this.labtxtAlbumId.Size = new System.Drawing.Size(56, 16);
            this.labtxtAlbumId.TabIndex = 5;
            this.labtxtAlbumId.Text = "AlbumId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rental_ ID";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(35, 54);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(128, 22);
            this.txtTitle.TabIndex = 7;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(215, 43);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 22);
            this.txtArtist.TabIndex = 8;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(384, 54);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 22);
            this.txtGenre.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(558, 71);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 10;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(35, 151);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(124, 22);
            this.txtUserId.TabIndex = 11;
            // 
            // txtAlbumId
            // 
            this.txtAlbumId.Location = new System.Drawing.Point(244, 137);
            this.txtAlbumId.Name = "txtAlbumId";
            this.txtAlbumId.Size = new System.Drawing.Size(100, 22);
            this.txtAlbumId.TabIndex = 12;
            // 
            // txtRentalId
            // 
            this.txtRentalId.Location = new System.Drawing.Point(406, 137);
            this.txtRentalId.Name = "txtRentalId";
            this.txtRentalId.Size = new System.Drawing.Size(100, 22);
            this.txtRentalId.TabIndex = 13;
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Location = new System.Drawing.Point(68, 194);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(75, 23);
            this.btnAddMusic.TabIndex = 14;
            this.btnAddMusic.Text = "Add Album";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // btnDeleteMusic
            // 
            this.btnDeleteMusic.Location = new System.Drawing.Point(337, 186);
            this.btnDeleteMusic.Name = "btnDeleteMusic";
            this.btnDeleteMusic.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteMusic.TabIndex = 15;
            this.btnDeleteMusic.Text = "Delete Album";
            this.btnDeleteMusic.UseVisualStyleBackColor = true;
            this.btnDeleteMusic.Click += new System.EventHandler(this.btnDeleteMusic_Click);
            // 
            // btnViewRentals
            // 
            this.btnViewRentals.Location = new System.Drawing.Point(650, 186);
            this.btnViewRentals.Name = "btnViewRentals";
            this.btnViewRentals.Size = new System.Drawing.Size(125, 23);
            this.btnViewRentals.TabIndex = 16;
            this.btnViewRentals.Text = "View Rentals";
            this.btnViewRentals.UseVisualStyleBackColor = true;
            this.btnViewRentals.Click += new System.EventHandler(this.btnViewRentals_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(537, 157);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 23);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return Album";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(458, 186);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(121, 23);
            this.btnRent.TabIndex = 18;
            this.btnRent.Text = "Rent Album";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnViewMusic
            // 
            this.btnViewMusic.Location = new System.Drawing.Point(195, 177);
            this.btnViewMusic.Name = "btnViewMusic";
            this.btnViewMusic.Size = new System.Drawing.Size(111, 40);
            this.btnViewMusic.TabIndex = 19;
            this.btnViewMusic.Text = "View Album";
            this.btnViewMusic.UseVisualStyleBackColor = true;
            this.btnViewMusic.Click += new System.EventHandler(this.btnViewMusic_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumT,
            this.Artist,
            this.genre,
            this.year,
            this.user_id,
            this.albumID,
            this.rentalid});
            this.dataGridView1.Location = new System.Drawing.Point(35, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 160);
            this.dataGridView1.TabIndex = 20;
            // 
            // AlbumT
            // 
            this.AlbumT.HeaderText = "Album_T";
            this.AlbumT.MinimumWidth = 6;
            this.AlbumT.Name = "AlbumT";
            this.AlbumT.Width = 125;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            this.Artist.Width = 125;
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            this.genre.Width = 125;
            // 
            // year
            // 
            this.year.HeaderText = "year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.Width = 125;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "user_id";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.Width = 125;
            // 
            // albumID
            // 
            this.albumID.HeaderText = "AlbumId";
            this.albumID.MinimumWidth = 6;
            this.albumID.Name = "albumID";
            this.albumID.Width = 125;
            // 
            // rentalid
            // 
            this.rentalid.HeaderText = "RentalId";
            this.rentalid.MinimumWidth = 6;
            this.rentalid.Name = "rentalid";
            this.rentalid.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnViewMusic);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnViewRentals);
            this.Controls.Add(this.btnDeleteMusic);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.txtRentalId);
            this.Controls.Add(this.txtAlbumId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labtxtAlbumId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label labtxtAlbumId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtAlbumId;
        private System.Windows.Forms.TextBox txtRentalId;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Button btnDeleteMusic;
        private System.Windows.Forms.Button btnViewRentals;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnViewMusic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalid;
        private System.Windows.Forms.Label label1;
    }
}

