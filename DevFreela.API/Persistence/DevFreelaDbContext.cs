using DevFreela.API.Entities;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.API.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }
        public object HasForeignKey { get; private set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Skill>(e =>
                {
                    e.HasKey(s => s.Id); // A coluna Id será a chave primária da tabela Skill.
                });

            builder
                .Entity<UserSkill>(e =>
                {
                    e.HasKey(us => us.Id);

                    e.HasOne(u => u.Skill) // Um UserSkill está ligado a uma skill.
                        .WithMany(u => u.UserSkills) // Uma skill pode estar associada a vários UserSkills.
                        .HasForeignKey(s => s.IdSkill) // A chave estrangeira é IdSkill.
                        .OnDelete(DeleteBehavior.Restrict); // Não apague os UserSkills automaticamente se a Skill for excluída.
                });

            builder // Relaciona os comentários (ProjectComment) com os projetos (Project
                .Entity<ProjectComment>(e =>
                {
                    e.HasKey(p => p.Id);

                    e.HasOne(p => p.Project)
                        .WithMany(p => p.Comments)
                        .HasForeignKey(p => p.IdProject)
                        .OnDelete(DeleteBehavior.Restrict);

                });

            builder // Cada usuário (User) pode ter muitas habilidades (Skills) por meio da tabela intermediária UserSkill.
                .Entity<User>(e =>
                {
                    e.HasKey(u => u.Id);

                    e.HasMany(u => u.Skills)
                        .WithOne(us => us.User)
                        .HasForeignKey(us => us.IdUser)
                        .OnDelete(DeleteBehavior.Restrict);

                });

            builder // Cada projeto (Project) tem um freelancer (FreeLancer) e um cliente (Client).
                    // Usamos Restrict para evitar exclusões automáticas.
                .Entity<Project>(e =>
                {
                    e.HasKey(p => p.Id);

                    e.HasOne(p => p.Freelancer)
                        .WithMany(f => f.FreeLanceProjects)
                        .HasForeignKey(p => p.IdFreeLancer)
                        .OnDelete(DeleteBehavior.Restrict);

                    e.HasOne(p => p.Client)
                        .WithMany(c => c.OwnedProjects)
                        .HasForeignKey(p => p.IdClient)
                        .OnDelete(DeleteBehavior.Restrict);

                });


            base.OnModelCreating(builder);
        }
    }
}
