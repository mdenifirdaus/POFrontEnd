namespace POFrontEnd.Models
{
    public class POHeader
    {
        public long Id { get; set; } = 0;
        public string NoPo { get; set; }
        public DateTime? Tanggal { get; set; } = DateTime.Now;
        public string PerusahaanTujuan { get; set; }
        public string AlamatPerusahaan { get; set; }
        public string NoTelp { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public decimal? Subtotal { get; set; } = 0;
        public decimal? Diskon { get; set; } = 0;
        public decimal? Ppn { get; set; } = 0;
        public decimal? Total { get; set; }= 0;
        public string CatatanTambahan { get; set; }
        public string Nama { get; set; }
        public string Jabatan { get; set; }
        public string CreatedBy { get; set; } = "M Deni Firdaus";
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public bool? IsDeleted { get; set; }
    }
}
