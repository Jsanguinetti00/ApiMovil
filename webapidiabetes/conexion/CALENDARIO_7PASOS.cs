namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    public partial class CALENDARIO_7PASOS
    {
        [DataMember]
        [Key]
        public int ID_CALENDARIO_7PASOS { get; set; }
        [DataMember]
        [Required]
        [StringLength(20)]
        public string ASISTENCIA { get; set; }
        [DataMember]
        public TimeSpan HORA_CALEDARIO { get; set; }
        [DataMember]
        public DateTime FECHA_CALENDARIO_7PASOS { get; set; }
        [DataMember]
        public int ID_TIPO_ACTIVIDAD { get; set; }
        [DataMember]
        public int ID_PERSONA { get; set; }

        public virtual PERSONAS PERSONAS { get; set; }

        public virtual TIPO_ACTIVIDAD TIPO_ACTIVIDAD { get; set; }
    }
}
