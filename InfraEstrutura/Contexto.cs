using Entidades;
using Microsoft.EntityFrameworkCore;
using System;

public class Contexto: DbContext
{
    public Contexto(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Usuarios> Usuarios { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server = localhost, 1433; Database=DietDay;User ID = sa; Password=Gabriel@2018#");
   
}
