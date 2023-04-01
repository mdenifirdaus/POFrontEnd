namespace POFrontEnd.Models
{
    public class POHeader
    {
        //public long Id { get; set; }
        public string NoPo { get; set; }
        public DateTime? Tanggal { get; set; }
        public string PerusahaanTujuan { get; set; }
        public string AlamatPerusahaan { get; set; }
        public string NoTelp { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Diskon { get; set; }
        public decimal? Ppn { get; set; }
        public decimal? Total { get; set; }
        public string CatatanTambahan { get; set; }
        public string Nama { get; set; }
        public string Jabatan { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public PODetail PODetail { get; set; }
    }
}
