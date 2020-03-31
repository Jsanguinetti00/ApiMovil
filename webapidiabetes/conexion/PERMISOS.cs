namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class PERMISOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERMISOS()
        {
            ELEMENTOS_PERMISOS = new HashSet<ELEMENTOS_PERMISOS>();
        }

        [Key]
        public int ID_PERMISOS { get; set; }

        [Required]
        [StringLength(30)]
        public string NOM_PERMISOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELEMENTOS_PERMISOS> ELEMENTOS_PERMISOS { get; set; }
    }
}
