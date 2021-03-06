﻿// <auto-generated />
using System;
using AlquilerDeBicicletas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlquilerDeBicicletas.Migrations.AlquilerDeBicicletas
{
    [DbContext(typeof(AlquilerDeBicicletasContext))]
    partial class AlquilerDeBicicletasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlquilerDeBicicletas.Areas.Identity.Data.AlquilerDeBicicletasUsers", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("apellido");

                    b.Property<string>("dni");

                    b.Property<DateTime>("fechaNacimiento");

                    b.Property<string>("nombre");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.Accesorio", b =>
                {
                    b.Property<int>("accesorioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("color");

                    b.Property<DateTime>("fechaDeIngreso");

                    b.Property<int?>("tipoDeAccesorioID");

                    b.HasKey("accesorioID");

                    b.HasIndex("tipoDeAccesorioID");

                    b.ToTable("Accesorios");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.Alquiler", b =>
                {
                    b.Property<int>("alquilerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlquilerDeBicicletasUsersId");

                    b.Property<string>("AlquilerDeBicicletasUsers_ID");

                    b.Property<int?>("bicicletaID");

                    b.Property<bool>("cambioFecha");

                    b.Property<int>("estadoAlquiler");

                    b.Property<DateTime>("fechaDesde");

                    b.Property<DateTime>("fechaEntregaFinal");

                    b.Property<DateTime>("fechaHasta");

                    b.Property<int>("horasBase");

                    b.Property<int>("horasExtras");

                    b.Property<double>("totalAPagarBase");

                    b.Property<double>("totalAPagarExtra");

                    b.HasKey("alquilerID");

                    b.HasIndex("AlquilerDeBicicletasUsersId");

                    b.HasIndex("bicicletaID");

                    b.ToTable("Alquileres");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.AlquilerAccesorio", b =>
                {
                    b.Property<int>("alquilerID");

                    b.Property<int>("accesorioID");

                    b.HasKey("alquilerID", "accesorioID");

                    b.HasAlternateKey("alquilerID");

                    b.HasIndex("accesorioID");

                    b.ToTable("AlquilerAccesorio");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.Bicicleta", b =>
                {
                    b.Property<int>("bicicletaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("color");

                    b.Property<DateTime>("fechaDeIngreso");

                    b.Property<int?>("tipoDeBiciID");

                    b.HasKey("bicicletaID");

                    b.HasIndex("tipoDeBiciID");

                    b.ToTable("Bicicletas");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.Pago", b =>
                {
                    b.Property<int>("pagoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("alquilerID");

                    b.Property<bool>("esPagoBase");

                    b.Property<DateTime>("fechaDePago");

                    b.Property<int>("formaDePago");

                    b.Property<double>("monto");

                    b.HasKey("pagoID");

                    b.HasIndex("alquilerID");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.TipoDeAccesorio", b =>
                {
                    b.Property<int>("tipoDeAccesorioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre");

                    b.Property<double>("precioBase");

                    b.HasKey("tipoDeAccesorioID");

                    b.ToTable("TiposDeAccesorio");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.TipoDeBici", b =>
                {
                    b.Property<int>("tipoDeBiciID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion");

                    b.Property<string>("nombre");

                    b.Property<double>("precioBase");

                    b.HasKey("tipoDeBiciID");

                    b.ToTable("TiposDeBici");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.Accesorio", b =>
                {
                    b.HasOne("AlquilerDeBicicletas.Models.TipoDeAccesorio", "tipoDeAccesorio")
                        .WithMany("accesorios")
                        .HasForeignKey("tipoDeAccesorioID");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.Alquiler", b =>
                {
                    b.HasOne("AlquilerDeBicicletas.Areas.Identity.Data.AlquilerDeBicicletasUsers", "AlquilerDeBicicletasUsers")
                        .WithMany("alquileres")
                        .HasForeignKey("AlquilerDeBicicletasUsersId");

                    b.HasOne("AlquilerDeBicicletas.Models.Bicicleta", "bicicleta")
                        .WithMany("alquileres")
                        .HasForeignKey("bicicletaID");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.AlquilerAccesorio", b =>
                {
                    b.HasOne("AlquilerDeBicicletas.Models.Accesorio", "accesorio")
                        .WithMany("alquileresAccesorio")
                        .HasForeignKey("accesorioID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AlquilerDeBicicletas.Models.Alquiler", "alquiler")
                        .WithMany("accesoriosAlquiler")
                        .HasForeignKey("alquilerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.Bicicleta", b =>
                {
                    b.HasOne("AlquilerDeBicicletas.Models.TipoDeBici", "tipoDeBici")
                        .WithMany("bicicletas")
                        .HasForeignKey("tipoDeBiciID");
                });

            modelBuilder.Entity("AlquilerDeBicicletas.Models.Pago", b =>
                {
                    b.HasOne("AlquilerDeBicicletas.Models.Alquiler", "alquiler")
                        .WithMany("pagos")
                        .HasForeignKey("alquilerID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AlquilerDeBicicletas.Areas.Identity.Data.AlquilerDeBicicletasUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AlquilerDeBicicletas.Areas.Identity.Data.AlquilerDeBicicletasUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AlquilerDeBicicletas.Areas.Identity.Data.AlquilerDeBicicletasUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AlquilerDeBicicletas.Areas.Identity.Data.AlquilerDeBicicletasUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
