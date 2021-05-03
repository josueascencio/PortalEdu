﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalEDU.AccesoDatos.Data;

namespace PortalEDU.AccesoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210503055828_CreationApplicationUser")]
    partial class CreationApplicationUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PortalEDU.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carnet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCalificaciones")
                        .HasColumnType("int");

                    b.Property<int>("IdCentroEducativo")
                        .HasColumnType("int");

                    b.Property<int?>("IdResponsable")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("update")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCalificaciones");

                    b.HasIndex("IdCentroEducativo");

                    b.HasIndex("IdResponsable");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("PortalEDU.Models.AlumnoCurso", b =>
                {
                    b.Property<int>("IdAlumnoCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdAlumno")
                        .HasColumnType("int");

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAlumnoCurso");

                    b.HasIndex("IdAlumno");

                    b.HasIndex("IdCurso");

                    b.ToTable("AlumnoCurso");
                });

            modelBuilder.Entity("PortalEDU.Models.Aula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCentroEducativo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCentroEducativo");

                    b.ToTable("Aula");
                });

            modelBuilder.Entity("PortalEDU.Models.Calificaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("CuartoTrimestre")
                        .HasColumnType("decimal (18,4)");

                    b.Property<int>("IdAlumno")
                        .HasColumnType("int");

                    b.Property<decimal?>("PrimerTrimestre")
                        .HasColumnType("decimal (18,4)");

                    b.Property<decimal?>("Promedio")
                        .HasColumnType("decimal (18,4)");

                    b.Property<decimal?>("SegundoTrimestre")
                        .HasColumnType("decimal (18,4)");

                    b.Property<decimal?>("TercerTrimestre")
                        .HasColumnType("decimal (18,4)");

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdAlumno")
                        .IsUnique();

                    b.ToTable("Calificaciones");
                });

            modelBuilder.Entity("PortalEDU.Models.CentroEducativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAnioAcademico")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdAnioAcademico");

                    b.ToTable("CentroEducativo");
                });

            modelBuilder.Entity("PortalEDU.Models.Ciclo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnioAcademico")
                        .HasColumnType("int");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ciclo");
                });

            modelBuilder.Entity("PortalEDU.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAula")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdAula");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("PortalEDU.Models.Docente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GradoAcademico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCentroEducativo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCentroEducativo");

                    b.ToTable("Docente");
                });

            modelBuilder.Entity("PortalEDU.Models.DocenteCurso", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdCursoNavigationId")
                        .HasColumnType("int");

                    b.Property<int>("IdDocente")
                        .HasColumnType("int");

                    b.Property<int?>("IdDocenteNavigationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCurso");

                    b.HasIndex("IdCursoNavigationId");

                    b.HasIndex("IdDocenteNavigationId");

                    b.ToTable("DocenteCurso");
                });

            modelBuilder.Entity("PortalEDU.Models.Responsable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonoTrabajo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Responsable");
                });

            modelBuilder.Entity("PortalEDU.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdDocente")
                        .HasColumnType("int");

                    b.Property<int?>("IdResponsable")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdDocente");

                    b.HasIndex("IdResponsable");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("PortalEDU.Models.SalaComentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSala")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdSala");

                    b.ToTable("SalaComentario");
                });

            modelBuilder.Entity("PortalEDU.Models.TareaAlumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comnetario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAlumno")
                        .HasColumnType("int");

                    b.Property<int>("IdTareaDocente")
                        .HasColumnType("int");

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdAlumno");

                    b.HasIndex("IdTareaDocente");

                    b.ToTable("TareaAlumno");
                });

            modelBuilder.Entity("PortalEDU.Models.TareaDocente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCurso")
                        .HasColumnType("int");

                    b.Property<int?>("IdDocente")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Puntuacion")
                        .HasColumnType("int");

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCurso");

                    b.HasIndex("IdDocente");

                    b.ToTable("TareaDocente");
                });

            modelBuilder.Entity("PortalEDU.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("CodigoCE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PortalEDU.Models.Alumno", b =>
                {
                    b.HasOne("PortalEDU.Models.Calificaciones", "Calificaciones")
                        .WithMany()
                        .HasForeignKey("IdCalificaciones");

                    b.HasOne("PortalEDU.Models.CentroEducativo", "CentroEducativo")
                        .WithMany()
                        .HasForeignKey("IdCentroEducativo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PortalEDU.Models.Responsable", "Responsable")
                        .WithMany("AlumnoLista")
                        .HasForeignKey("IdResponsable");

                    b.Navigation("Calificaciones");

                    b.Navigation("CentroEducativo");

                    b.Navigation("Responsable");
                });

            modelBuilder.Entity("PortalEDU.Models.AlumnoCurso", b =>
                {
                    b.HasOne("PortalEDU.Models.Alumno", "Alumno")
                        .WithMany("AlumnoCursos")
                        .HasForeignKey("IdAlumno")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PortalEDU.Models.Curso", "Curso")
                        .WithMany("AlumnoCursos")
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("PortalEDU.Models.Aula", b =>
                {
                    b.HasOne("PortalEDU.Models.CentroEducativo", "CentroEducativo")
                        .WithMany("AulasLista")
                        .HasForeignKey("IdCentroEducativo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CentroEducativo");
                });

            modelBuilder.Entity("PortalEDU.Models.Calificaciones", b =>
                {
                    b.HasOne("PortalEDU.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("IdAlumno")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Alumno");
                });

            modelBuilder.Entity("PortalEDU.Models.CentroEducativo", b =>
                {
                    b.HasOne("PortalEDU.Models.Ciclo", "Ciclo")
                        .WithMany()
                        .HasForeignKey("IdAnioAcademico")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ciclo");
                });

            modelBuilder.Entity("PortalEDU.Models.Curso", b =>
                {
                    b.HasOne("PortalEDU.Models.Aula", "Aula")
                        .WithMany()
                        .HasForeignKey("IdAula")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Aula");
                });

            modelBuilder.Entity("PortalEDU.Models.Docente", b =>
                {
                    b.HasOne("PortalEDU.Models.CentroEducativo", "CentroEducativo")
                        .WithMany("DocentesLista")
                        .HasForeignKey("IdCentroEducativo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CentroEducativo");
                });

            modelBuilder.Entity("PortalEDU.Models.DocenteCurso", b =>
                {
                    b.HasOne("PortalEDU.Models.Curso", "IdCursoNavigation")
                        .WithMany("DocenteCursos")
                        .HasForeignKey("IdCursoNavigationId");

                    b.HasOne("PortalEDU.Models.Docente", "IdDocenteNavigation")
                        .WithMany()
                        .HasForeignKey("IdDocenteNavigationId");

                    b.Navigation("IdCursoNavigation");

                    b.Navigation("IdDocenteNavigation");
                });

            modelBuilder.Entity("PortalEDU.Models.Sala", b =>
                {
                    b.HasOne("PortalEDU.Models.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("IdDocente");

                    b.HasOne("PortalEDU.Models.Responsable", "Responsable")
                        .WithMany()
                        .HasForeignKey("IdResponsable");

                    b.Navigation("Docente");

                    b.Navigation("Responsable");
                });

            modelBuilder.Entity("PortalEDU.Models.SalaComentario", b =>
                {
                    b.HasOne("PortalEDU.Models.Sala", "Sala")
                        .WithMany("SalaComentarios")
                        .HasForeignKey("IdSala")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("PortalEDU.Models.TareaAlumno", b =>
                {
                    b.HasOne("PortalEDU.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("IdAlumno")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PortalEDU.Models.TareaDocente", "TareDocente")
                        .WithMany("TareaAlumnos")
                        .HasForeignKey("IdTareaDocente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Alumno");

                    b.Navigation("TareDocente");
                });

            modelBuilder.Entity("PortalEDU.Models.TareaDocente", b =>
                {
                    b.HasOne("PortalEDU.Models.Curso", "Curso")
                        .WithMany("TareaDocente")
                        .HasForeignKey("IdCurso");

                    b.HasOne("PortalEDU.Models.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("IdDocente");

                    b.Navigation("Curso");

                    b.Navigation("Docente");
                });

            modelBuilder.Entity("PortalEDU.Models.Alumno", b =>
                {
                    b.Navigation("AlumnoCursos");
                });

            modelBuilder.Entity("PortalEDU.Models.CentroEducativo", b =>
                {
                    b.Navigation("AulasLista");

                    b.Navigation("DocentesLista");
                });

            modelBuilder.Entity("PortalEDU.Models.Curso", b =>
                {
                    b.Navigation("AlumnoCursos");

                    b.Navigation("DocenteCursos");

                    b.Navigation("TareaDocente");
                });

            modelBuilder.Entity("PortalEDU.Models.Responsable", b =>
                {
                    b.Navigation("AlumnoLista");
                });

            modelBuilder.Entity("PortalEDU.Models.Sala", b =>
                {
                    b.Navigation("SalaComentarios");
                });

            modelBuilder.Entity("PortalEDU.Models.TareaDocente", b =>
                {
                    b.Navigation("TareaAlumnos");
                });
#pragma warning restore 612, 618
        }
    }
}
