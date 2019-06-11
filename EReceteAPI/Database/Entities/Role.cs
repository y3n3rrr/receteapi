using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class Role : IEntity
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IlRequired { get; set; }
        public bool IlceRequired { get; set; }
        public bool KurumRequired { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsShowIlAdmini { get; set; }
        public string SessionId { get; set; }
        public int KurumTurKodu { get; set; }
        public bool ShowHastaArama { get; set; }
        public bool ShowAktifMuayene { get; set; }
        public string Guid { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public bool IsShowIlKoordinatoru { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
    }
}
