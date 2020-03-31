namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    public partial class DATOS_CITA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DATOS_CITA()
        {
            CITAS = new HashSet<CITAS>();
        }
        [DataMember]
        [Key]
        public int ID_DATOSCITA { get; set; }
        [DataMember]
        [Required]
        [StringLength(50)]
        public string CONSULTORIO { get; set; }
        [DataMember]
        public int ID_ESPECIALISTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITAS> CITAS { get; set; }

        public virtual ESPECIALISTA ESPECIALISTA { get; set; }
    }
}
