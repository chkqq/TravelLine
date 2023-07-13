namespace Core.Models
{
    public class CarMechanic
    {
        public int CarMechanicId { get; set; }
        public int CarId { get; set; }
        public Car? Car { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public int RepairCost { get; set; }
        public override string ToString()
        {
            if (Car == null || Client == null) return $"{CarMechanicId}) {RepairCost}";
            return $"{CarMechanicId}) {Car}, {Client} - {RepairCost}";
        }
    }
}