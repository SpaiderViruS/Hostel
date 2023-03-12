using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hostel.Models
{
    public partial class db_hostelContext : DbContext
    {
        public static db_hostelContext DbContext { get; private set; }
        static db_hostelContext() => DbContext = new db_hostelContext();

        public db_hostelContext()
        {
        }

        public db_hostelContext(DbContextOptions<db_hostelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user=root;database=db_hostel;password=1234", x => x.ServerVersion("8.0.30-mysql")).UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.IdCommentary)
                    .HasName("PRIMARY");

                entity.ToTable("comments");

                entity.HasIndex(e => e.IdRoom)
                    .HasName("comments_ibfk_2");

                entity.HasIndex(e => e.IdUser)
                    .HasName("comments_ibfk_1");

                entity.Property(e => e.IdCommentary).HasColumnName("idCommentary");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.IdRoom).HasColumnName("idRoom");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.HasOne(d => d.IdRoomNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdRoom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("comments_ibfk_2");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("comments_ibfk_1");
            });

            modelBuilder.Entity<Reservations>(entity =>
            {
                entity.HasKey(e => e.IdReservation)
                    .HasName("PRIMARY");

                entity.ToTable("reservations");

                entity.HasIndex(e => e.IdRoom)
                    .HasName("idRoom");

                entity.HasIndex(e => e.IdStatusReservation)
                    .HasName("fk_res_status_idx");

                entity.HasIndex(e => e.IdUser)
                    .HasName("idUser");

                entity.Property(e => e.IdReservation).HasColumnName("idReservation");

                entity.Property(e => e.IdRoom).HasColumnName("idRoom");

                entity.Property(e => e.IdStatusReservation).HasColumnName("idStatusReservation");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.SettlementDate).HasColumnType("date");

                entity.HasOne(d => d.IdRoomNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.IdRoom)
                    .HasConstraintName("reservations_ibfk_2");

                entity.HasOne(d => d.IdStatusReservationNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.IdStatusReservation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_res_status");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("reservations_ibfk_1");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PRIMARY");

                entity.ToTable("roles");

                entity.Property(e => e.IdRole).HasColumnName("idRole");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.HasKey(e => e.IdRoom)
                    .HasName("PRIMARY");

                entity.ToTable("rooms");

                entity.HasIndex(e => e.IdStatus)
                    .HasName("FK_Room_Statuses_idx");

                entity.Property(e => e.IdRoom).HasColumnName("idRoom");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.Image)
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rooms_staus");
            });

            modelBuilder.Entity<Statuses>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PRIMARY");

                entity.ToTable("statuses");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.HasIndex(e => e.IdRole)
                    .HasName("users_ibfk_1");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.IdRole).HasColumnName("idRole");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Patronomyc)
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Surname)
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
