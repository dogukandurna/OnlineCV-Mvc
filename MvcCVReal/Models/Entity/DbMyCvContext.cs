using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MvcCVReal.Models.Entity;

public partial class DbMyCvContext : DbContext
{
    public DbMyCvContext()
    {
    }

    public DbMyCvContext(DbContextOptions<DbMyCvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAbout> TblAbouts { get; set; }

    public virtual DbSet<TblAdmin> TblAdmins { get; set; }

    public virtual DbSet<TblCertification> TblCertifications { get; set; }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    public virtual DbSet<TblEducation> TblEducations { get; set; }

    public virtual DbSet<TblExperience> TblExperiences { get; set; }

    public virtual DbSet<TblHobby> TblHobbies { get; set; }

    public virtual DbSet<TblSkill> TblSkills { get; set; }

    public virtual DbSet<TblSocialMediaAcc> TblSocialMediaAccs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DGKN\\SQLEXPRESS;Database=DbMyCV;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAbout>(entity =>
        {
            entity.ToTable("Tbl_About");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Adres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Açıklama).IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Resim)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Soyad)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAdmin>(entity =>
        {
            entity.ToTable("Tbl_Admin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KullaniciAd)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.KullaniciSifre)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCertification>(entity =>
        {
            entity.ToTable("Tbl_Certification");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SertifikaAd)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.ToTable("Tbl_Contact");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GönderenAdSoyad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GönderenMail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GönderenMesaj)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.GönderenMesajKonu)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GönderimTarih).HasColumnType("date");
        });

        modelBuilder.Entity<TblEducation>(entity =>
        {
            entity.ToTable("Tbl_Education");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OkulAdı)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OkulTür)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ortalama)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarih)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ünvan)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblExperience>(entity =>
        {
            entity.ToTable("Tbl_Experience");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).IsUnicode(false);
            entity.Property(e => e.Tarih)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ünvan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.İşYeriAdı)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblHobby>(entity =>
        {
            entity.ToTable("Tbl_Hobby");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Aciklama2)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSkill>(entity =>
        {
            entity.ToTable("Tbl_Skill");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Yetenekler)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSocialMediaAcc>(entity =>
        {
            entity.ToTable("Tbl_SocialMediaAcc");

            entity.Property(e => e.SosyalMedyaIkon)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SosyalMedyaIsim)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SosyalMedyaUrl)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
