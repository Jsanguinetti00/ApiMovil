namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    public partial class PERSONAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        [DataMember]
        [Key]
        public int ID_PERSONA { get; set; }
        [DataMember]
        public int? EDAD { get; set; }
        [DataMember]
        [StringLength(30)]
        public string NOMBRE { get; set; }
        [DataMember]
        public int ANIOSCONDIABETES { get; set; }
        [DataMember]
        [Required]
        [StringLength(20)]
        public string APELLIDO_PATER { get; set; }
        [DataMember]
        [Required]
        [StringLength(20)]
        public string APELLIDO_MATER { get; set; }
        [DataMember]
        [Column(TypeName = "date")]
        public DateTime FECHA_INICIO { get; set; }
        [DataMember]
        [Required]
        [StringLength(10)]
        public string TELEFONO { get; set; }
        [DataMember]
        [Required]
        [StringLength(50)]
        public string DIRECCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CALENDARIO_7PASOS> CALENDARIO_7PASOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITAS> CITAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONFERENCIAS> CONFERENCIAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUESTIONARIO_CONOCIMIENTOS> CUESTIONARIO_CONOCIMIENTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICION_GLUCOSA> MEDICION_GLUCOSA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESO_TALLA> PESO_TALLA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRUEBA_BECK> PRUEBA_BECK { get; set; }
    }
}
