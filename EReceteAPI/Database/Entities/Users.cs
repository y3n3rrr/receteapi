using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EReceteAPI.Database.Entities
{

    public partial class Users : IEntity
    {
        public long ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long TckimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DiplomaNo { get; set; }
        public string Email { get; set; }
        public string EsaglikPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Sgksifresi { get; set; }
        public string MernisSifresi { get; set; }
        public string CepTelefonu { get; set; }
    }
}
