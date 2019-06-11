using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class RaporTuru : IEntity
    {
        public long ID { get; set; }
        public string RaporAdi { get; set; }
        public long RaporId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string RoleGuid { get; set; }
    }
}
