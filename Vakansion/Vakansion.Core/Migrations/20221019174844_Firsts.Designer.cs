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
    [Migration("20221019174844_Firsts")]
    partial class Firsts
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
                            Id = "473c0403-d73e-4fc9-bcfc-dbd17b9943e6",
                            ConcurrencyStamp = "14ab7b62-0ca7-4127-bc22-68f64ec81242",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "20d374b1-7576-4d0e-a16a-1a2065074b31",
                            ConcurrencyStamp = "6a1299b4-4c31-4721-a8f3-61bd8c3f549d",
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
                            UserId = "c20b7c03-733b-40af-8c6a-b1ef6bc93445",
                            RoleId = "473c0403-d73e-4fc9-bcfc-dbd17b9943e6"
                        },
                        new
                        {
                            UserId = "fe56737b-fc92-462e-bd47-97cfd3b1fc8e",
                            RoleId = "473c0403-d73e-4fc9-bcfc-dbd17b9943e6"
                        },
                        new
                        {
                            UserId = "fe56737b-fc92-462e-bd47-97cfd3b1fc8e",
                            RoleId = "20d374b1-7576-4d0e-a16a-1a2065074b31"
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
                            Id = "c20b7c03-733b-40af-8c6a-b1ef6bc93445",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d1996a0d-a936-49e3-a112-174121afe1a4",
                            Email = "admin@vacansyukraine.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@VACANSYUKRAINE.COM",
                            NormalizedUserName = "ADMIN@VACANSYUKRAINE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDLifz+jkqablWKXKVQFcSjCeDi/im3+V0pAfbpbkpi6DAm71dwybtQ/+iDH8yPD8Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b6b0ce61-3bb4-4e36-83ff-fd8fe7a20915",
                            TwoFactorEnabled = false,
                            UserName = "admin@vacansyukraine.com"
                        },
                        new
                        {
                            Id = "fe56737b-fc92-462e-bd47-97cfd3b1fc8e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "641fbd9b-3507-4803-ab69-7b3ec37875a2",
                            Email = "user@vacansyukraine.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@VACANSYUKRAINE.COM",
                            NormalizedUserName = "USER@VACANSYUKRAINE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJyf0sFtcGGWSRjW26np5wwqFHn7m/PKdQ1g9j3UgeazHaTU5itER1ZZw3P5N3uubg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "71c42ca3-674b-4f68-9e67-4927002bd13a",
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
