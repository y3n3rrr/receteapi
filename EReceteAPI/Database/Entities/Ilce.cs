using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class Ilce : IEntity
    {
        public long ID { get; set; }
        public int Kodu { get; set; }
        public int IlKodu { get; set; }
        public string UzunAdi { get; set; }
        public string IlAdi { get; set; }
        public string Adi { get; set; }
        public int MetaAlfabetikSira { get; set; }
        public int MetaDimIlceKey { get; set; }
        public bool IsDeleted { get; set; }
    }
}
