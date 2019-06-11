using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class ReceteLog : IEntity
    {
        public long ID { get; set; }
        public long MuayeneId { get; set; }
        public string HekimTc { get; set; }
        public string ReceteXml { get; set; }
        public byte[] ReceteBinary { get; set; }
        public string ResultXml { get; set; }
        public string ResultMessage { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public bool IsDeleted { get; set; }
        public bool ResultState { get; set; }
        public bool IsGonderim { get; set; }
        public string SessionId { get; set; }
        public bool IsImzali { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
    }
}
