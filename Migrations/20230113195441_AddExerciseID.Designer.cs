﻿// <auto-generated />
using System;
using GymSharp_Bercea_Anelise_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymSharpBerceaAneliseProiect.Migrations
{
    [DbContext(typeof(GymContext))]
    [Migration("20230113195441_AddExerciseID")]
    partial class AddExerciseID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.Exercise", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Muscle_group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Exercises", (string)null);
                });

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<float>("Calories")
                        .HasColumnType("real");

                    b.Property<float>("Carbs")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Fats")
                        .HasColumnType("real");

                    b.Property<string>("Food_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Foods", (string)null);
                });

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.Measurement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<float>("Body_fat_percentage")
                        .HasColumnType("real");

                    b.Property<float>("Chest")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExerciseID")
                        .HasColumnType("int");

                    b.Property<int>("Exercise_id")
                        .HasColumnType("int");

                    b.Property<float>("Hips")
                        .HasColumnType("real");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<float>("Waist")
                        .HasColumnType("real");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("ExerciseID");

                    b.ToTable("Measurements", (string)null);
                });

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Account_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.Workout", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<string>("Exercise_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("UserID");

                    b.ToTable("Workouts", (string)null);
                });

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.Measurement", b =>
                {
                    b.HasOne("GymSharp_Bercea_Anelise_Proiect.Models.Exercise", null)
                        .WithMany("Measurements")
                        .HasForeignKey("ExerciseID");
                });

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.Workout", b =>
                {
                    b.HasOne("GymSharp_Bercea_Anelise_Proiect.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymSharp_Bercea_Anelise_Proiect.Models.User", "User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserID");

                    b.Navigation("Exercise");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.Exercise", b =>
                {
                    b.Navigation("Measurements");
                });

            modelBuilder.Entity("GymSharp_Bercea_Anelise_Proiect.Models.User", b =>
                {
                    b.Navigation("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
