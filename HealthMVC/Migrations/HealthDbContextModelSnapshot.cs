﻿// <auto-generated />
using System;
using HealthMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthMVC.Migrations
{
    [DbContext(typeof(HealthDbContext))]
    partial class HealthDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HealthMVC.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialisationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialisationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HealthMVC.Models.DoctorPatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorPatients");
                });

            modelBuilder.Entity("HealthMVC.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<double>("Accuracy")
                        .HasColumnType("float");

                    b.Property<string>("Icd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IcdName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("HealthMVC.Models.IssuesSpecialisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IssueId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialisationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.HasIndex("SpecialisationId");

                    b.ToTable("IssuesSpecialisations");
                });

            modelBuilder.Entity("HealthMVC.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("HealthMVC.Models.PersonIssue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IssueId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonIssues");
                });

            modelBuilder.Entity("HealthMVC.Models.PersonSymptoms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("SymptomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("SymptomId");

                    b.ToTable("PersonSymptoms");
                });

            modelBuilder.Entity("HealthMVC.Models.Specialisation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Specialisation");
                });

            modelBuilder.Entity("HealthMVC.Models.Symptoms", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("HealthMVC.Models.Doctor", b =>
                {
                    b.HasOne("HealthMVC.Models.Specialisation", "Specialisation")
                        .WithMany()
                        .HasForeignKey("SpecialisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialisation");
                });

            modelBuilder.Entity("HealthMVC.Models.DoctorPatient", b =>
                {
                    b.HasOne("HealthMVC.Models.Doctor", "Doctor")
                        .WithMany("AssignedPatients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthMVC.Models.Person", "Person")
                        .WithMany("AssignedDoctors")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HealthMVC.Models.IssuesSpecialisation", b =>
                {
                    b.HasOne("HealthMVC.Models.Issue", "Issue")
                        .WithMany("IssuesSpecialisations")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthMVC.Models.Specialisation", "Specialisation")
                        .WithMany()
                        .HasForeignKey("SpecialisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");

                    b.Navigation("Specialisation");
                });

            modelBuilder.Entity("HealthMVC.Models.PersonIssue", b =>
                {
                    b.HasOne("HealthMVC.Models.Issue", "Issue")
                        .WithMany("PersonIssues")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthMVC.Models.Person", "Person")
                        .WithMany("PersonIssues")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HealthMVC.Models.PersonSymptoms", b =>
                {
                    b.HasOne("HealthMVC.Models.Person", "Person")
                        .WithMany("PersonSymptoms")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthMVC.Models.Symptoms", "Symptom")
                        .WithMany("PersonSymptoms")
                        .HasForeignKey("SymptomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Symptom");
                });

            modelBuilder.Entity("HealthMVC.Models.Doctor", b =>
                {
                    b.Navigation("AssignedPatients");
                });

            modelBuilder.Entity("HealthMVC.Models.Issue", b =>
                {
                    b.Navigation("IssuesSpecialisations");

                    b.Navigation("PersonIssues");
                });

            modelBuilder.Entity("HealthMVC.Models.Person", b =>
                {
                    b.Navigation("AssignedDoctors");

                    b.Navigation("PersonIssues");

                    b.Navigation("PersonSymptoms");
                });

            modelBuilder.Entity("HealthMVC.Models.Symptoms", b =>
                {
                    b.Navigation("PersonSymptoms");
                });
#pragma warning restore 612, 618
        }
    }
}
