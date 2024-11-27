
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Models;

namespace ReservationSystem.Data;

public class ReservationContext : IdentityDbContext<ApplicationUser>
{
    public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
    {
    }

    public DbSet<Reservation> Reservations {get; set;}
    public DbSet<SportObject> SportObjects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Reservation>().ToTable("Reservation");
        modelBuilder.Entity<SportObject>().ToTable("SportObject");
    }
}