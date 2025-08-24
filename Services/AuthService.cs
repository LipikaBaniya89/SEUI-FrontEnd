using DisasterReliefFrontEnd.Models;

namespace DisasterReliefFrontEnd.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new(); // In-memory user store
        private User? _loggedInUser;

        // Register new user
        public bool Register(User user)
        {
            if (_users.Any(u => u.Username == user.Username || u.Email == user.Email))
                return false;

            _users.Add(user);
            return true;
        }

        // Login
        public bool Login(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                _loggedInUser = user;
                return true;
            }
            return false;
        }

        // Get logged in user
        public User? GetCurrentUser() => _loggedInUser;

        // Update profile
        public void UpdateProfile(User updatedUser)
        {
            if (_loggedInUser != null)
            {
                _loggedInUser.Age = updatedUser.Age;
                _loggedInUser.Occupation = updatedUser.Occupation;
                _loggedInUser.Prompt = updatedUser.Prompt;
            }
        }
    }
}
