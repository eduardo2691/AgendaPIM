using Agenda_Pim.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;


namespace Agenda_Pim.ClassMap
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {

            this.HasKey(m => m.IdUsuario);

            this.Property(m => m.Nome)
                .HasMaxLength(50);

            this.Property(m => m.Email)
                .HasMaxLength(50);

            this.Property(m => m.Senha)
                .HasMaxLength(30);

            //tem no banco ?
            //this.Property(m => m.agendamentosUsuario);   

            this.Property(m => m.TipoUsuario);

            


            this.ToTable("Usuarios");

            this.Property(m => m.IdUsuario).HasColumnName("IdUsuario");

            this.Property(m => m.Nome).HasColumnName("Nome");

            this.Property(m => m.Email).HasColumnName("Email");

            this.Property(m => m.Senha).HasColumnName("Senha");

            // tem no banco ?
            //this.Property(m => m.agendamentosUsuario).HasColumnName("AgendaUsuario");

            this.Property<bool>(m => m.TipoUsuario).HasColumnName("TipoUsuario");
                        
        }
    }
}
