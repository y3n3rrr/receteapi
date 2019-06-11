using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EReceteAPI.Database
{
    [Serializable()]
    [Table("Users", Schema = "Yetkilendirme")]
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
        public int TesisNumarasi { get; set; }
        public int BransKodu { get; set; }
        public int SertifikaKodu { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedKurumKodu { get; set; }
        public int? UpdatedKurumKodu { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsPasswordChanged { get; set; }
        public bool? IsHekim { get; set; }
        public string SessionId { get; set; }
        public bool IsTestUser { get; set; }
        public int Language { get; set; }
        public string Unvan { get; set; }
        public string UnvanKodu { get; set; }
        public string PasswordResetGuid { get; set; }
        public string RowGuid { get; set; }
        public string UpdatedSessionId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAileHekimi { get; set; }
        public long? CreatedRoleId { get; set; }
        public long? UpdatedRoleId { get; set; }
        public bool? IsHekimInBilgiBankasi { get; set; }
        public string EsaglikEncryptedPassword { get; set; }
        public bool? IsEsaglikEncryptedPasswordGuncel { get; set; }
        public string CepTelefonu { get; set; }
        public string DahiliTelefon { get; set; }
        public string Uyruk { get; set; }
        public int? UyrukKodu { get; set; }
        public int? OdaId { get; set; }
        public bool? MonitorKullanacakMi { get; set; }

        public virtual ICollection<UserInRole> UserInRole { get; set; }
    }
}
