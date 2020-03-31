namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class MODULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MODULOS()
        {
            ELEMENTOS = new HashSet<ELEMENTOS>();
            PERFIL_MODULOS = new HashSet<PERFIL_MODULOS>();
        }

        [Key]
        public int ID_MODULO { get; set; }

        [Required]
        [StringLength(30)]
        public string NOM_MODULO { get; set; }

        [StringLength(100)]
        public string DES_MODULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELEMENTOS> ELEMENTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFIL_MODULOS> PERFIL_MODULOS { get; set; }
    }
}
