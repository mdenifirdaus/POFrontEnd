namespace POFrontEnd.Models
{
    public class POShipment
    {
        //public long Id { get; set; }
        public long? PoHeaderId { get; set; }
        public string ShipVia { get; set; }
        public string ShipTerms { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
