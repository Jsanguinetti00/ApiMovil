namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    public partial class ELEMENTO_PERMITIDO
    {
        [Key]
        public int ID_ELEMENTO_PERMITIDO { get; set; }

        public int ID_TIPO_USUARIO { get; set; }

        public int ID_ELEMENTOS_PERMISOS { get; set; }

        public virtual ELEMENTOS_PERMISOS ELEMENTOS_PERMISOS { get; set; }

        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
