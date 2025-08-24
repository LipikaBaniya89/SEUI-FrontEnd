namespace DisasterReliefFrontEnd.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // New fields
        public int Age { get; set; }
        public string Occupation { get; set; } = string.Empty;
        public string Prompt { get; set; } = string.Empty;

        // Profile information
        public string Location { get; set; } = string.Empty;
        public string Preference { get; set; } = string.Empty;
        public string Skills { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
