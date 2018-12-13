﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UserService.Api.Entities;

namespace UserService.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181213191319_InitialIdentitySchema")]
    partial class InitialIdentitySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrencystamp");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnName("normalizedname")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_aspnetroles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("rolenameindex");

                    b.ToTable("aspnetroles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claimtype");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claimvalue");

                    b.Property<long>("RoleId")
                        .HasColumnName("roleid");

                    b.HasKey("Id")
                        .HasName("pk_aspnetroleclaims");

                    b.HasIndex("RoleId")
                        .HasName("ix_aspnetroleclaims_roleid");

                    b.ToTable("aspnetroleclaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claimtype");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claimvalue");

                    b.Property<long>("UserId")
                        .HasColumnName("userid");

                    b.HasKey("Id")
                        .HasName("pk_aspnetuserclaims");

                    b.HasIndex("UserId")
                        .HasName("ix_aspnetuserclaims_userid");

                    b.ToTable("aspnetuserclaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnName("loginprovider");

                    b.Property<string>("ProviderKey")
                        .HasColumnName("providerkey");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnName("providerdisplayname");

                    b.Property<long>("UserId")
                        .HasColumnName("userid");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_aspnetuserlogins");

                    b.HasIndex("UserId")
                        .HasName("ix_aspnetuserlogins_userid");

                    b.ToTable("aspnetuserlogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnName("userid");

                    b.Property<long>("RoleId")
                        .HasColumnName("roleid");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_aspnetuserroles");

                    b.HasIndex("RoleId")
                        .HasName("ix_aspnetuserroles_roleid");

                    b.ToTable("aspnetuserroles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnName("userid");

                    b.Property<string>("LoginProvider")
                        .HasColumnName("loginprovider");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_aspnetusertokens");

                    b.ToTable("aspnetusertokens");
                });

            modelBuilder.Entity("UserService.Api.Entities.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnName("accessfailedcount");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnName("birthday");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrencystamp");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnName("emailconfirmed");

                    b.Property<string>("FirstName")
                        .HasColumnName("firstname");

                    b.Property<string>("LastName")
                        .HasColumnName("lastname");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnName("lockoutenabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnName("lockoutend");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("normalizedemail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnName("normalizedusername")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("passwordhash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phonenumber");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnName("phonenumberconfirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnName("securitystamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnName("twofactorenabled");

                    b.Property<string>("UserName")
                        .HasColumnName("username")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_aspnetusers");

                    b.HasIndex("NormalizedEmail")
                        .HasName("emailindex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("usernameindex");

                    b.ToTable("aspnetusers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_aspnetroleclaims_aspnetroles_roleid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("UserService.Api.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_aspnetuserclaims_aspnetusers_userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("UserService.Api.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_aspnetuserlogins_aspnetusers_userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_aspnetuserroles_aspnetroles_roleid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UserService.Api.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_aspnetuserroles_aspnetusers_userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("UserService.Api.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_aspnetusertokens_aspnetusers_userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
