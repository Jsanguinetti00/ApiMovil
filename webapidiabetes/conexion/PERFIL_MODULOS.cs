namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERFIL_MODULOS
    {
        [Key]
        public int ID_PERFIL_MODULOS { get; set; }

        public int ID_TIPO_USUARIO { get; set; }

        public int ID_MODULO { get; set; }

        public virtual MODULOS MODULOS { get; set; }

        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
