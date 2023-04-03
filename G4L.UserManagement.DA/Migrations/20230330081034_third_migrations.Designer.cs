﻿// <auto-generated />
using System;
using G4L.UserManagement.DA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace G4L.UserManagement.DA.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230330081034_third_migrations")]
    partial class third_migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Approver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LeaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeaveId");

                    b.ToTable("Approvers");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Attendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ClockIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClockOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LeaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LeaveId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Goal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ArchiveCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("AttendanceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("GoalStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PauseCount")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeRemaining")
                        .HasColumnType("time");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceId");

                    b.HasIndex("UserId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.GoalComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("GoalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GoalStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GoalId");

                    b.ToTable("GoalComment");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.GoalTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Complete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("GoalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GoalId");

                    b.ToTable("GoalTask");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Leave", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UsedDays")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.LeaveSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("HalfDaySchedule")
                        .HasColumnType("int");

                    b.Property<int>("LeaveDayType")
                        .HasColumnType("int");

                    b.Property<Guid?>("LeaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LeaveId");

                    b.ToTable("LeaveSchedules");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Sponsor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhysicalAdrress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalAdrress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisteredName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.SponsoredUser", b =>
                {
                    b.Property<Guid>("SponsorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SponsorId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("SponsoredUsers");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Career")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LearnershipStartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<Guid?>("SponsorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SponsorId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Approver", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.Leave", null)
                        .WithMany("Approvers")
                        .HasForeignKey("LeaveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Attendance", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.User", null)
                        .WithMany("Attendances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Document", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.Leave", null)
                        .WithMany("Documents")
                        .HasForeignKey("LeaveId");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Goal", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.Attendance", null)
                        .WithMany("Goals")
                        .HasForeignKey("AttendanceId");

                    b.HasOne("G4L.UserManagement.BL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.GoalComment", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.Goal", null)
                        .WithMany("Comment")
                        .HasForeignKey("GoalId");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.GoalTask", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.Goal", null)
                        .WithMany("Tasks")
                        .HasForeignKey("GoalId");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Leave", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.User", null)
                        .WithMany("Leaves")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.LeaveSchedule", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.Leave", null)
                        .WithMany("LeaveSchedules")
                        .HasForeignKey("LeaveId");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.SponsoredUser", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.Sponsor", "Sponsor")
                        .WithMany("SponsoredUser")
                        .HasForeignKey("SponsorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("G4L.UserManagement.BL.Entities.User", "User")
                        .WithMany("SponsoredUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sponsor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.User", b =>
                {
                    b.HasOne("G4L.UserManagement.BL.Entities.Sponsor", null)
                        .WithMany("Approvers")
                        .HasForeignKey("SponsorId");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Attendance", b =>
                {
                    b.Navigation("Goals");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Goal", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Leave", b =>
                {
                    b.Navigation("Approvers");

                    b.Navigation("Documents");

                    b.Navigation("LeaveSchedules");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.Sponsor", b =>
                {
                    b.Navigation("Approvers");

                    b.Navigation("SponsoredUser");
                });

            modelBuilder.Entity("G4L.UserManagement.BL.Entities.User", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Leaves");

                    b.Navigation("SponsoredUser");
                });
#pragma warning restore 612, 618
        }
    }
}
