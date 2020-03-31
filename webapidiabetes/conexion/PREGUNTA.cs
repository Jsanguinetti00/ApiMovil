namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    [Table("PREGUNTA")]
    public partial class PREGUNTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PREGUNTA()
        {
            PREGUNTAS_PRUEBA = new HashSet<PREGUNTAS_PRUEBA>();
        }

        [Key]
        public int ID_PREGUNTA { get; set; }

        [Required]
        [StringLength(70)]
        public string TXTPREGUNTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PREGUNTAS_PRUEBA> PREGUNTAS_PRUEBA { get; set; }
    }
}
