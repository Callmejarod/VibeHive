namespace EventManagementAPI
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string Venue { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public int AvailableTickets { get; set; }
    }
}
