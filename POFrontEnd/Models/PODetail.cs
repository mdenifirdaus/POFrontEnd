namespace POFrontEnd.Models
{
    public class PODetail
    {
        public long Id { get; set; } = 0;
        public long? PoHeaderId { get; set; }
        public int? No { get; set; }
        public string Keterangan { get; set; }
        public string Unit { get; set; }
        public int? Qty { get; set; }
        public decimal? HargaUnit { get; set; }
        public decimal? Total { get; set; }
        public string CreatedBy { get; set; } = "M Deni Firdaus";
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public bool? IsDeleted { get; set; }

    }
}
