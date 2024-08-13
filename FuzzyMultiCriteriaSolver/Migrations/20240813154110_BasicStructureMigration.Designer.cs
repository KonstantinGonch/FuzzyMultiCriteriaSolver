﻿// <auto-generated />
using System;
using FuzzyMultiCriteriaSolver.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FuzzyMultiCriteriaSolver.Migrations
{
    [DbContext(typeof(CriteriaSolverContext))]
    [Migration("20240813154110_BasicStructureMigration")]
    partial class BasicStructureMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.ANFISInstance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("DatasetPath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("MSE")
                        .HasColumnType("decimal(65,30)");

                    b.Property<long>("ObjectiveId")
                        .HasColumnType("bigint");

                    b.Property<string>("PmmlRef")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveId");

                    b.ToTable("AnfisInstances");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.GraphicalReportUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AnfisInstanceId")
                        .HasColumnType("bigint");

                    b.Property<string>("FileRef")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AnfisInstanceId");

                    b.ToTable("GraphicalReportUnits");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.MembershipFunction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Arguments")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MembershipFunctionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MembershipFunctions");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.Objective", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.UserRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AnfisInstanceId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("AnfisInstanceId");

                    b.ToTable("UserRequests");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.UserVariableInput", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("UserRequestId")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("Value")
                        .HasColumnType("decimal(65,30)");

                    b.Property<long?>("VariableId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserRequestId");

                    b.HasIndex("VariableId");

                    b.ToTable("UserVariableInputs");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.Variable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("IsStrict")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("ObjectiveId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveId");

                    b.ToTable("Variables");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.ANFISInstance", b =>
                {
                    b.HasOne("FuzzyMultiCriteriaSolver.Models.Objective", "Objective")
                        .WithMany()
                        .HasForeignKey("ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objective");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.GraphicalReportUnit", b =>
                {
                    b.HasOne("FuzzyMultiCriteriaSolver.Models.ANFISInstance", "AnfisInstance")
                        .WithMany()
                        .HasForeignKey("AnfisInstanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnfisInstance");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.UserRequest", b =>
                {
                    b.HasOne("FuzzyMultiCriteriaSolver.Models.ANFISInstance", "AnfisInstance")
                        .WithMany()
                        .HasForeignKey("AnfisInstanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnfisInstance");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.UserVariableInput", b =>
                {
                    b.HasOne("FuzzyMultiCriteriaSolver.Models.UserRequest", "UserRequest")
                        .WithMany()
                        .HasForeignKey("UserRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FuzzyMultiCriteriaSolver.Models.Variable", "Variable")
                        .WithMany()
                        .HasForeignKey("VariableId");

                    b.Navigation("UserRequest");

                    b.Navigation("Variable");
                });

            modelBuilder.Entity("FuzzyMultiCriteriaSolver.Models.Variable", b =>
                {
                    b.HasOne("FuzzyMultiCriteriaSolver.Models.Objective", "Objective")
                        .WithMany()
                        .HasForeignKey("ObjectiveId");

                    b.Navigation("Objective");
                });
#pragma warning restore 612, 618
        }
    }
}
