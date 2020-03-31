namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    public partial class TIPO_ESPECIALISTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_ESPECIALISTA()
        {
            ESPECIALISTA = new HashSet<ESPECIALISTA>();
        }
        [DataMember]
        [Key]
        public int ID_TIPOESP { get; set; }
        [DataMember]
        [Required]
        [StringLength(15)]
        public string NOM_TIPOESPECIALISTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESPECIALISTA> ESPECIALISTA { get; set; }
    }
}
