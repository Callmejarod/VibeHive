using AlbumsUI;

namespace VibeHive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            EventsForm eventsForm = new EventsForm();
            eventsForm.Show();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            var albumsForm = new AlbumsForm();
            albumsForm.Show();
        }
    }
}
