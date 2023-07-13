using System;

namespace Core.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; } = string.Empty;
        public int HorsePower { get; set; }
        public string TypeOfRepair { get; set; } = string.Empty;
        public List<CarMechanic> CarMechanics { get; set; } = new List<CarMechanic>();
        public override string ToString()
        {
            return $"{CarId}) {CarName} {HorsePower} - {TypeOfRepair}";
        }
    }
}