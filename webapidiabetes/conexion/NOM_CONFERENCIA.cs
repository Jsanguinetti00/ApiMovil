namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class NOM_CONFERENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOM_CONFERENCIA()
        {
            CONFERENCIAS = new HashSet<CONFERENCIAS>();
        }

        [Key]
        public int ID_NOMCONFERENCIA { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE_CONF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONFERENCIAS> CONFERENCIAS { get; set; }
    }
}
