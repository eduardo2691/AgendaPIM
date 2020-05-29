using Agenda_Pim.Models;
using NHibernate.Transform;
using System.Data;
using System.Data.Common;
using System.Data.Entity.ModelConfiguration;


namespace Agenda_Pim.ClassMap
{
    public class AuditorioMap : EntityTypeConfiguration<Auditorios>
    {
        public AuditorioMap()
        {

            this.HasKey(m => m.IdAuditorio);

            this.Property(m => m.NomeAuditorio).
                HasMaxLength(50);

            this.Property(m => m.Capacidade);

            this.Property(m => m.ObeservacaoAuditorio)
                 .HasMaxLength(300);             
            
            //this.HasKey(m => m.AgendaAuditorio);

           


            this.ToTable("Auditorios");

            this.Property(m => m.IdAuditorio).HasColumnName("IdAuditorio");

            this.Property(m => m.NomeAuditorio).HasColumnName("NomeAuditorio");

            this.Property(m => m.Capacidade).HasColumnName("Capacidade");            

            this.Property(m => m.ObeservacaoAuditorio).HasColumnName("ObservacaoAuditorio");
            
            //this.Property(m => m.AgendaAuditorio).HasColumnName("AgendaAuditorio");

        }
    }
}
