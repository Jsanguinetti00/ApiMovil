namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class CONFERENCIAS
    {
        [Key]
        public int ID_CONFERENCIAS { get; set; }

        [Required]
        [StringLength(20)]
        public string ASISTENCIA { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHA_CONFERENCIAS { get; set; }

        public TimeSpan HORA_CONFERENCIAS { get; set; }

        public int ID_PERSONA { get; set; }

        public int ID_NOMCONFERENCIA { get; set; }

        public virtual NOM_CONFERENCIA NOM_CONFERENCIA { get; set; }

        public virtual PERSONAS PERSONAS { get; set; }
    }
}
