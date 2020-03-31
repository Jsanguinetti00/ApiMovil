namespace conexion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("USUARIO")]
    [Serializable,DataContract]
    public partial class USUARIO
    {
        [DataMember]
        [Key]
        public int ID_USUARIO { get; set; }
        [DataMember]
        [StringLength(10)]
        public string TELEFONO { get; set; }
        [DataMember]
        [StringLength(30)]
        public string CONTRASENA { get; set; }
        [DataMember]
        public int ID_PERSONA { get; set; }
        [DataMember]
        public int ID_TIPO_USUARIO { get; set; }
        [DataMember]
        public int ID_ESTATUS { get; set; }

        public virtual ESTATUS_USU ESTATUS_USU { get; set; }

        public virtual PERSONAS PERSONAS { get; set; }

        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
