﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace EReceteAPI.Database
{
    [DataContract(IsReference = true)]
    [Serializable()]
    [Table("Recete", Schema = "Muayene")]
    public partial class Recete : IEntity
    {
        public long ID { get; set; }
        public DateTime? ReceteTarih { get; set; }
        public string ReceteNo { get; set; }
        public int? ReceteTuru { get; set; }
        public long? MuayeneId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public bool IsDeleted { get; set; }
        public string SessionId { get; set; }
        public long HastaIslemId { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
    }
}
