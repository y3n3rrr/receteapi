using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class HekimIlac : IEntity
    {
        public long ID { get; set; }
        public long Barkod { get; set; }
        public string Ad { get; set; }
        public int KutuAdedi { get; set; }
        public int KullanimSekli { get; set; }
        public int KullanimSayisi { get; set; }
        public double KullanimDozu { get; set; }
        public int KullanimPeriyodu { get; set; }
        public int KullanimPeriyodBirimi { get; set; }
        public string Aciklama { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public string SessionId { get; set; }
        public bool IsDeleted { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
        public string AtcAdi { get; set; }
        public bool HasGeriOdeme { get; set; }
    }
}
