using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DisasterReliefFrontEnd.Models;

namespace DisasterReliefFrontEnd.Services
{
    public class AuthService
    {
        private readonly HttpClient _http;
        private User? _loggedInUser;

        public AuthService(HttpClient http)
        {
            _http = http;
        }

        // Call backend to register user
        public async Task<bool> RegisterAsync(SignupRequest request)
        {
            var response = await _http.PostAsJsonAsync("api/auth/signup", request);
            return response.IsSuccessStatusCode;
        }

        // Call backend to login
        public async Task<bool> LoginAsync(string email, string password)
        {
            var response = await _http.PostAsJsonAsync("api/auth/signin", new
            {
                email,
                password
            });

            if (response.IsSuccessStatusCode)
            {
                // if your backend returns user info or JWT, deserialize here
                _loggedInUser = await response.Content.ReadFromJsonAsync<User>();
                return true;
            }

            return false;
        }


        // Get currently logged-in user
        public User? GetCurrentUser() => _loggedInUser;

        // Update profile locally (or send to backend if you want persistence)
        public async Task<bool> UpdateProfileAsync(User updatedUser)
        {
            if (_loggedInUser == null) return false;

            var response = await _http.PutAsJsonAsync("api/auth/profile", updatedUser);
            if (response.IsSuccessStatusCode)
            {
                _loggedInUser = updatedUser;
                return true;
            }
            return false;
        }
    }
}
