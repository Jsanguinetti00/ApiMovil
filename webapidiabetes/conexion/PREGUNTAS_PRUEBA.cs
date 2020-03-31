namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class PREGUNTAS_PRUEBA
    {
        [Key]
        public int ID_PREGUNTASBECK { get; set; }

        public int ID_PREGUNTA { get; set; }

        public int ID_PRUEBA { get; set; }

        public int ID_RESPUESTA { get; set; }

        public virtual PREGUNTA PREGUNTA { get; set; }

        public virtual PRUEBA_BECK PRUEBA_BECK { get; set; }

        public virtual RESPUESTAS RESPUESTAS { get; set; }
    }
}
