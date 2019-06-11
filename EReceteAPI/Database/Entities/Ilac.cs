﻿using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class Ilac : IEntity
    {
        public long ID { get; set; }
        public long Barkod { get; set; }
        public string Adi { get; set; }
        public string EtkinMadde { get; set; }
        public int IlacKullanimYil { get; set; }
        public int IlacKullanimAy { get; set; }
        public long IzlemId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public string SessionId { get; set; }
        public string UpdatedSessionId { get; set; }
        public string RowGuid { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
