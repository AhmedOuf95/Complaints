using Complaints.Models;
using Microsoft.EntityFrameworkCore;

namespace Complaints.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<ComplaintFile> ComplaintFiles { get; set; }
        public DbSet<ComplaintStatus> ComplaintStatuses { get; set; }
        public DbSet<ComplaintType> ComplaintTypes { get; set; }
        //public DbSet<ComplaintTypeContact> ComplaintTypeContacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<EmployeeComplaint> EmployeeComplaints { get; set; }
        public DbSet<EmployeeCompNote> EmployeeCompNotes { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<ResponseType> ResponseTypes { get; set; }


        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
