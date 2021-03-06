﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Nicollas.SqlServer;
using System;

namespace Nicollas.SqlServer.Migrations
{
    [DbContext(typeof(NicollasContext))]
    [Migration("20180327231351_InitialSqliteMigration")]
    partial class InitialSqliteMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Nicollas.Core.Entities.Domain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("Disabled");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Domain");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Evaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ApliedAt");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<float>("Difficulty");

                    b.Property<bool>("Disabled");

                    b.Property<int>("DomainId");

                    b.Property<int>("ExerciseId");

                    b.Property<bool>("IsCorrect");

                    b.Property<string>("LearningObjective");

                    b.Property<int>("Progress");

                    b.Property<int>("SubjectId");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<float>("Strong");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.RoleClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("Disabled");

                    b.Property<Guid>("RoleId");

                    b.Property<Guid?>("RoleId1");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

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

                    b.Property<bool>("Trash");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("Disabled");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<Guid>("UserId");

                    b.Property<Guid?>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.UserLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("Disabled");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.UserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("Disabled");

                    b.Property<Guid>("Id");

                    b.Property<Guid?>("RoleId1");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<Guid?>("UserId1");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.UserToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<bool>("Disabled");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<Guid>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("Disabled");

                    b.Property<bool>("Trash");

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Evaluation", b =>
                {
                    b.HasOne("Nicollas.Core.Entities.Domain", "Domain")
                        .WithMany()
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nicollas.Core.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.RoleClaim", b =>
                {
                    b.HasOne("Nicollas.Core.Entities.Identity.Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nicollas.Core.Entities.Identity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId1");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.UserClaim", b =>
                {
                    b.HasOne("Nicollas.Core.Entities.Identity.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nicollas.Core.Entities.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.UserLogin", b =>
                {
                    b.HasOne("Nicollas.Core.Entities.Identity.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("Nicollas.Core.Entities.Identity.Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nicollas.Core.Entities.Identity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId1");

                    b.HasOne("Nicollas.Core.Entities.Identity.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Nicollas.Core.Entities.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Nicollas.Core.Entities.Identity.UserToken", b =>
                {
                    b.HasOne("Nicollas.Core.Entities.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
