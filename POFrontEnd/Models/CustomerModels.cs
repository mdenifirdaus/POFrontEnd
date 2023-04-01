namespace POFrontEnd.Models
{
    public class CustomerModels
    {
        //public long Id { get; set; }
        public long? PoHeaderId { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
