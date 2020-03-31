namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    [Table("ESPECIALISTA")]
    public partial class ESPECIALISTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESPECIALISTA()
        {
            DATOS_CITA = new HashSet<DATOS_CITA>();
        }
        [DataMember]
        [Key]
        public int ID_ESPECIALISTA { get; set; }
        [DataMember]
        [Required]
        [StringLength(50)]
        public string NOMBRE_ESP { get; set; }
        [DataMember]
        [Required]
        [StringLength(30)]
        public string APELLIDOP_ESP { get; set; }
        [DataMember]
        [Required]
        [StringLength(30)]
        public string APELLIDOM_ESP { get; set; }
        [DataMember]
        public int ID_TIPOESP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATOS_CITA> DATOS_CITA { get; set; }

        public virtual TIPO_ESPECIALISTA TIPO_ESPECIALISTA { get; set; }
    }
}
