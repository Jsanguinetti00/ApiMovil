namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class PREGUNTA_C
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PREGUNTA_C()
        {
            PREGUNTAS_CUESTIONARIO = new HashSet<PREGUNTAS_CUESTIONARIO>();
        }

        [Key]
        public int ID_PREGUNTAC { get; set; }

        [Required]
        [StringLength(50)]
        public string PREGUNTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PREGUNTAS_CUESTIONARIO> PREGUNTAS_CUESTIONARIO { get; set; }
    }
}
