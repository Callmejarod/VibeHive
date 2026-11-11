using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace VibeHive
{
    public partial class CreateEventForm : Form
    {
        public CreateEventForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private readonly HttpClient _httpClient = new HttpClient();

        private async void btnCreateEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Session.AccessToken))
            {
                MessageBox.Show("Please log in first.");
                return;
            }

            var eventData = new
            {
                Name = txtEventName.Text.Trim(),
                Date = dtpEventDate.Value,
                Venue = txtVenue.Text.Trim(),
                Genre = txtGenre.Text.Trim(),
                AvailableTickets = (int)numTickets.Value
            };

            try
            {
                using var request = new HttpRequestMessage(
                    HttpMethod.Post,
                    "https://localhost:7200/api/events"
                );

                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Bearer", Session.AccessToken);

                request.Content = JsonContent.Create(eventData);

                using var response = await _httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Failed to create event ({(int)response.StatusCode}): " +
                        await response.Content.ReadAsStringAsync()
                    );
                    return;
                }

                MessageBox.Show("Event created successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
