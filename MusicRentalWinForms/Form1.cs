

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MusicRentalWinForms
{
    public partial class Form1 : Form
    {
        private const string apiUrl = "https://localhost:7169/api/";

        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtAlbumId);
            this.Controls.Add(this.txtRentalId);
        }

        // ADD ALBUM
        private async void btnAddMusic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtArtist.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) ||
                !int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Please enter valid album information.");
                return;
            }

            var music = new
            {
                Title = txtTitle.Text,
                Artist = txtArtist.Text,
                Genre = txtGenre.Text,
                Year = year,
                Available = true
            };

            try
            {
                string json = JsonConvert.SerializeObject(music);

                var content = new StringContent(
                    json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(
                    apiUrl + "music", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Album added successfully!");

                    txtTitle.Clear();
                    txtArtist.Clear();
                    txtGenre.Clear();
                    txtYear.Clear();

                    await LoadMusic();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // VIEW ALBUMS
        private async void btnViewMusic_Click(object sender, EventArgs e)
        {
            await LoadMusic();
        }

        private async Task LoadMusic()
        {
            try
            {
                string json = await client.GetStringAsync(
                    apiUrl + "music");

                var music = JsonConvert.DeserializeObject<List<Music>>(json);

                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = music;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // DELETE ALBUM
        private async void btnDeleteMusic_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAlbumId.Text, out int albumId))
            {
                MessageBox.Show("Please enter a valid Album ID.");
                return;
            }

            try
            {
                var response = await client.DeleteAsync(
                    apiUrl + "music/" + albumId);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Album deleted successfully!");
                    txtAlbumId.Clear();

                    await LoadMusic();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // RENT ALBUM
        private async void btnRent_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int userId) ||
                !int.TryParse(txtAlbumId.Text, out int albumId))
            {
                MessageBox.Show("Enter valid User ID and Album ID.");
                return;
            }

            var rental = new
            {
                UserId = userId,
                AlbumId = albumId
            };

            try
            {
                string json = JsonConvert.SerializeObject(rental);

                var content = new StringContent(
                    json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(
                    apiUrl + "rentals", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Album rented successfully!");

                    txtUserId.Clear();
                    txtAlbumId.Clear();

                    await LoadMusic();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // RETURN ALBUM
        private async void btnReturn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRentalId.Text, out int rentalId))
            {
                MessageBox.Show("Enter a valid Rental ID.");
                return;
            }

            try
            {
                var response = await client.PostAsync(
                    apiUrl + "rentals/" + rentalId + "/return",
                    null);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Album returned successfully!");

                    txtRentalId.Clear();

                    await LoadMusic();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // VIEW RENTALS
        private async void btnViewRentals_Click(object sender, EventArgs e)
        {
            try
            {
                string json = await client.GetStringAsync(
                    apiUrl + "rentals");

                var rentals = JsonConvert.DeserializeObject<List<Rental>>(json);

                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = rentals;

                MessageBox.Show("Rentals loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
