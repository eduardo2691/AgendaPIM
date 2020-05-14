using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Pim.Models
{
    public class Auditorios
    {
        [Key]
        public int IdAuditorio { get; set; }
        public string NomeAuditorio { get; set; }
        public int Capacidade { get; set; }
        public string ObeservacaoAuditorio { get; set; }
        public List<Agendamento> AgendaAuditorio { get; set; }
    }
}
