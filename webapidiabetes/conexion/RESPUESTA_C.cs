namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class RESPUESTA_C
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESPUESTA_C()
        {
            PREGUNTAS_CUESTIONARIO = new HashSet<PREGUNTAS_CUESTIONARIO>();
        }

        [Key]
        public int ID_RESPUESTAC { get; set; }

        [Required]
        [StringLength(75)]
        public string NOM_RESPUESTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PREGUNTAS_CUESTIONARIO> PREGUNTAS_CUESTIONARIO { get; set; }
    }
}
