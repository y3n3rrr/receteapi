using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class UserInRole : IEntity
    {
        public long ID { get; set; }
        public long RoleId { get; set; }
        public long UserId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public bool IsDeleted { get; set; }
        public int? DaireBaskanligiId { get; set; }
        public int? BirimId { get; set; }
        public string SessionId { get; set; }
        public int? KurumKodu { get; set; }
        public int? IlKodu { get; set; }
        public int? IlceKodu { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public int? BolgeId { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
        public int? GorevTipi { get; set; }

        public virtual Users User { get; set; }
    }
}
