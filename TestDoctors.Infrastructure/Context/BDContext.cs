using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestDoctors.Domain.Dbo;


namespace TestDoctors.Infrastructure.Context;

public class BDContext : DbContext
{
    public DbSet<Disease> Diseases {  get; set; }

    public DbSet<Doctor> Doctors { get; set; }
    
    public DbSet<Patient> Patients { get; set; }

    public BDContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
