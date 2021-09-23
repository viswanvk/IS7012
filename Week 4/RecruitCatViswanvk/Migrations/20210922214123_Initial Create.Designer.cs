﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitCatViswanvk.Data;

namespace RecruitCatViswanvk.Migrations
{
    [DbContext(typeof(RecruitCatViswanvkContext))]
    [Migration("20210922214123_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecruitCatViswanvk.Modules.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CurrentLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TargetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("CandidateId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("IndustryId");

                    b.HasIndex("JobTitleId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatViswanvk.Modules.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("CurrentlyRecruiting")
                        .HasColumnType("bit");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CompanyId");

                    b.HasIndex("IndustryId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitCatViswanvk.Modules.Industry", b =>
                {
                    b.Property<int>("IndustryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IndustryId");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitCatViswanvk.Modules.JobTitle", b =>
                {
                    b.Property<int>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("AverageSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MaximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobTitleId");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("RecruitCatViswanvk.Modules.Candidate", b =>
                {
                    b.HasOne("RecruitCatViswanvk.Modules.Company", "Company")
                        .WithMany("Candidates")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatViswanvk.Modules.Industry", "Industry")
                        .WithMany("Candidates")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatViswanvk.Modules.JobTitle", "JobTitle")
                        .WithMany("Candidates")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecruitCatViswanvk.Modules.Company", b =>
                {
                    b.HasOne("RecruitCatViswanvk.Modules.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
