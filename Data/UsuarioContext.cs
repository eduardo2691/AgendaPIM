using Agenda_Pim.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Pim.Data
{
    public class UsuarioContext: DbContext
    {
        public DbSet<Usuario> Usuarios  { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Auditorios> Auditorios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=1234;Persist Security Info=True;User ID=sa;Initial " +
                                         "Catalog=AgendaPim;Data " +
                                        "Source=LAPTOP-91SB1VL3\\SQLEXPRESS");
        }
    }
}
