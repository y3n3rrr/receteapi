using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class IlacKullanimSekli : IEntity
    {
        public long ID { get; set; }
        public bool IsActive { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public bool IsDeleted { get; set; }
        public string SessionId { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
    }
}
