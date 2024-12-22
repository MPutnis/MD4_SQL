﻿// <auto-generated />
using System;
using MD4_SQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MD4_SQL.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MD4_SQL.Data.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Assignments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Deadline = new DateTime(2025, 3, 23, 10, 53, 54, 980, DateTimeKind.Local).AddTicks(6177),
                            Description = "et"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            Deadline = new DateTime(2025, 5, 18, 6, 55, 26, 46, DateTimeKind.Local).AddTicks(4686),
                            Description = "nam"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            Deadline = new DateTime(2025, 2, 5, 1, 59, 40, 502, DateTimeKind.Local).AddTicks(8800),
                            Description = "ut"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 4,
                            Deadline = new DateTime(2025, 1, 22, 20, 59, 49, 280, DateTimeKind.Local).AddTicks(8565),
                            Description = "distinctio"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 5,
                            Deadline = new DateTime(2025, 8, 8, 8, 1, 20, 863, DateTimeKind.Local).AddTicks(8757),
                            Description = "dolorem"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 6,
                            Deadline = new DateTime(2025, 1, 6, 10, 8, 1, 551, DateTimeKind.Local).AddTicks(4215),
                            Description = "hic"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 7,
                            Deadline = new DateTime(2025, 3, 20, 11, 46, 56, 990, DateTimeKind.Local).AddTicks(2376),
                            Description = "dolorem"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 8,
                            Deadline = new DateTime(2025, 1, 16, 6, 58, 39, 303, DateTimeKind.Local).AddTicks(6934),
                            Description = "aliquam"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 9,
                            Deadline = new DateTime(2025, 2, 28, 10, 29, 0, 982, DateTimeKind.Local).AddTicks(2078),
                            Description = "nulla"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 10,
                            Deadline = new DateTime(2025, 12, 3, 12, 49, 12, 774, DateTimeKind.Local).AddTicks(7611),
                            Description = "sit"
                        });
                });

            modelBuilder.Entity("MD4_SQL.Data.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "laudantium",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "consequatur",
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "exercitationem",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "mollitia",
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "occaecati",
                            TeacherId = 5
                        },
                        new
                        {
                            Id = 6,
                            Name = "aspernatur",
                            TeacherId = 6
                        },
                        new
                        {
                            Id = 7,
                            Name = "aut",
                            TeacherId = 7
                        },
                        new
                        {
                            Id = 8,
                            Name = "saepe",
                            TeacherId = 8
                        },
                        new
                        {
                            Id = 9,
                            Name = "voluptas",
                            TeacherId = 9
                        },
                        new
                        {
                            Id = 10,
                            Name = "asperiores",
                            TeacherId = 10
                        });
                });

            modelBuilder.Entity("MD4_SQL.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Gender = 1,
                            Name = "Carrie",
                            StudentIdNumber = "SN50202",
                            Surname = "Hettinger"
                        },
                        new
                        {
                            Id = 2,
                            Gender = 0,
                            Name = "Jody",
                            StudentIdNumber = "SN10578",
                            Surname = "Feest"
                        },
                        new
                        {
                            Id = 3,
                            Gender = 1,
                            Name = "Robin",
                            StudentIdNumber = "SN62987",
                            Surname = "Feil"
                        },
                        new
                        {
                            Id = 4,
                            Gender = 2,
                            Name = "Byron",
                            StudentIdNumber = "SN01399",
                            Surname = "Ortiz"
                        },
                        new
                        {
                            Id = 5,
                            Gender = 1,
                            Name = "Leona",
                            StudentIdNumber = "SN05198",
                            Surname = "Smith"
                        },
                        new
                        {
                            Id = 6,
                            Gender = 2,
                            Name = "Hector",
                            StudentIdNumber = "SN99740",
                            Surname = "Walker"
                        },
                        new
                        {
                            Id = 7,
                            Gender = 0,
                            Name = "Rene",
                            StudentIdNumber = "SN55840",
                            Surname = "Parisian"
                        },
                        new
                        {
                            Id = 8,
                            Gender = 0,
                            Name = "Ronald",
                            StudentIdNumber = "SN71165",
                            Surname = "Harber"
                        },
                        new
                        {
                            Id = 9,
                            Gender = 0,
                            Name = "Jesse",
                            StudentIdNumber = "SN78365",
                            Surname = "Kihn"
                        },
                        new
                        {
                            Id = 10,
                            Gender = 2,
                            Name = "Fannie",
                            StudentIdNumber = "SN85399",
                            Surname = "Rempel"
                        });
                });

            modelBuilder.Entity("MD4_SQL.Data.Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Submissions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignmentId = 1,
                            Score = 18,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2025, 11, 30, 5, 44, 14, 942, DateTimeKind.Local).AddTicks(9496)
                        },
                        new
                        {
                            Id = 2,
                            AssignmentId = 2,
                            Score = 60,
                            StudentId = 2,
                            SubmissionTime = new DateTime(2025, 12, 2, 2, 24, 42, 389, DateTimeKind.Local).AddTicks(7053)
                        },
                        new
                        {
                            Id = 3,
                            AssignmentId = 3,
                            Score = 25,
                            StudentId = 3,
                            SubmissionTime = new DateTime(2025, 8, 17, 8, 7, 31, 129, DateTimeKind.Local).AddTicks(1718)
                        },
                        new
                        {
                            Id = 4,
                            AssignmentId = 4,
                            Score = 39,
                            StudentId = 4,
                            SubmissionTime = new DateTime(2025, 2, 16, 8, 26, 59, 227, DateTimeKind.Local).AddTicks(4006)
                        },
                        new
                        {
                            Id = 5,
                            AssignmentId = 5,
                            Score = 51,
                            StudentId = 5,
                            SubmissionTime = new DateTime(2025, 2, 20, 8, 48, 59, 212, DateTimeKind.Local).AddTicks(2664)
                        },
                        new
                        {
                            Id = 6,
                            AssignmentId = 6,
                            Score = 31,
                            StudentId = 6,
                            SubmissionTime = new DateTime(2025, 12, 10, 16, 49, 4, 946, DateTimeKind.Local).AddTicks(1293)
                        },
                        new
                        {
                            Id = 7,
                            AssignmentId = 7,
                            Score = 30,
                            StudentId = 7,
                            SubmissionTime = new DateTime(2025, 10, 2, 18, 59, 50, 627, DateTimeKind.Local).AddTicks(3787)
                        },
                        new
                        {
                            Id = 8,
                            AssignmentId = 8,
                            Score = 17,
                            StudentId = 8,
                            SubmissionTime = new DateTime(2025, 6, 25, 14, 31, 42, 718, DateTimeKind.Local).AddTicks(9416)
                        },
                        new
                        {
                            Id = 9,
                            AssignmentId = 9,
                            Score = 29,
                            StudentId = 9,
                            SubmissionTime = new DateTime(2025, 1, 9, 20, 58, 33, 415, DateTimeKind.Local).AddTicks(7775)
                        },
                        new
                        {
                            Id = 10,
                            AssignmentId = 10,
                            Score = 22,
                            StudentId = 10,
                            SubmissionTime = new DateTime(2025, 3, 6, 10, 39, 21, 497, DateTimeKind.Local).AddTicks(9815)
                        });
                });

            modelBuilder.Entity("MD4_SQL.Data.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContractDate = new DateTime(2013, 9, 10, 18, 32, 29, 553, DateTimeKind.Local).AddTicks(2923),
                            Gender = 1,
                            Name = "Hester",
                            Surname = "Reinger"
                        },
                        new
                        {
                            Id = 2,
                            ContractDate = new DateTime(2019, 12, 19, 10, 2, 39, 356, DateTimeKind.Local).AddTicks(8084),
                            Gender = 1,
                            Name = "Moses",
                            Surname = "Jacobson"
                        },
                        new
                        {
                            Id = 3,
                            ContractDate = new DateTime(2014, 2, 23, 1, 56, 46, 497, DateTimeKind.Local).AddTicks(6311),
                            Gender = 2,
                            Name = "Rahul",
                            Surname = "Gibson"
                        },
                        new
                        {
                            Id = 4,
                            ContractDate = new DateTime(2013, 7, 8, 11, 43, 5, 662, DateTimeKind.Local).AddTicks(3862),
                            Gender = 1,
                            Name = "Shanon",
                            Surname = "Pagac"
                        },
                        new
                        {
                            Id = 5,
                            ContractDate = new DateTime(2013, 8, 27, 17, 14, 36, 932, DateTimeKind.Local).AddTicks(4043),
                            Gender = 1,
                            Name = "Melissa",
                            Surname = "Stanton"
                        },
                        new
                        {
                            Id = 6,
                            ContractDate = new DateTime(2022, 8, 10, 9, 15, 32, 912, DateTimeKind.Local).AddTicks(7041),
                            Gender = 0,
                            Name = "Annabell",
                            Surname = "Smitham"
                        },
                        new
                        {
                            Id = 7,
                            ContractDate = new DateTime(2024, 2, 3, 19, 12, 17, 911, DateTimeKind.Local).AddTicks(9865),
                            Gender = 1,
                            Name = "Maybelle",
                            Surname = "Ortiz"
                        },
                        new
                        {
                            Id = 8,
                            ContractDate = new DateTime(2010, 3, 15, 8, 12, 39, 486, DateTimeKind.Local).AddTicks(1834),
                            Gender = 0,
                            Name = "Hellen",
                            Surname = "Hammes"
                        },
                        new
                        {
                            Id = 9,
                            ContractDate = new DateTime(2019, 12, 16, 19, 36, 59, 579, DateTimeKind.Local).AddTicks(1080),
                            Gender = 2,
                            Name = "Seth",
                            Surname = "Deckow"
                        },
                        new
                        {
                            Id = 10,
                            ContractDate = new DateTime(2022, 3, 7, 6, 44, 38, 515, DateTimeKind.Local).AddTicks(6561),
                            Gender = 2,
                            Name = "Samantha",
                            Surname = "Prosacco"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MD4_SQL.Data.Assignment", b =>
                {
                    b.HasOne("MD4_SQL.Data.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("MD4_SQL.Data.Course", b =>
                {
                    b.HasOne("MD4_SQL.Data.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("MD4_SQL.Data.Submission", b =>
                {
                    b.HasOne("MD4_SQL.Data.Assignment", "Assignment")
                        .WithMany()
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MD4_SQL.Data.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
