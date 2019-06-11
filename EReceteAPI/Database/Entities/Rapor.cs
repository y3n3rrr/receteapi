using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class Rapor : IEntity
    {
        public long ID { get; set; }
        public string HastaTc { get; set; }
        public string HekimTc { get; set; }
        public string HastaGuid { get; set; }
        public long MuayeneId { get; set; }
        public int Turu { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Numarasi { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public string TakipNumarasi { get; set; }
        public byte[] Pdfbilgisi { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public string SessionId { get; set; }
        public bool IsDeleted { get; set; }
        public string Aciklama { get; set; }
        public DateTime? RaporTarihi { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
        public bool? IsHastaOgrenci { get; set; }

    }
}
