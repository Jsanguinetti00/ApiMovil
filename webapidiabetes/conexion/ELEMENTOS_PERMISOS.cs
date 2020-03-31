namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class ELEMENTOS_PERMISOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ELEMENTOS_PERMISOS()
        {
            ELEMENTO_PERMITIDO = new HashSet<ELEMENTO_PERMITIDO>();
        }

        [Key]
        public int ID_ELEMENTOS_PERMISOS { get; set; }

        public int ID_ELEMENTOS { get; set; }

        public int ID_PERMISOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELEMENTO_PERMITIDO> ELEMENTO_PERMITIDO { get; set; }

        public virtual ELEMENTOS ELEMENTOS { get; set; }

        public virtual PERMISOS PERMISOS { get; set; }
    }
}
