namespace POFrontEnd.Models
{
    public class CustomerModels
    {
        public long Id { get; set; } = 0;
        public long? PoHeaderId { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string CreatedBy { get; set; } = "M Deni Firdaus";
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public bool? IsDeleted { get; set; }
    }
}
