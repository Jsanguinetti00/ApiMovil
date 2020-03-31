namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class CUESTIONARIO_CONOCIMIENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUESTIONARIO_CONOCIMIENTOS()
        {
            PREGUNTAS_CUESTIONARIO = new HashSet<PREGUNTAS_CUESTIONARIO>();
        }

        [Key]
        public int ID_CUESTIONARIO { get; set; }

        public int ID_PERSONA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PREGUNTAS_CUESTIONARIO> PREGUNTAS_CUESTIONARIO { get; set; }

        public virtual PERSONAS PERSONAS { get; set; }
    }
}
