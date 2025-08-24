using DisasterReliefFrontEnd.Models;

namespace DisasterReliefFrontEnd.Services
{
    public class DisasterService
    {
        // Mock data for now
        private List<Disaster> _disasters = new()
        {
            new Disaster { Id = "1", Name="Flood in Mississippi", IsEmergency=true, LocationRadius=50, Link="https://example.com/flood-ms", Coordinates = new double[]{32.3547, -89.3985}},
            new Disaster { Id = "2", Name="Wildfire in California", IsEmergency=true, LocationRadius=120, Link="https://example.com/wildfire-ca", Coordinates = new double[]{36.7783, -119.4179}  },
            new Disaster { Id = "3", Name="Minor storm in Texas", IsEmergency=false, LocationRadius=30, Link="https://example.com/storm-tx", Coordinates = new double[]{31.9686, -99.9018} }
        };

        public Task<List<Disaster>> GetAllDisastersAsync()
        {
            return Task.FromResult(_disasters);
        }

        public Task<Disaster?> GetDisasterByIdAsync(string id)
        {
            var disaster = _disasters.FirstOrDefault(d => d.Id == id);
            return Task.FromResult(disaster);
        }
    }

    public class DisasterResult
    {
        public string RecommendedDisaster { get; set; }
        public string DisasterType { get; set; }
        public int PeopleAffected { get; set; }
        public string DisasterDetails { get; set; }
        public string DisasterIcon { get; set; }
        public List<HelpTask> HelpTasks { get; set; } = new();
        public bool IsExpanded { get; set; } = false;
    }

    public class HelpTask
    {
        public string TaskDescription { get; set; }
        public string HelpType { get; set; }
        public string DetailedDescription { get; set; }
        public string Link { get; set; }
        public string TaskIcon { get; set; }
        public List<string> Precautions { get; set; } = new();
        public List<string> Steps { get; set; } = new(); // Step-by-step instructions
    }
}
