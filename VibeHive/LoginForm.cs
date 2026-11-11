using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace VibeHive
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new HttpClient();

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var loginData = new
                {
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text
                };

                var response = await _httpClient.PostAsJsonAsync(
                    "https://localhost:7200/api/auth/login",
                    loginData
                );

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Invalid email or password.");
                    return;
                }

                var result = await response.Content
                    .ReadFromJsonAsync<LoginResponse>();

                if (string.IsNullOrEmpty(result?.Token))
                {
                    MessageBox.Show("No token was returned.");
                    return;
                }

                MessageBox.Show("Login successful!");

                // We'll use this token for ticket booking later.
                Session.AccessToken = result.Token;

                EventsForm eventsForm = new EventsForm();
                eventsForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var registerData = new
                {
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text
                };

                var response = await _httpClient.PostAsJsonAsync(
                    "https://localhost:7200/api/users/register",
                    registerData
                );

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "Registration failed: " +
                        await response.Content.ReadAsStringAsync()
                    );
                    return;
                }

                MessageBox.Show("Account created! You can now log in.");
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
