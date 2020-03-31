namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class PRUEBA_BECK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRUEBA_BECK()
        {
            PREGUNTAS_PRUEBA = new HashSet<PREGUNTAS_PRUEBA>();
        }

        [Key]
        public int ID_PRUEBA { get; set; }

        public int ID_PERSONA { get; set; }

        public virtual PERSONAS PERSONAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PREGUNTAS_PRUEBA> PREGUNTAS_PRUEBA { get; set; }
    }
}
