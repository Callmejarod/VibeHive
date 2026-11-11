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
using System.Net.Http.Json;

namespace VibeHive
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new HttpClient();

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                var events = await _httpClient.GetFromJsonAsync<List<EventDto>>(
                    "https://localhost:7200/api/events"
                );

                dgvEvents.DataSource = events;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load events: " + ex.Message);
            }
        }

        private void btnEventLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private async void btnBookTicket_Click(object sender, EventArgs e)
        {

            // Check if the user is logged in
            if (string.IsNullOrEmpty(Session.AccessToken))
            {
                MessageBox.Show("Please log in before booking a ticket.");
                return;
            }

            // Check if an event is selected
            if (dgvEvents.CurrentRow == null ||
                dgvEvents.CurrentRow.DataBoundItem is not EventDto selectedEvent)
            {
                MessageBox.Show("Please select an event first.");
                return;
            }

            try
            {
                int eventId = selectedEvent.Id;

                var request = new HttpRequestMessage(
                    HttpMethod.Post,
                    $"https://localhost:7200/api/tickets?eventId={eventId}"
                );

                // Attach the JWT token
                request.Headers.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer", Session.AccessToken
                    );

                var response = await _httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "Booking failed: " +
                        await response.Content.ReadAsStringAsync()
                    );
                    return;
                }

                MessageBox.Show("Ticket booked successfully!");

                // Refresh the events to show updated ticket availability
                var events = await _httpClient.GetFromJsonAsync<List<EventDto>>(
                    "https://localhost:7200/api/events"
                );

                dgvEvents.DataSource = events;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnOpenCreateEvent_Click(object sender, EventArgs e)
        {
            using var createForm = new CreateEventForm();
            createForm.ShowDialog();
        }
    }

    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public DateTime Date { get; set; }
        public string Venue { get; set; } = "";
        public string Genre { get; set; } = "";
        public int AvailableTickets { get; set; }
    }
}
