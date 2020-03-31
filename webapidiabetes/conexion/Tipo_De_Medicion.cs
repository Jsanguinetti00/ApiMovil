namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class Tipo_De_Medicion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_De_Medicion()
        {
            MEDICION_GLUCOSA = new HashSet<MEDICION_GLUCOSA>();
        }

        [Key]
        public int ID_TIPMEDICION { get; set; }

        [Required]
        [StringLength(15)]
        public string NOMBRE_MEDICION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICION_GLUCOSA> MEDICION_GLUCOSA { get; set; }
    }
}
