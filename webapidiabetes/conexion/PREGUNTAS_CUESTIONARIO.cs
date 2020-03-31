namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class PREGUNTAS_CUESTIONARIO
    {
        [Key]
        public int ID_CUESPREGUNTA { get; set; }

        public int ID_RESPUESTAC { get; set; }

        public int ID_PREGUNTAC { get; set; }

        public int ID_CUESTIONARIO { get; set; }

        public virtual CUESTIONARIO_CONOCIMIENTOS CUESTIONARIO_CONOCIMIENTOS { get; set; }

        public virtual PREGUNTA_C PREGUNTA_C { get; set; }

        public virtual RESPUESTA_C RESPUESTA_C { get; set; }
    }
}
