using System;
using System.Collections.Generic;

namespace EReceteAPI.Database.Entities
{
    public partial class Ilac
    {
        public long Id { get; set; }
        public string Ad { get; set; }
        public long Barkod { get; set; }
        public decimal? Fiyat { get; set; }
        public int? GeriOdeme { get; set; }
        public int? ReceteTuru { get; set; }
        public string FirmaAd { get; set; }
        public bool IsActive { get; set; }
        public string AtcKod { get; set; }
        public string AtcAd { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public bool IsDeleted { get; set; }
        public string SessionId { get; set; }
        public string AdArama { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
        public int? IlacReceteRengi { get; set; }
    }
}
