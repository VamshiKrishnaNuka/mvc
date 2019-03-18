﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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

            modelBuilder.Entity("WebApplication2.Models.Credit", b =>
                {
                    b.Property<int>("CreditId");

                    b.Property<string>("CreditAbrrev")
                        .HasMaxLength(40);

                    b.Property<int?>("CreditId1");

                    b.Property<string>("CreditName")
                        .HasMaxLength(40);

                    b.Property<int>("isFall");

                    b.Property<int>("isSpring");

                    b.Property<int>("isSummer");

                    b.HasKey("CreditId");

                    b.HasIndex("CreditId1");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("WebApplication2.Models.Degree", b =>
                {
                    b.Property<int>("DegreeId");

                    b.Property<string>("DegreeAbrrev")
                        .HasMaxLength(40);

                    b.Property<int?>("DegreeId1");

                    b.Property<string>("DegreeName")
                        .HasMaxLength(40);

                    b.HasKey("DegreeId");

                    b.HasIndex("DegreeId1");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("WebApplication2.Models.DegreeCredit", b =>
                {
                    b.Property<int>("DegreeCreditId");

                    b.Property<int>("CreditId");

                    b.Property<int>("DegreeId");

                    b.HasKey("DegreeCreditId");

                    b.HasIndex("CreditId");

                    b.HasIndex("DegreeId");

                    b.ToTable("DegreeCredits");
                });

            modelBuilder.Entity("WebApplication2.Models.DegreePlan", b =>
                {
                    b.Property<int>("DegreePlanId");

                    b.Property<int>("DegreeId");

                    b.Property<string>("DegreePlanAbbrev")
                        .HasMaxLength(50);

                    b.Property<int?>("DegreePlanId1");

                    b.Property<string>("DegreePlanName")
                        .HasMaxLength(50);

                    b.Property<int>("StudentId");

                    b.HasKey("DegreePlanId");

                    b.HasIndex("DegreeId");

                    b.HasIndex("DegreePlanId1");

                    b.HasIndex("StudentId");

                    b.ToTable("DegreePlans");
                });

            modelBuilder.Entity("WebApplication2.Models.Slot", b =>
                {
                    b.Property<int>("SlotId");

                    b.Property<int>("CreditId");

                    b.Property<int>("DegreePlanId");

                    b.Property<string>("Status")
                        .HasMaxLength(10);

                    b.Property<int>("Term");

                    b.HasKey("SlotId");

                    b.HasIndex("CreditId");

                    b.HasIndex("DegreePlanId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("WebApplication2.Models.Student", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<string>("FamilyName")
                        .HasMaxLength(35);

                    b.Property<string>("GivenName")
                        .HasMaxLength(35);

                    b.Property<int>("Num919");

                    b.Property<int>("Snumber");

                    b.Property<int?>("StudentId1");

                    b.HasKey("StudentId");

                    b.HasIndex("StudentId1");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApplication2.Models.StudentTerm", b =>
                {
                    b.Property<int>("StudentTermId");

                    b.Property<int>("StudentId");

                    b.Property<int>("StudentTermNo");

                    b.Property<string>("TermAbbrev")
                        .HasMaxLength(20);

                    b.Property<string>("TermName")
                        .HasMaxLength(35);

                    b.HasKey("StudentTermId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentTerms");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.Credit", b =>
                {
                    b.HasOne("WebApplication2.Models.Credit")
                        .WithMany("Credits")
                        .HasForeignKey("CreditId1");
                });

            modelBuilder.Entity("WebApplication2.Models.Degree", b =>
                {
                    b.HasOne("WebApplication2.Models.Degree")
                        .WithMany("Degrees")
                        .HasForeignKey("DegreeId1");
                });

            modelBuilder.Entity("WebApplication2.Models.DegreeCredit", b =>
                {
                    b.HasOne("WebApplication2.Models.Credit", "Credit")
                        .WithMany()
                        .HasForeignKey("CreditId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication2.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.DegreePlan", b =>
                {
                    b.HasOne("WebApplication2.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication2.Models.DegreePlan")
                        .WithMany("DegreePlans")
                        .HasForeignKey("DegreePlanId1");

                    b.HasOne("WebApplication2.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.Slot", b =>
                {
                    b.HasOne("WebApplication2.Models.Credit", "Credit")
                        .WithMany()
                        .HasForeignKey("CreditId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication2.Models.DegreePlan", "DegreePlan")
                        .WithMany()
                        .HasForeignKey("DegreePlanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.Student", b =>
                {
                    b.HasOne("WebApplication2.Models.Student")
                        .WithMany("Students")
                        .HasForeignKey("StudentId1");
                });

            modelBuilder.Entity("WebApplication2.Models.StudentTerm", b =>
                {
                    b.HasOne("WebApplication2.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
