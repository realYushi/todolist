﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoListAPI.Data;

#nullable disable

namespace ToDoListAPI.Migrations
{
    [DbContext(typeof(ToDoListContext))]
    partial class ToDoListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToDoListAPI.Models.List", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Lists", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "list1",
                            Description = "Tasks to do at home.",
                            Name = "Home Tasks",
                            UserId = "user1"
                        },
                        new
                        {
                            Id = "list2",
                            Description = "Tasks to do at work.",
                            Name = "Work Tasks",
                            UserId = "user1"
                        });
                });

            modelBuilder.Entity("ToDoListAPI.Models.Task", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DueDate");

                    b.HasIndex("ListId");

                    b.ToTable("Tasks", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "task1",
                            Description = "Wash all the dishes from dinner.",
                            DueDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = "list1",
                            Status = 1,
                            Title = "Wash dishes",
                            UserId = "user1"
                        },
                        new
                        {
                            Id = "task2",
                            Description = "Prepare the monthly performance presentation.",
                            DueDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = "list2",
                            Status = 2,
                            Title = "Prepare presentation",
                            UserId = "user1"
                        });
                });

            modelBuilder.Entity("ToDoListAPI.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "user1",
                            Email = "john.doe@example.com",
                            Password = "$2a$12$0VFPWv7NCbT.btA5UC4DneDr50tn6ge4.jslK/DABt3/JMX.1QAx.",
                            Role = "Admin",
                            Status = "Active",
                            Username = "johndoe"
                        },
                        new
                        {
                            UserId = "user2",
                            Email = "jane.doe@example.com",
                            Password = "$2a$12$0VFPWv7NCbT.btA5UC4DneDr50tn6ge4.jslK/DABt3/JMX.1QAx.",
                            Role = "User",
                            Status = "Active",
                            Username = "janedoe"
                        });
                });

            modelBuilder.Entity("ToDoListAPI.Models.List", b =>
                {
                    b.HasOne("ToDoListAPI.Models.User", "User")
                        .WithMany("Lists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToDoListAPI.Models.Task", b =>
                {
                    b.HasOne("ToDoListAPI.Models.List", "List")
                        .WithMany("Tasks")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("List");
                });

            modelBuilder.Entity("ToDoListAPI.Models.List", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("ToDoListAPI.Models.User", b =>
                {
                    b.Navigation("Lists");
                });
#pragma warning restore 612, 618
        }
    }
}
