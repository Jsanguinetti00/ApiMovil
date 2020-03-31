namespace conexion
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbDiabetes : DbContext
    {
        public dbDiabetes()
            : base("name=diabetes")
        {
        }

        public virtual DbSet<CALENDARIO_7PASOS> CALENDARIO_7PASOS { get; set; }
        public virtual DbSet<CITAS> CITAS { get; set; }
        public virtual DbSet<CONFERENCIAS> CONFERENCIAS { get; set; }
        public virtual DbSet<CUESTIONARIO_CONOCIMIENTOS> CUESTIONARIO_CONOCIMIENTOS { get; set; }
        public virtual DbSet<DATOS_CITA> DATOS_CITA { get; set; }
        public virtual DbSet<ELEMENTO_PERMITIDO> ELEMENTO_PERMITIDO { get; set; }
        public virtual DbSet<ELEMENTOS> ELEMENTOS { get; set; }
        public virtual DbSet<ELEMENTOS_PERMISOS> ELEMENTOS_PERMISOS { get; set; }
        public virtual DbSet<ESPECIALISTA> ESPECIALISTA { get; set; }
        public virtual DbSet<ESTATUS_USU> ESTATUS_USU { get; set; }
        public virtual DbSet<MEDICION_GLUCOSA> MEDICION_GLUCOSA { get; set; }
        public virtual DbSet<MODULOS> MODULOS { get; set; }
        public virtual DbSet<NOM_CONFERENCIA> NOM_CONFERENCIA { get; set; }
        public virtual DbSet<PERFIL_MODULOS> PERFIL_MODULOS { get; set; }
        public virtual DbSet<PERMISOS> PERMISOS { get; set; }
        public virtual DbSet<PERSONAS> PERSONAS { get; set; }
        public virtual DbSet<PESO_TALLA> PESO_TALLA { get; set; }
        public virtual DbSet<PREGUNTA> PREGUNTA { get; set; }
        public virtual DbSet<PREGUNTA_C> PREGUNTA_C { get; set; }
        public virtual DbSet<PREGUNTAS_CUESTIONARIO> PREGUNTAS_CUESTIONARIO { get; set; }
        public virtual DbSet<PREGUNTAS_PRUEBA> PREGUNTAS_PRUEBA { get; set; }
        public virtual DbSet<PRUEBA_BECK> PRUEBA_BECK { get; set; }
        public virtual DbSet<RESPUESTA_C> RESPUESTA_C { get; set; }
        public virtual DbSet<RESPUESTAS> RESPUESTAS { get; set; }
        public virtual DbSet<TIPO_ACTIVIDAD> TIPO_ACTIVIDAD { get; set; }
        public virtual DbSet<TIPO_CITAS> TIPO_CITAS { get; set; }
        public virtual DbSet<Tipo_De_Medicion> Tipo_De_Medicion { get; set; }
        public virtual DbSet<TIPO_ESPECIALISTA> TIPO_ESPECIALISTA { get; set; }
        public virtual DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CALENDARIO_7PASOS>()
                .Property(e => e.ASISTENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<CITAS>()
                .Property(e => e.ASISTENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<CONFERENCIAS>()
                .Property(e => e.ASISTENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<CUESTIONARIO_CONOCIMIENTOS>()
                .HasMany(e => e.PREGUNTAS_CUESTIONARIO)
                .WithRequired(e => e.CUESTIONARIO_CONOCIMIENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DATOS_CITA>()
                .Property(e => e.CONSULTORIO)
                .IsUnicode(false);

            modelBuilder.Entity<DATOS_CITA>()
                .HasMany(e => e.CITAS)
                .WithRequired(e => e.DATOS_CITA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ELEMENTOS>()
                .Property(e => e.NOM_ELEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ELEMENTOS>()
                .HasMany(e => e.ELEMENTOS_PERMISOS)
                .WithRequired(e => e.ELEMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ELEMENTOS_PERMISOS>()
                .HasMany(e => e.ELEMENTO_PERMITIDO)
                .WithRequired(e => e.ELEMENTOS_PERMISOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESPECIALISTA>()
                .Property(e => e.NOMBRE_ESP)
                .IsUnicode(false);

            modelBuilder.Entity<ESPECIALISTA>()
                .Property(e => e.APELLIDOP_ESP)
                .IsUnicode(false);

            modelBuilder.Entity<ESPECIALISTA>()
                .Property(e => e.APELLIDOM_ESP)
                .IsUnicode(false);

            modelBuilder.Entity<ESPECIALISTA>()
                .HasMany(e => e.DATOS_CITA)
                .WithRequired(e => e.ESPECIALISTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTATUS_USU>()
                .Property(e => e.NOM_ESTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ESTATUS_USU>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.ESTATUS_USU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MODULOS>()
                .Property(e => e.NOM_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<MODULOS>()
                .Property(e => e.DES_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<MODULOS>()
                .HasMany(e => e.ELEMENTOS)
                .WithRequired(e => e.MODULOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MODULOS>()
                .HasMany(e => e.PERFIL_MODULOS)
                .WithRequired(e => e.MODULOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOM_CONFERENCIA>()
                .Property(e => e.NOMBRE_CONF)
                .IsUnicode(false);

            modelBuilder.Entity<NOM_CONFERENCIA>()
                .HasMany(e => e.CONFERENCIAS)
                .WithRequired(e => e.NOM_CONFERENCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERMISOS>()
                .Property(e => e.NOM_PERMISOS)
                .IsUnicode(false);

            modelBuilder.Entity<PERMISOS>()
                .HasMany(e => e.ELEMENTOS_PERMISOS)
                .WithRequired(e => e.PERMISOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONAS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAS>()
                .Property(e => e.APELLIDO_PATER)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAS>()
                .Property(e => e.APELLIDO_MATER)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAS>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAS>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAS>()
                .HasMany(e => e.CALENDARIO_7PASOS)
                .WithRequired(e => e.PERSONAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONAS>()
                .HasMany(e => e.CITAS)
                .WithRequired(e => e.PERSONAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONAS>()
                .HasMany(e => e.CONFERENCIAS)
                .WithRequired(e => e.PERSONAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONAS>()
                .HasMany(e => e.CUESTIONARIO_CONOCIMIENTOS)
                .WithRequired(e => e.PERSONAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONAS>()
                .HasMany(e => e.MEDICION_GLUCOSA)
                .WithRequired(e => e.PERSONAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONAS>()
                .HasMany(e => e.PESO_TALLA)
                .WithRequired(e => e.PERSONAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONAS>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.PERSONAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERSONAS>()
                .HasMany(e => e.PRUEBA_BECK)
                .WithRequired(e => e.PERSONAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PREGUNTA>()
                .Property(e => e.TXTPREGUNTA)
                .IsUnicode(false);

            modelBuilder.Entity<PREGUNTA>()
                .HasMany(e => e.PREGUNTAS_PRUEBA)
                .WithRequired(e => e.PREGUNTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PREGUNTA_C>()
                .Property(e => e.PREGUNTA)
                .IsUnicode(false);

            modelBuilder.Entity<PREGUNTA_C>()
                .HasMany(e => e.PREGUNTAS_CUESTIONARIO)
                .WithRequired(e => e.PREGUNTA_C)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRUEBA_BECK>()
                .HasMany(e => e.PREGUNTAS_PRUEBA)
                .WithRequired(e => e.PRUEBA_BECK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESPUESTA_C>()
                .Property(e => e.NOM_RESPUESTA)
                .IsUnicode(false);

            modelBuilder.Entity<RESPUESTA_C>()
                .HasMany(e => e.PREGUNTAS_CUESTIONARIO)
                .WithRequired(e => e.RESPUESTA_C)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESPUESTAS>()
                .Property(e => e.TXTRESPUESTA)
                .IsUnicode(false);

            modelBuilder.Entity<RESPUESTAS>()
                .HasMany(e => e.PREGUNTAS_PRUEBA)
                .WithRequired(e => e.RESPUESTAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_ACTIVIDAD>()
                .Property(e => e.NOMBRE_TIPO_ACTIVIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ACTIVIDAD>()
                .HasMany(e => e.CALENDARIO_7PASOS)
                .WithRequired(e => e.TIPO_ACTIVIDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_CITAS>()
                .Property(e => e.NIOMBRE_TIPO_CITAS)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_CITAS>()
                .HasMany(e => e.CITAS)
                .WithRequired(e => e.TIPO_CITAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_De_Medicion>()
                .Property(e => e.NOMBRE_MEDICION)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_De_Medicion>()
                .HasMany(e => e.MEDICION_GLUCOSA)
                .WithRequired(e => e.Tipo_De_Medicion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_ESPECIALISTA>()
                .Property(e => e.NOM_TIPOESPECIALISTA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ESPECIALISTA>()
                .HasMany(e => e.ESPECIALISTA)
                .WithRequired(e => e.TIPO_ESPECIALISTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_USUARIO>()
                .Property(e => e.NOMBRE_TIPO_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_USUARIO>()
                .HasMany(e => e.ELEMENTO_PERMITIDO)
                .WithRequired(e => e.TIPO_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_USUARIO>()
                .HasMany(e => e.PERFIL_MODULOS)
                .WithRequired(e => e.TIPO_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_USUARIO>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.TIPO_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.CONTRASENA)
                .IsUnicode(false);
        }
    }
}
