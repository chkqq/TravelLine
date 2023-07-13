
namespace Core.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientFirstName { get; set; } = string.Empty;
        public string ClientLastName { get; set; } = string.Empty;
        public List<CarMechanic> CarMechanics { get; set; } = new List<CarMechanic>();
        public override string ToString()
        {
            return $"{ClientId}) {ClientFirstName} {ClientLastName}";
        }
    }
}