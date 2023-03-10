// <auto-generated />
using System;
using Complaints.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Complaints.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221231150749_ComplaintTypeContact-ComplaintType-rel")]
    partial class ComplaintTypeContactComplaintTyperel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Complaints.Models.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AreaId"));

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AreaId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Complaints.Models.Citizen", b =>
                {
                    b.Property<int>("CtzId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CtzId"));

                    b.Property<string>("CtzAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("CtzEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CtzName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("CtzPhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("SSN")
                        .HasMaxLength(14)
                        .HasColumnType("int");

                    b.HasKey("CtzId");

                    b.ToTable("Citizens");
                });

            modelBuilder.Entity("Complaints.Models.Complaint", b =>
                {
                    b.Property<int>("CompId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompId"));

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CompIssuedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CompStatusID")
                        .HasColumnType("int");

                    b.Property<string>("CompText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CtzId")
                        .HasColumnType("int");

                    b.HasKey("CompId");

                    b.HasIndex("AreaId");

                    b.HasIndex("CompStatusID");

                    b.HasIndex("CtzId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("Complaints.Models.ComplaintFile", b =>
                {
                    b.Property<int>("CompFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompFileId"));

                    b.Property<byte>("file")
                        .HasColumnType("tinyint");

                    b.HasKey("CompFileId");

                    b.ToTable("ComplaintFiles");
                });

            modelBuilder.Entity("Complaints.Models.ComplaintStatus", b =>
                {
                    b.Property<int>("CompStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompStatusID"));

                    b.Property<string>("CompStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompStatusID");

                    b.ToTable("ComplaintStatuses");
                });

            modelBuilder.Entity("Complaints.Models.ComplaintType", b =>
                {
                    b.Property<int>("CompTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompTypeId"));

                    b.Property<string>("CompTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompTypeId");

                    b.ToTable("ComplaintTypes");
                });

            modelBuilder.Entity("Complaints.Models.ComplaintTypeContact", b =>
                {
                    b.Property<int>("CompTypeContactID")
                        .HasColumnType("int");

                    b.Property<int>("CompTypeId")
                        .HasColumnType("int");

                    b.Property<string>("CompTypeContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompTypeContactPhone")
                        .HasColumnType("int");

                    b.HasKey("CompTypeContactID", "CompTypeId");

                    b.HasIndex("CompTypeId");

                    b.ToTable("ComplaintTypeContacts");
                });

            modelBuilder.Entity("Complaints.Models.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"));

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Complaints.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"));

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("JobTitId")
                        .HasColumnType("int");

                    b.HasKey("EmpId");

                    b.HasIndex("DeptId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobTitId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Complaints.Models.EmployeeCompNote", b =>
                {
                    b.Property<int>("EmpCompNoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpCompNoteId"));

                    b.Property<string>("EmpCompNote")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpCompNoteId");

                    b.ToTable("EmployeeCompNotes");
                });

            modelBuilder.Entity("Complaints.Models.EmployeeComplaint", b =>
                {
                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.HasKey("EmpId", "CompId");

                    b.HasIndex("CompId");

                    b.ToTable("EmployeeComplaints");
                });

            modelBuilder.Entity("Complaints.Models.JobTitle", b =>
                {
                    b.Property<int>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobTitleId"));

                    b.Property<string>("JobTitleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobTitleId");

                    b.ToTable("JobTitles");
                });

            modelBuilder.Entity("Complaints.Models.Response", b =>
                {
                    b.Property<int>("RespId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RespId"));

                    b.Property<int>("CompId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RespDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RespText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RespTypeId")
                        .HasColumnType("int");

                    b.HasKey("RespId");

                    b.HasIndex("CompId");

                    b.HasIndex("RespTypeId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("Complaints.Models.ResponseType", b =>
                {
                    b.Property<int>("RespTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RespTypeId"));

                    b.Property<string>("RespTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RespTypeId");

                    b.ToTable("ResponseTypes");
                });

            modelBuilder.Entity("Complaints.Models.Complaint", b =>
                {
                    b.HasOne("Complaints.Models.Area", "Area")
                        .WithMany("Complaints")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Complaints.Models.ComplaintStatus", "ComplaintStatus")
                        .WithMany()
                        .HasForeignKey("CompStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Complaints.Models.Citizen", "Citizen")
                        .WithMany("Complaints")
                        .HasForeignKey("CtzId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Citizen");

                    b.Navigation("ComplaintStatus");
                });

            modelBuilder.Entity("Complaints.Models.ComplaintTypeContact", b =>
                {
                    b.HasOne("Complaints.Models.ComplaintType", "ComplaintType")
                        .WithMany("ComplaintTypeContacts")
                        .HasForeignKey("CompTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComplaintType");
                });

            modelBuilder.Entity("Complaints.Models.Employee", b =>
                {
                    b.HasOne("Complaints.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Complaints.Models.Employee", null)
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Complaints.Models.JobTitle", "JobTitle")
                        .WithMany()
                        .HasForeignKey("JobTitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("Complaints.Models.EmployeeComplaint", b =>
                {
                    b.HasOne("Complaints.Models.Complaint", "Complaint")
                        .WithMany("EmployeeComplaints")
                        .HasForeignKey("CompId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Complaints.Models.Employee", "Employee")
                        .WithMany("EmployeeComplaints")
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Complaint");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Complaints.Models.Response", b =>
                {
                    b.HasOne("Complaints.Models.Complaint", "Complaint")
                        .WithMany("Responses")
                        .HasForeignKey("CompId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Complaints.Models.ResponseType", "ResponseType")
                        .WithMany("Responses")
                        .HasForeignKey("RespTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Complaint");

                    b.Navigation("ResponseType");
                });

            modelBuilder.Entity("Complaints.Models.Area", b =>
                {
                    b.Navigation("Complaints");
                });

            modelBuilder.Entity("Complaints.Models.Citizen", b =>
                {
                    b.Navigation("Complaints");
                });

            modelBuilder.Entity("Complaints.Models.Complaint", b =>
                {
                    b.Navigation("EmployeeComplaints");

                    b.Navigation("Responses");
                });

            modelBuilder.Entity("Complaints.Models.ComplaintType", b =>
                {
                    b.Navigation("ComplaintTypeContacts");
                });

            modelBuilder.Entity("Complaints.Models.Employee", b =>
                {
                    b.Navigation("EmployeeComplaints");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Complaints.Models.ResponseType", b =>
                {
                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
