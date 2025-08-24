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
}
