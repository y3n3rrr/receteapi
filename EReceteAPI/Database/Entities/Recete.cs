using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EReceteAPI.Database.Entities
{
    [DataContract(IsReference = true)]
    [Serializable()]
    [Table("Recete", Schema = "Muayene")]
    public class Recete : BaseEntity
    {

        [DataMember]
        public DateTime? ReceteTarih { get; set; }

        [DataMember]
        public string ReceteNo { get; set; }

        [DataMember]
        public ReceteTuru? ReceteTuru { get; set; }

        [DataMember]
        public virtual ICollection<Ilac> Ilaclar { get; set; }

    }
}
