using Agenda_Pim.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Pim.ClassMap
{
    public class AgendamentoMap : EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoMap()
        {

            this.HasKey(m => m.IdAgendamento);

            this.Property(m => m.HorarioInicial);

            this.Property(m => m.HorarioFinal);

            this.Property(m => m.IdAuditorio.ToString());

            this.Property(m => m.DescricaoEvento)
                .HasMaxLength(300);

            this.Property(m => m.Proprietario);

            this.Property(m => m.IdUsuario.ToString());

            this.Property(m => m.ObservacaoAgendamento)
                .HasMaxLength(300);



            this.ToTable("Agendamentos");

            this.Property(m => m.IdAgendamento).HasColumnName("IdAgendamento");

            this.Property(m => m.HorarioInicial).HasColumnName("HorarioInicial");

            this.Property(m => m.HorarioFinal).HasColumnName("HorarioFinal");

            this.Property(m => m.IdAuditorio.ToString()).HasColumnName("IdAuditorio1");

            this.Property(m => m.DescricaoEvento).HasColumnName("DescricaoEvento");

            this.Property(m => m.Proprietario).HasColumnName("Proprietario");

            this.Property(m => m.IdUsuario.ToString()).HasColumnName("IdUsuario1");

            this.Property(m => m.ObservacaoAgendamento).HasColumnName("ObservacaoAgendamento");

        }
    }
}
