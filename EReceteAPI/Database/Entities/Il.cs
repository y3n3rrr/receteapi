using System;
using System.Collections.Generic;

namespace EReceteAPI.Database
{
    public partial class Il : IEntity
    {
        public long ID { get; set; }
        public int Kodu { get; set; }
        public string Adi { get; set; }
        public int AlfabetikSira { get; set; }
        public string BolgeAdi { get; set; }
        public string SaglikBolgesi { get; set; }
        public string TuikBolgesi { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }
        public bool IsDeleted { get; set; }
    }
}
