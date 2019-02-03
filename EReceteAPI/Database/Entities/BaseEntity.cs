using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EReceteAPI.Database.Entities
{
    public class BaseEntity
    {
        public long ID { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        [MaxLength(36)]
        public string RowGuid { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
    }
}
