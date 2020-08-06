﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yiming.Infrastructure.TaskManagementSystem.Data;

namespace Yiming.Infrastructure.TaskManagementSystem.Migrations
{
    [DbContext(typeof(TaskManagementSystemDbContext))]
    [Migration("20200806165537_varchar")]
    partial class varchar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Yiming.Core.Task_Management_System.Entities.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasMaxLength(500);

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Priority")
                        .HasColumnType("varchar")
                        .HasMaxLength(1);

                    b.Property<string>("Remarks")
                        .HasColumnType("varchar")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Yiming.Core.Task_Management_System.Entities.TasksHistory", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Completed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasMaxLength(500);

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .HasColumnType("varchar")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("TaskId");

                    b.HasIndex("UsersId");

                    b.ToTable("TasksHistory");
                });

            modelBuilder.Entity("Yiming.Core.Task_Management_System.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("Mobileno")
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Yiming.Core.Task_Management_System.Entities.Tasks", b =>
                {
                    b.HasOne("Yiming.Core.Task_Management_System.Entities.Users", null)
                        .WithMany("Tasks")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Yiming.Core.Task_Management_System.Entities.TasksHistory", b =>
                {
                    b.HasOne("Yiming.Core.Task_Management_System.Entities.Users", null)
                        .WithMany("TasksHistory")
                        .HasForeignKey("UsersId");
                });
#pragma warning restore 612, 618
        }
    }
}
