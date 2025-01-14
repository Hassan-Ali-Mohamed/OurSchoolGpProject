﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Data.Context;

#nullable disable

namespace School.Data.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("School.Data.Entities.Attendence", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAttendence")
                        .HasColumnType("bit");

                    b.HasKey("StudentId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Attendences", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfStudent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("LevelId");

                    b.ToTable("Classes", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("fees")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Levels", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parents", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.SchoolInfo", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("SchoolInfo", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("LevelId");

                    b.HasIndex("ParentId");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("Final")
                        .HasColumnType("int");

                    b.Property<int>("MidTerm")
                        .HasColumnType("int");

                    b.Property<int>("WorkYear")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubjects", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.SubjectDepartment", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("SubjectDepartments", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.SubjectLevel", b =>
                {
                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("LevelId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectLevels", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.SubjectTerm", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TermId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "TermId");

                    b.HasIndex("TermId");

                    b.ToTable("SubjectTerms", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.TeacherLevel", b =>
                {
                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("LevelId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherLevels", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.TeacherSubjectClass", b =>
                {
                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("ClassId", "TeacherId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherSubjectClasses", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.TeacherSubjectLevel", b =>
                {
                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("LevelId", "TeacherId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherSubjectLevels", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Term", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Terms", (string)null);
                });

            modelBuilder.Entity("School.Data.Entities.Attendence", b =>
                {
                    b.HasOne("School.Data.Entities.Student", null)
                        .WithMany("Attendences")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Teacher", null)
                        .WithMany("Attendences")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Data.Entities.Class", b =>
                {
                    b.HasOne("School.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Level");
                });

            modelBuilder.Entity("School.Data.Entities.Student", b =>
                {
                    b.HasOne("School.Data.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("School.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("School.Data.Entities.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("School.Data.Entities.Parent", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Class");

                    b.Navigation("Department");

                    b.Navigation("Level");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("School.Data.Entities.StudentSubject", b =>
                {
                    b.HasOne("School.Data.Entities.Student", null)
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Subject", null)
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Data.Entities.SubjectDepartment", b =>
                {
                    b.HasOne("School.Data.Entities.Department", null)
                        .WithMany("SubjectDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Subject", null)
                        .WithMany("SubjectDepartments")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Data.Entities.SubjectLevel", b =>
                {
                    b.HasOne("School.Data.Entities.Level", null)
                        .WithMany("SubjectLevels")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Subject", null)
                        .WithMany("SubjectLevels")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Data.Entities.SubjectTerm", b =>
                {
                    b.HasOne("School.Data.Entities.Subject", null)
                        .WithMany("SubjectTerms")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Term", null)
                        .WithMany("SubjectTerms")
                        .HasForeignKey("TermId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Data.Entities.TeacherLevel", b =>
                {
                    b.HasOne("School.Data.Entities.Level", null)
                        .WithMany("TeacherLevels")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Teacher", null)
                        .WithMany("TeacherLevels")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Data.Entities.TeacherSubjectClass", b =>
                {
                    b.HasOne("School.Data.Entities.Class", null)
                        .WithMany("TeacherSubjectClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Subject", null)
                        .WithMany("TeacherSubjectClasses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Teacher", null)
                        .WithMany("TeacherSubjectClasses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Data.Entities.TeacherSubjectLevel", b =>
                {
                    b.HasOne("School.Data.Entities.Level", null)
                        .WithMany("TeacherSubjectLevels")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Subject", null)
                        .WithMany("TeacherSubjectLevels")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Teacher", null)
                        .WithMany("TeacherSubjectLevels")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Data.Entities.Class", b =>
                {
                    b.Navigation("TeacherSubjectClasses");
                });

            modelBuilder.Entity("School.Data.Entities.Department", b =>
                {
                    b.Navigation("SubjectDepartments");
                });

            modelBuilder.Entity("School.Data.Entities.Level", b =>
                {
                    b.Navigation("SubjectLevels");

                    b.Navigation("TeacherLevels");

                    b.Navigation("TeacherSubjectLevels");
                });

            modelBuilder.Entity("School.Data.Entities.Student", b =>
                {
                    b.Navigation("Attendences");

                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("School.Data.Entities.Subject", b =>
                {
                    b.Navigation("StudentSubjects");

                    b.Navigation("SubjectDepartments");

                    b.Navigation("SubjectLevels");

                    b.Navigation("SubjectTerms");

                    b.Navigation("TeacherSubjectClasses");

                    b.Navigation("TeacherSubjectLevels");
                });

            modelBuilder.Entity("School.Data.Entities.Teacher", b =>
                {
                    b.Navigation("Attendences");

                    b.Navigation("TeacherLevels");

                    b.Navigation("TeacherSubjectClasses");

                    b.Navigation("TeacherSubjectLevels");
                });

            modelBuilder.Entity("School.Data.Entities.Term", b =>
                {
                    b.Navigation("SubjectTerms");
                });
#pragma warning restore 612, 618
        }
    }
}
