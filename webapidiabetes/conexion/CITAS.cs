namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    public partial class CITAS
    {
        [DataMember]
        [Key]
        public int ID_CITAS { get; set; }
        [DataMember]
        [Required]
        [StringLength(20)]
        public string ASISTENCIA { get; set; }
        [DataMember]
        [Column(TypeName = "date")]
        public DateTime FECHA_CITA { get; set; }
        [DataMember]
        public TimeSpan HORA_CITA { get; set; }
        [DataMember]
        public int ID_DATOSCITA { get; set; }
        [DataMember]
        public int ID_TIPO_CITAS { get; set; }
        [DataMember]
        public int ID_PERSONA { get; set; }

        public virtual DATOS_CITA DATOS_CITA { get; set; }

        public virtual PERSONAS PERSONAS { get; set; }

        public virtual TIPO_CITAS TIPO_CITAS { get; set; }
    }
}
