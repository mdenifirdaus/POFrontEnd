namespace POFrontEnd.Models
{
    public class POShipment
    {
        public long Id { get; set; } = 0;
        public long? PoHeaderId { get; set; }
        public string ShipVia { get; set; }
        public string ShipTerms { get; set; }
        public string CreatedBy { get; set; } = "M Deni Firdaus";
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public bool? IsDeleted { get; set; }
    }
}
