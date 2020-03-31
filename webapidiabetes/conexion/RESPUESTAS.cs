namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class RESPUESTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESPUESTAS()
        {
            PREGUNTAS_PRUEBA = new HashSet<PREGUNTAS_PRUEBA>();
        }

        [Key]
        public int ID_RESPUESTA { get; set; }

        [Required]
        [StringLength(75)]
        public string TXTRESPUESTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PREGUNTAS_PRUEBA> PREGUNTAS_PRUEBA { get; set; }
    }
}
