namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class PESO_TALLA
    {
        [Key]
        public int ID_PESO_TALLA { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHA_PESO_TALLA { get; set; }

        public double RESULTADO_PESO { get; set; }

        public double RESULTADO_TALLA { get; set; }

        public int ID_PERSONA { get; set; }

        public virtual PERSONAS PERSONAS { get; set; }
    }
}
