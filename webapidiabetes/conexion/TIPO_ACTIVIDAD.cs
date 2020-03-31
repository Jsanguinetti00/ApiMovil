namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class TIPO_ACTIVIDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_ACTIVIDAD()
        {
            CALENDARIO_7PASOS = new HashSet<CALENDARIO_7PASOS>();
        }

        [Key]
        public int ID_TIPO_ACTIVIDAD { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBRE_TIPO_ACTIVIDAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CALENDARIO_7PASOS> CALENDARIO_7PASOS { get; set; }
    }
}
