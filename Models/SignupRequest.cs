namespace DisasterReliefFrontEnd.Models
{
    public class SignupRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int? RadiusMeters { get; set; }
        public List<string> Skills { get; set; } = new();
        public string Phone { get; set; }
        public bool WantsEmail { get; set; }
        public bool WantsSms { get; set; }
        public string Role { get; set; } = "USER";
    }
}
