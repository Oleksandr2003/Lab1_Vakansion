﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vakansion.Core;

#nullable disable

namespace Vakansion.Core.Migrations
{
    [DbContext(typeof(VacancyContext))]
    [Migration("20221020215615_Test")]
    partial class Test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bc2ab886-7c1c-4fd4-b0c0-971b769050bb",
                            ConcurrencyStamp = "ce22ee7d-48bc-470e-9f90-aedcc5f9c6c7",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "acbdaeec-510a-49e6-b4fc-be4cd8f218f0",
                            ConcurrencyStamp = "1d2ee222-41e1-4a89-9dba-f419ef3ad9bf",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "7c254c7a-1c00-49b5-bb86-2c0f27421f1f",
                            RoleId = "bc2ab886-7c1c-4fd4-b0c0-971b769050bb"
                        },
                        new
                        {
                            UserId = "1b384ed7-c658-4085-9b7d-c211966ee7b8",
                            RoleId = "bc2ab886-7c1c-4fd4-b0c0-971b769050bb"
                        },
                        new
                        {
                            UserId = "1b384ed7-c658-4085-9b7d-c211966ee7b8",
                            RoleId = "acbdaeec-510a-49e6-b4fc-be4cd8f218f0"
                        });
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Vakansion.Core.Data", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Datas");
                });

            modelBuilder.Entity("Vakansion.Core.Education", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Vakansion.Core.Employer", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("Vakansion.Core.Position", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Vakansion.Core.Unemployed", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DataId")
                        .HasColumnType("int");

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("DataId")
                        .IsUnique();

                    b.HasIndex("EducationId")
                        .IsUnique();

                    b.ToTable("Unemployeds");
                });

            modelBuilder.Entity("Vakansion.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7c254c7a-1c00-49b5-bb86-2c0f27421f1f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f687d2d-d40b-45f2-afc8-9fdd7490a96f",
                            Email = "admin@vacansyukraine.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@VACANSYUKRAINE.COM",
                            NormalizedUserName = "ADMIN@VACANSYUKRAINE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEM/cdTiG6hBTkjq7a3JeCCxnZT9IVu7VOVaITvGMI7+r7+RNie2/kSlHGYM3Kn/P6A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "878086ab-4fc7-40f2-8445-768312ab5576",
                            TwoFactorEnabled = false,
                            UserName = "admin@vacansyukraine.com"
                        },
                        new
                        {
                            Id = "1b384ed7-c658-4085-9b7d-c211966ee7b8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "59137cd2-2f65-404f-92e0-08289cc8f629",
                            Email = "user@vacansyukraine.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@VACANSYUKRAINE.COM",
                            NormalizedUserName = "USER@VACANSYUKRAINE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP9n92r9TS0oo6/tJ7WEQ0jttHPgbMM6kirA1KUQmJ9yGZNe/L2YokS6P7BEOo/nJw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "224d1a5b-578c-4465-b112-cfe4dde1b761",
                            TwoFactorEnabled = false,
                            UserName = "user@vacansyukraine.com"
                        });
                });

            modelBuilder.Entity("Vakansion.Core.Vacancys", b =>
                {
                    b.Property<int>("VacancysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacancysId"), 1L, 1);

                    b.Property<int?>("DataClassId")
                        .HasColumnType("int");

                    b.Property<int?>("EducationClassId")
                        .HasColumnType("int");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("UnemployedId")
                        .HasColumnType("int");

                    b.HasKey("VacancysId");

                    b.HasIndex("DataClassId");

                    b.HasIndex("EducationClassId");

                    b.HasIndex("EmployerId");

                    b.HasIndex("PositionId");

                    b.HasIndex("UnemployedId");

                    b.ToTable("Vacancyses");
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
                    b.HasOne("Vakansion.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Vakansion.Core.User", null)
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

                    b.HasOne("Vakansion.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Vakansion.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vakansion.Core.Unemployed", b =>
                {
                    b.HasOne("Vakansion.Core.Data", "Datas")
                        .WithOne("Unemployeds")
                        .HasForeignKey("Vakansion.Core.Unemployed", "DataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vakansion.Core.Education", "Educations")
                        .WithOne("Unemployeds")
                        .HasForeignKey("Vakansion.Core.Unemployed", "EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Datas");

                    b.Navigation("Educations");
                });

            modelBuilder.Entity("Vakansion.Core.Vacancys", b =>
                {
                    b.HasOne("Vakansion.Core.Data", null)
                        .WithMany("Vacancies")
                        .HasForeignKey("DataClassId");

                    b.HasOne("Vakansion.Core.Education", null)
                        .WithMany("Vacancies")
                        .HasForeignKey("EducationClassId");

                    b.HasOne("Vakansion.Core.Employer", "Employers")
                        .WithMany("Vacancies")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vakansion.Core.Position", "Positions")
                        .WithMany("Vacancies")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vakansion.Core.Unemployed", "Unemployeds")
                        .WithMany("Vacancies")
                        .HasForeignKey("UnemployedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employers");

                    b.Navigation("Positions");

                    b.Navigation("Unemployeds");
                });

            modelBuilder.Entity("Vakansion.Core.Data", b =>
                {
                    b.Navigation("Unemployeds");

                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("Vakansion.Core.Education", b =>
                {
                    b.Navigation("Unemployeds");

                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("Vakansion.Core.Employer", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("Vakansion.Core.Position", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("Vakansion.Core.Unemployed", b =>
                {
                    b.Navigation("Vacancies");
                });
#pragma warning restore 612, 618
        }
    }
}