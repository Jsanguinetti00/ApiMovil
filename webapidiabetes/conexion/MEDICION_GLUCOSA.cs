namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class MEDICION_GLUCOSA
    {
        [Key]
        public int ID_MEDICION_GLUCOSA { get; set; }

        public int PRIMERA_MEDICION { get; set; }
        [DataType(DataType.Date)]
        public DateTime FECHA_MEDICION_GLUCOSA { get; set; }

        public TimeSpan HORA_MEDICION_GLUCOSA { get; set; }

        public double RESULTADO_MEDICION_GLUCOSA { get; set; }

        public int ID_TIPMEDICION { get; set; }

        public int ID_PERSONA { get; set; }

        public virtual PERSONAS PERSONAS { get; set; }

        public virtual Tipo_De_Medicion Tipo_De_Medicion { get; set; }
    }
}
