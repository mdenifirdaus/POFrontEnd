namespace POFrontEnd.Models
{
    public class PODetail
    {
        //public long Id { get; set; }
        public long? PoHeaderId { get; set; }
        public int? No { get; set; }
        public string Keterangan { get; set; }
        public string Unit { get; set; }
        public int? Qty { get; set; }
        public decimal? HargaUnit { get; set; }
        public decimal? Total { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
