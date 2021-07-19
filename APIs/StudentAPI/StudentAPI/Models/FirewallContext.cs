using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentAPI.Models
{
    public partial class FirewallContext : DbContext
    {
        public FirewallContext()
        {
        }

        public FirewallContext(DbContextOptions<FirewallContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcademicNote> AcademicNotes { get; set; }
        public virtual DbSet<Allapplication> Allapplications { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AttedanceReportDatum> AttedanceReportData { get; set; }
        public virtual DbSet<Banking> Bankings { get; set; }
        public virtual DbSet<BankingHistory> BankingHistories { get; set; }
        public virtual DbSet<Center> Centers { get; set; }
        public virtual DbSet<CenterCalendar> CenterCalendars { get; set; }
        public virtual DbSet<CenterSchool> CenterSchools { get; set; }
        public virtual DbSet<ClassList> ClassLists { get; set; }
        public virtual DbSet<CurrentApplication> CurrentApplications { get; set; }
        public virtual DbSet<CurrentApplications1> CurrentApplications1s { get; set; }
        public virtual DbSet<Exception> Exceptions { get; set; }
        public virtual DbSet<FingerPrintDatum> FingerPrintData { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MentorEmployeeLog> MentorEmployeeLogs { get; set; }
        public virtual DbSet<MentorNote> MentorNotes { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<MissedTask> MissedTasks { get; set; }
        public virtual DbSet<MissedTasksWar> MissedTasksWars { get; set; }
        public virtual DbSet<MovementTrsType> MovementTrsTypes { get; set; }
        public virtual DbSet<NewApplication> NewApplications { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<ParentContact> ParentContacts { get; set; }
        public virtual DbSet<PinnacleAbsence> PinnacleAbsences { get; set; }
        public virtual DbSet<PinnacleQuarterClass> PinnacleQuarterClasses { get; set; }
        public virtual DbSet<PinnacleQuarterHeader> PinnacleQuarterHeaders { get; set; }
        public virtual DbSet<PinnacleQuarterPoint> PinnacleQuarterPoints { get; set; }
        public virtual DbSet<PinnacleSemester> PinnacleSemesters { get; set; }
        public virtual DbSet<PinnacleWeekly> PinnacleWeeklies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductInventory> ProductInventories { get; set; }
        public virtual DbSet<ProductMovementTr> ProductMovementTrs { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        public virtual DbSet<RptAttendaceReport> RptAttendaceReports { get; set; }
        public virtual DbSet<RptStudentSdfreport> RptStudentSdfreports { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<SchoolCalendarYear> SchoolCalendarYears { get; set; }
        public virtual DbSet<SchoolYear> SchoolYears { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentSign> StudentSigns { get; set; }
        public virtual DbSet<StudentTeacher> StudentTeachers { get; set; }
        public virtual DbSet<StudentTeacherClass> StudentTeacherClasses { get; set; }
        public virtual DbSet<Studentnote> Studentnotes { get; set; }
        public virtual DbSet<SysAttendanceAverage> SysAttendanceAverages { get; set; }
        public virtual DbSet<SysClassCore> SysClassCores { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherClass> TeacherClasses { get; set; }
        public virtual DbSet<TeacherContact> TeacherContacts { get; set; }
        public virtual DbSet<TestScore> TestScores { get; set; }
        public virtual DbSet<TutoringGroup> TutoringGroups { get; set; }
        public virtual DbSet<UserSign> UserSigns { get; set; }
        public virtual DbSet<UserTime> UserTimes { get; set; }
        public virtual DbSet<Usercenter> Usercenters { get; set; }
        public virtual DbSet<WarReviewDetail> WarReviewDetails { get; set; }
        public virtual DbSet<WarreviewHeader> WarreviewHeaders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AcademicNote>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Note)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.AcademicNotes)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcademicNotes_Students");
            });

            modelBuilder.Entity<Allapplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ALLApplications");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AnnualHouseHoldIncome).HasMaxLength(50);

                entity.Property(e => e.ApplicationStatus).HasMaxLength(50);

                entity.Property(e => e.Apt).HasMaxLength(255);

                entity.Property(e => e.AttendingStudentName).HasMaxLength(512);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.Center).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Citybus).HasColumnName("citybus");

                entity.Property(e => e.CsOther).HasMaxLength(50);

                entity.Property(e => e.DeniedReason)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactLastName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactPhone).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactRelations).HasMaxLength(50);

                entity.Property(e => e.EmergencyNotes).HasMaxLength(50);

                entity.Property(e => e.EmergencyPhone).HasMaxLength(50);

                entity.Property(e => e.Ethnicity).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.HaauntUncle).HasColumnName("HAAuntUncle");

                entity.Property(e => e.Hafather).HasColumnName("HAFather");

                entity.Property(e => e.HafosterParent).HasColumnName("HAFosterParent");

                entity.Property(e => e.Hagrandparent).HasColumnName("HAGrandparent");

                entity.Property(e => e.Hamother).HasColumnName("HAMother");

                entity.Property(e => e.HastepFather).HasColumnName("HAStepFather");

                entity.Property(e => e.HastepMother).HasColumnName("HAStepMother");

                entity.Property(e => e.HearAboutUs).HasMaxLength(512);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.HouseHoldSize).HasMaxLength(50);

                entity.Property(e => e.HowFindAboutFirewall)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ibprogram).HasColumnName("IBProgram");

                entity.Property(e => e.IbprogramType)
                    .HasMaxLength(50)
                    .HasColumnName("IBProgramType");

                entity.Property(e => e.Iep503bplan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IEP503BPlan");

                entity.Property(e => e.IeplanType)
                    .HasMaxLength(50)
                    .HasColumnName("IEPlanType");

                entity.Property(e => e.Iepplan).HasColumnName("IEPPlan");

                entity.Property(e => e.InsuranceCarrier).HasMaxLength(50);

                entity.Property(e => e.Languages).HasMaxLength(50);

                entity.Property(e => e.Last4Ssn)
                    .HasMaxLength(50)
                    .HasColumnName("Last4SSN");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MaritalStuatus).HasMaxLength(50);

                entity.Property(e => e.MedicalConditionNotes).HasMaxLength(500);

                entity.Property(e => e.Mentor).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Parent2ContactMethod).HasMaxLength(50);

                entity.Property(e => e.Parent2Education).HasMaxLength(50);

                entity.Property(e => e.Parent2Email).HasMaxLength(50);

                entity.Property(e => e.Parent2LastName).HasMaxLength(50);

                entity.Property(e => e.Parent2Mobile).HasMaxLength(50);

                entity.Property(e => e.Parent2Name).HasMaxLength(50);

                entity.Property(e => e.Parent2Relationship).HasMaxLength(50);

                entity.Property(e => e.Parent2WorkPhone).HasMaxLength(50);

                entity.Property(e => e.ParentContactMethod).HasMaxLength(50);

                entity.Property(e => e.ParentEducatin).HasMaxLength(50);

                entity.Property(e => e.ParentEmail).HasMaxLength(50);

                entity.Property(e => e.ParentLastName).HasMaxLength(50);

                entity.Property(e => e.ParentMobile).HasMaxLength(50);

                entity.Property(e => e.ParentName).HasMaxLength(50);

                entity.Property(e => e.ParentRelationship).HasMaxLength(50);

                entity.Property(e => e.ParentWorkPhone).HasMaxLength(50);

                entity.Property(e => e.PickUp2LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp2Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp2Name).HasMaxLength(50);

                entity.Property(e => e.PickUp2Relations).HasMaxLength(50);

                entity.Property(e => e.PickUp3LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp3Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp3Name).HasMaxLength(50);

                entity.Property(e => e.PickUp3Relations).HasMaxLength(50);

                entity.Property(e => e.PickUpLastName).HasMaxLength(50);

                entity.Property(e => e.PickUpMobile).HasMaxLength(50);

                entity.Property(e => e.PickUpName).HasMaxLength(50);

                entity.Property(e => e.PickUpRelations).HasMaxLength(50);

                entity.Property(e => e.PolicyNumber).HasMaxLength(50);

                entity.Property(e => e.Race).HasMaxLength(50);

                entity.Property(e => e.ReferredBy).HasMaxLength(50);

                entity.Property(e => e.RetainedGrade).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.SchoolYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SignParente).HasMaxLength(50);

                entity.Property(e => e.Signature).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StudentCell).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(50);

                entity.Property(e => e.StudentLiveWith).HasMaxLength(50);

                entity.Property(e => e.TakingMedicationNotes).HasMaxLength(500);

                entity.Property(e => e.Tsicprogram).HasColumnName("TSICProgram");

                entity.Property(e => e.Tsictype)
                    .HasMaxLength(50)
                    .HasColumnName("TSICType");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AnnualHouseHoldIncome).HasMaxLength(50);

                entity.Property(e => e.ApplicationStatus).HasMaxLength(50);

                entity.Property(e => e.Apt).HasMaxLength(255);

                entity.Property(e => e.AttendingStudentName).HasMaxLength(512);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Citybus).HasColumnName("citybus");

                entity.Property(e => e.CsOther).HasMaxLength(50);

                entity.Property(e => e.DeniedReason)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactLastName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactPhone).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactRelations).HasMaxLength(50);

                entity.Property(e => e.EmergencyNotes).HasMaxLength(50);

                entity.Property(e => e.EmergencyPhone).HasMaxLength(50);

                entity.Property(e => e.Ethnicity).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.HaauntUncle).HasColumnName("HAAuntUncle");

                entity.Property(e => e.Hafather).HasColumnName("HAFather");

                entity.Property(e => e.HafosterParent).HasColumnName("HAFosterParent");

                entity.Property(e => e.Hagrandparent).HasColumnName("HAGrandparent");

                entity.Property(e => e.Hamother).HasColumnName("HAMother");

                entity.Property(e => e.HastepFather).HasColumnName("HAStepFather");

                entity.Property(e => e.HastepMother).HasColumnName("HAStepMother");

                entity.Property(e => e.HearAboutUs).HasMaxLength(512);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.HouseHoldSize).HasMaxLength(50);

                entity.Property(e => e.HowFindAboutFirewall)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ibprogram).HasColumnName("IBProgram");

                entity.Property(e => e.IbprogramType)
                    .HasMaxLength(50)
                    .HasColumnName("IBProgramType");

                entity.Property(e => e.Iep503bplan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IEP503BPlan");

                entity.Property(e => e.IeplanType)
                    .HasMaxLength(50)
                    .HasColumnName("IEPlanType");

                entity.Property(e => e.Iepplan).HasColumnName("IEPPlan");

                entity.Property(e => e.InsuranceCarrier).HasMaxLength(50);

                entity.Property(e => e.Languages).HasMaxLength(50);

                entity.Property(e => e.Last4Ssn)
                    .HasMaxLength(50)
                    .HasColumnName("Last4SSN");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MaritalStuatus).HasMaxLength(50);

                entity.Property(e => e.MedicalConditionNotes).HasMaxLength(500);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Parent2ContactMethod).HasMaxLength(50);

                entity.Property(e => e.Parent2Education).HasMaxLength(50);

                entity.Property(e => e.Parent2Email).HasMaxLength(50);

                entity.Property(e => e.Parent2LastName).HasMaxLength(50);

                entity.Property(e => e.Parent2Mobile).HasMaxLength(50);

                entity.Property(e => e.Parent2Name).HasMaxLength(50);

                entity.Property(e => e.Parent2Relationship).HasMaxLength(50);

                entity.Property(e => e.Parent2WorkPhone).HasMaxLength(50);

                entity.Property(e => e.ParentContactMethod).HasMaxLength(50);

                entity.Property(e => e.ParentEducatin).HasMaxLength(50);

                entity.Property(e => e.ParentEmail).HasMaxLength(50);

                entity.Property(e => e.ParentLastName).HasMaxLength(50);

                entity.Property(e => e.ParentMobile).HasMaxLength(50);

                entity.Property(e => e.ParentName).HasMaxLength(50);

                entity.Property(e => e.ParentRelationship).HasMaxLength(50);

                entity.Property(e => e.ParentWorkPhone).HasMaxLength(50);

                entity.Property(e => e.PickUp2LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp2Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp2Name).HasMaxLength(50);

                entity.Property(e => e.PickUp2Relations).HasMaxLength(50);

                entity.Property(e => e.PickUp3LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp3Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp3Name).HasMaxLength(50);

                entity.Property(e => e.PickUp3Relations).HasMaxLength(50);

                entity.Property(e => e.PickUpLastName).HasMaxLength(50);

                entity.Property(e => e.PickUpMobile).HasMaxLength(50);

                entity.Property(e => e.PickUpName).HasMaxLength(50);

                entity.Property(e => e.PickUpRelations).HasMaxLength(50);

                entity.Property(e => e.PolicyNumber).HasMaxLength(50);

                entity.Property(e => e.Race).HasMaxLength(50);

                entity.Property(e => e.ReferredBy).HasMaxLength(50);

                entity.Property(e => e.RetainedGrade).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.SchoolYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SignParente).HasMaxLength(50);

                entity.Property(e => e.Signature).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StudentCell).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(50);

                entity.Property(e => e.StudentLiveWith).HasMaxLength(50);

                entity.Property(e => e.TakingMedicationNotes).HasMaxLength(500);

                entity.Property(e => e.Tsicprogram).HasColumnName("TSICProgram");

                entity.Property(e => e.Tsictype)
                    .HasMaxLength(50)
                    .HasColumnName("TSICType");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmergencyContact).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactPhone).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Filename).HasMaxLength(512);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Relationship).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ZechUsername).HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AttedanceReportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.May1720211200am)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("May 17 2021 12:00AM");

                entity.Property(e => e.May1820211200am)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("May 18 2021 12:00AM");

                entity.Property(e => e.May1920211200am)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("May 19 2021 12:00AM");

                entity.Property(e => e.May2020211200am)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("May 20 2021 12:00AM");

                entity.Property(e => e.May2120211200am)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("May 21 2021 12:00AM");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(50);
            });

            modelBuilder.Entity<Banking>(entity =>
            {
                entity.ToTable("Banking");

                entity.Property(e => e.Checking)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Saving)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BankingHistory>(entity =>
            {
                entity.ToTable("BankingHistory");

                entity.Property(e => e.A).HasMaxLength(50);

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.B).HasMaxLength(50);

                entity.Property(e => e.C).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.S).HasMaxLength(50);

                entity.Property(e => e.TransType).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<Center>(entity =>
            {
                entity.Property(e => e.CloseHour).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OpenHour).HasMaxLength(50);
            });

            modelBuilder.Entity<CenterCalendar>(entity =>
            {
                entity.ToTable("CenterCalendar");

                entity.Property(e => e.AllCenters).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description")
                    .IsFixedLength(true);

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("startDate");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .HasColumnName("text");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CenterSchool>(entity =>
            {
                entity.ToTable("CenterSchool");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.CenterSchools)
                    .HasForeignKey(d => d.CenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterSchool_Centers");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.CenterSchools)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CenterSchool_Schools");
            });

            modelBuilder.Entity<ClassList>(entity =>
            {
                entity.ToTable("ClassList");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CurrentApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CurrentApplications");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AnnualHouseHoldIncome).HasMaxLength(50);

                entity.Property(e => e.ApplicationStatus).HasMaxLength(50);

                entity.Property(e => e.Apt).HasMaxLength(255);

                entity.Property(e => e.AttendingStudentName).HasMaxLength(512);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.Center).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Citybus).HasColumnName("citybus");

                entity.Property(e => e.CsOther).HasMaxLength(50);

                entity.Property(e => e.DeniedReason)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactLastName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactPhone).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactRelations).HasMaxLength(50);

                entity.Property(e => e.EmergencyNotes).HasMaxLength(50);

                entity.Property(e => e.EmergencyPhone).HasMaxLength(50);

                entity.Property(e => e.Ethnicity).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.HaauntUncle).HasColumnName("HAAuntUncle");

                entity.Property(e => e.Hafather).HasColumnName("HAFather");

                entity.Property(e => e.HafosterParent).HasColumnName("HAFosterParent");

                entity.Property(e => e.Hagrandparent).HasColumnName("HAGrandparent");

                entity.Property(e => e.Hamother).HasColumnName("HAMother");

                entity.Property(e => e.HastepFather).HasColumnName("HAStepFather");

                entity.Property(e => e.HastepMother).HasColumnName("HAStepMother");

                entity.Property(e => e.HearAboutUs).HasMaxLength(512);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.HouseHoldSize).HasMaxLength(50);

                entity.Property(e => e.HowFindAboutFirewall)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ibprogram).HasColumnName("IBProgram");

                entity.Property(e => e.IbprogramType)
                    .HasMaxLength(50)
                    .HasColumnName("IBProgramType");

                entity.Property(e => e.Iep503bplan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IEP503BPlan");

                entity.Property(e => e.IeplanType)
                    .HasMaxLength(50)
                    .HasColumnName("IEPlanType");

                entity.Property(e => e.Iepplan).HasColumnName("IEPPlan");

                entity.Property(e => e.InsuranceCarrier).HasMaxLength(50);

                entity.Property(e => e.Languages).HasMaxLength(50);

                entity.Property(e => e.Last4Ssn)
                    .HasMaxLength(50)
                    .HasColumnName("Last4SSN");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MaritalStuatus).HasMaxLength(50);

                entity.Property(e => e.MedicalConditionNotes).HasMaxLength(500);

                entity.Property(e => e.Mentor).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Parent2ContactMethod).HasMaxLength(50);

                entity.Property(e => e.Parent2Education).HasMaxLength(50);

                entity.Property(e => e.Parent2Email).HasMaxLength(50);

                entity.Property(e => e.Parent2LastName).HasMaxLength(50);

                entity.Property(e => e.Parent2Mobile).HasMaxLength(50);

                entity.Property(e => e.Parent2Name).HasMaxLength(50);

                entity.Property(e => e.Parent2Relationship).HasMaxLength(50);

                entity.Property(e => e.Parent2WorkPhone).HasMaxLength(50);

                entity.Property(e => e.ParentContactMethod).HasMaxLength(50);

                entity.Property(e => e.ParentEducatin).HasMaxLength(50);

                entity.Property(e => e.ParentEmail).HasMaxLength(50);

                entity.Property(e => e.ParentLastName).HasMaxLength(50);

                entity.Property(e => e.ParentMobile).HasMaxLength(50);

                entity.Property(e => e.ParentName).HasMaxLength(50);

                entity.Property(e => e.ParentRelationship).HasMaxLength(50);

                entity.Property(e => e.ParentWorkPhone).HasMaxLength(50);

                entity.Property(e => e.PickUp2LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp2Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp2Name).HasMaxLength(50);

                entity.Property(e => e.PickUp2Relations).HasMaxLength(50);

                entity.Property(e => e.PickUp3LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp3Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp3Name).HasMaxLength(50);

                entity.Property(e => e.PickUp3Relations).HasMaxLength(50);

                entity.Property(e => e.PickUpLastName).HasMaxLength(50);

                entity.Property(e => e.PickUpMobile).HasMaxLength(50);

                entity.Property(e => e.PickUpName).HasMaxLength(50);

                entity.Property(e => e.PickUpRelations).HasMaxLength(50);

                entity.Property(e => e.PolicyNumber).HasMaxLength(50);

                entity.Property(e => e.Race).HasMaxLength(50);

                entity.Property(e => e.ReferredBy).HasMaxLength(50);

                entity.Property(e => e.RetainedGrade).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.SchoolYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SignParente).HasMaxLength(50);

                entity.Property(e => e.Signature).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StudentCell).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(50);

                entity.Property(e => e.StudentLiveWith).HasMaxLength(50);

                entity.Property(e => e.TakingMedicationNotes).HasMaxLength(500);

                entity.Property(e => e.Tsicprogram).HasColumnName("TSICProgram");

                entity.Property(e => e.Tsictype)
                    .HasMaxLength(50)
                    .HasColumnName("TSICType");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<CurrentApplications1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CurrentApplications1");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AnnualHouseHoldIncome).HasMaxLength(50);

                entity.Property(e => e.ApplicationStatus).HasMaxLength(50);

                entity.Property(e => e.Apt).HasMaxLength(255);

                entity.Property(e => e.AttendingStudentName).HasMaxLength(512);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.Center).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Citybus).HasColumnName("citybus");

                entity.Property(e => e.CsOther).HasMaxLength(50);

                entity.Property(e => e.DeniedReason)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactLastName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactPhone).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactRelations).HasMaxLength(50);

                entity.Property(e => e.EmergencyNotes).HasMaxLength(50);

                entity.Property(e => e.EmergencyPhone).HasMaxLength(50);

                entity.Property(e => e.Ethnicity).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.HaauntUncle).HasColumnName("HAAuntUncle");

                entity.Property(e => e.Hafather).HasColumnName("HAFather");

                entity.Property(e => e.HafosterParent).HasColumnName("HAFosterParent");

                entity.Property(e => e.Hagrandparent).HasColumnName("HAGrandparent");

                entity.Property(e => e.Hamother).HasColumnName("HAMother");

                entity.Property(e => e.HastepFather).HasColumnName("HAStepFather");

                entity.Property(e => e.HastepMother).HasColumnName("HAStepMother");

                entity.Property(e => e.HearAboutUs).HasMaxLength(512);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.HouseHoldSize).HasMaxLength(50);

                entity.Property(e => e.HowFindAboutFirewall)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ibprogram).HasColumnName("IBProgram");

                entity.Property(e => e.IbprogramType)
                    .HasMaxLength(50)
                    .HasColumnName("IBProgramType");

                entity.Property(e => e.Iep503bplan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IEP503BPlan");

                entity.Property(e => e.IeplanType)
                    .HasMaxLength(50)
                    .HasColumnName("IEPlanType");

                entity.Property(e => e.Iepplan).HasColumnName("IEPPlan");

                entity.Property(e => e.InsuranceCarrier).HasMaxLength(50);

                entity.Property(e => e.Languages).HasMaxLength(50);

                entity.Property(e => e.Last4Ssn)
                    .HasMaxLength(50)
                    .HasColumnName("Last4SSN");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MaritalStuatus).HasMaxLength(50);

                entity.Property(e => e.MedicalConditionNotes).HasMaxLength(500);

                entity.Property(e => e.Mentor).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Parent2ContactMethod).HasMaxLength(50);

                entity.Property(e => e.Parent2Education).HasMaxLength(50);

                entity.Property(e => e.Parent2Email).HasMaxLength(50);

                entity.Property(e => e.Parent2LastName).HasMaxLength(50);

                entity.Property(e => e.Parent2Mobile).HasMaxLength(50);

                entity.Property(e => e.Parent2Name).HasMaxLength(50);

                entity.Property(e => e.Parent2Relationship).HasMaxLength(50);

                entity.Property(e => e.Parent2WorkPhone).HasMaxLength(50);

                entity.Property(e => e.ParentContactMethod).HasMaxLength(50);

                entity.Property(e => e.ParentEducatin).HasMaxLength(50);

                entity.Property(e => e.ParentEmail).HasMaxLength(50);

                entity.Property(e => e.ParentLastName).HasMaxLength(50);

                entity.Property(e => e.ParentMobile).HasMaxLength(50);

                entity.Property(e => e.ParentName).HasMaxLength(50);

                entity.Property(e => e.ParentRelationship).HasMaxLength(50);

                entity.Property(e => e.ParentWorkPhone).HasMaxLength(50);

                entity.Property(e => e.PickUp2LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp2Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp2Name).HasMaxLength(50);

                entity.Property(e => e.PickUp2Relations).HasMaxLength(50);

                entity.Property(e => e.PickUp3LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp3Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp3Name).HasMaxLength(50);

                entity.Property(e => e.PickUp3Relations).HasMaxLength(50);

                entity.Property(e => e.PickUpLastName).HasMaxLength(50);

                entity.Property(e => e.PickUpMobile).HasMaxLength(50);

                entity.Property(e => e.PickUpName).HasMaxLength(50);

                entity.Property(e => e.PickUpRelations).HasMaxLength(50);

                entity.Property(e => e.PolicyNumber).HasMaxLength(50);

                entity.Property(e => e.Race).HasMaxLength(50);

                entity.Property(e => e.ReferredBy).HasMaxLength(50);

                entity.Property(e => e.RetainedGrade).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.SchoolYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SignParente).HasMaxLength(50);

                entity.Property(e => e.Signature).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StudentCell).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(50);

                entity.Property(e => e.StudentLiveWith).HasMaxLength(50);

                entity.Property(e => e.TakingMedicationNotes).HasMaxLength(500);

                entity.Property(e => e.Tsicprogram).HasColumnName("TSICProgram");

                entity.Property(e => e.Tsictype)
                    .HasMaxLength(50)
                    .HasColumnName("TSICType");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Exception>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Entity).HasMaxLength(50);
            });

            modelBuilder.Entity<FingerPrintDatum>(entity =>
            {
                entity.Property(e => e.PersonId).HasMaxLength(50);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cmd)
                    .HasMaxLength(50)
                    .HasColumnName("cmd");

                entity.Property(e => e.CmdDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("cmd_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CmdPerson)
                    .HasMaxLength(100)
                    .HasColumnName("cmd_person")
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(100)
                    .HasColumnName("studentid");

                entity.Property(e => e.Tablecmd)
                    .HasMaxLength(100)
                    .HasColumnName("tablecmd");

                entity.Property(e => e.Teacherid)
                    .HasMaxLength(100)
                    .HasColumnName("teacherid");
            });

            modelBuilder.Entity<MentorEmployeeLog>(entity =>
            {
                entity.ToTable("MentorEmployeeLog");

                entity.Property(e => e.Consequences).HasMaxLength(512);

                entity.Property(e => e.DateLog).HasColumnType("datetime");

                entity.Property(e => e.EmployeeAction).HasMaxLength(512);

                entity.Property(e => e.SupervisorResponse).HasMaxLength(512);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.Username).HasMaxLength(512);
            });

            modelBuilder.Entity<MentorNote>(entity =>
            {
                entity.Property(e => e.DateLog).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(1500);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.UserName).HasMaxLength(512);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MissedTask>(entity =>
            {
                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Task).HasMaxLength(150);

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.MissedTasks)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_MissedTasks_Students");
            });

            modelBuilder.Entity<MissedTasksWar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MissedTasks(War's)");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Task).HasMaxLength(150);
            });

            modelBuilder.Entity<MovementTrsType>(entity =>
            {
                entity.ToTable("MovementTrsType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewApplication>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AnnualHouseHoldIncome).HasMaxLength(50);

                entity.Property(e => e.ApplicationStatus).HasMaxLength(50);

                entity.Property(e => e.Apt).HasMaxLength(255);

                entity.Property(e => e.AttendingStudentName).HasMaxLength(512);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Citybus).HasColumnName("citybus");

                entity.Property(e => e.CsOther).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactLastName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactName).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactPhone).HasMaxLength(50);

                entity.Property(e => e.EmergencyContactRelations).HasMaxLength(50);

                entity.Property(e => e.EmergencyNotes).HasMaxLength(50);

                entity.Property(e => e.EmergencyPhone).HasMaxLength(50);

                entity.Property(e => e.Ethnicity).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.HaauntUncle).HasColumnName("HAAuntUncle");

                entity.Property(e => e.Hafather).HasColumnName("HAFather");

                entity.Property(e => e.HafosterParent).HasColumnName("HAFosterParent");

                entity.Property(e => e.Hagrandparent).HasColumnName("HAGrandparent");

                entity.Property(e => e.Hamother).HasColumnName("HAMother");

                entity.Property(e => e.HastepFather).HasColumnName("HAStepFather");

                entity.Property(e => e.HastepMother).HasColumnName("HAStepMother");

                entity.Property(e => e.HearAboutUs).HasMaxLength(512);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.HouseHoldSize).HasMaxLength(50);

                entity.Property(e => e.Ibprogram).HasColumnName("IBProgram");

                entity.Property(e => e.IbprogramType)
                    .HasMaxLength(50)
                    .HasColumnName("IBProgramType");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IeplanType)
                    .HasMaxLength(50)
                    .HasColumnName("IEPlanType");

                entity.Property(e => e.Iepplan).HasColumnName("IEPPlan");

                entity.Property(e => e.InsuranceCarrier).HasMaxLength(50);

                entity.Property(e => e.Languages).HasMaxLength(50);

                entity.Property(e => e.Last4Ssn)
                    .HasMaxLength(50)
                    .HasColumnName("Last4SSN");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MaritalStuatus).HasMaxLength(50);

                entity.Property(e => e.MedicalConditionNotes).HasMaxLength(500);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Parent2ContactMethod).HasMaxLength(50);

                entity.Property(e => e.Parent2Education).HasMaxLength(50);

                entity.Property(e => e.Parent2Email).HasMaxLength(50);

                entity.Property(e => e.Parent2LastName).HasMaxLength(50);

                entity.Property(e => e.Parent2Mobile).HasMaxLength(50);

                entity.Property(e => e.Parent2Name).HasMaxLength(50);

                entity.Property(e => e.Parent2Relationship).HasMaxLength(50);

                entity.Property(e => e.Parent2WorkPhone).HasMaxLength(50);

                entity.Property(e => e.ParentContactMethod).HasMaxLength(50);

                entity.Property(e => e.ParentEducatin).HasMaxLength(50);

                entity.Property(e => e.ParentEmail).HasMaxLength(50);

                entity.Property(e => e.ParentLastName).HasMaxLength(50);

                entity.Property(e => e.ParentMobile).HasMaxLength(50);

                entity.Property(e => e.ParentName).HasMaxLength(50);

                entity.Property(e => e.ParentRelationship).HasMaxLength(50);

                entity.Property(e => e.ParentWorkPhone).HasMaxLength(50);

                entity.Property(e => e.PickUp2LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp2Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp2Name).HasMaxLength(50);

                entity.Property(e => e.PickUp2Relations).HasMaxLength(50);

                entity.Property(e => e.PickUp3LastName).HasMaxLength(50);

                entity.Property(e => e.PickUp3Mobile).HasMaxLength(50);

                entity.Property(e => e.PickUp3Name).HasMaxLength(50);

                entity.Property(e => e.PickUp3Relations).HasMaxLength(50);

                entity.Property(e => e.PickUpLastName).HasMaxLength(50);

                entity.Property(e => e.PickUpMobile).HasMaxLength(50);

                entity.Property(e => e.PickUpName).HasMaxLength(50);

                entity.Property(e => e.PickUpRelations).HasMaxLength(50);

                entity.Property(e => e.PolicyNumber).HasMaxLength(50);

                entity.Property(e => e.Race).HasMaxLength(50);

                entity.Property(e => e.RetainedGrade).HasMaxLength(50);

                entity.Property(e => e.School).HasMaxLength(50);

                entity.Property(e => e.SchoolYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.SignParente).HasMaxLength(50);

                entity.Property(e => e.Signature).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StudentCell).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(50);

                entity.Property(e => e.StudentLiveWith).HasMaxLength(50);

                entity.Property(e => e.TakingMedicationNotes).HasMaxLength(500);

                entity.Property(e => e.Tsicprogram).HasColumnName("TSICProgram");

                entity.Property(e => e.Tsictype)
                    .HasMaxLength(50)
                    .HasColumnName("TSICType");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Note1)
                    .HasMaxLength(1000)
                    .HasColumnName("Note");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Notes_Students");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.Brand)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrderHeader)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_OrderHeaders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Product");
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.OrderHeaders)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_OrderHeaders_Students");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Relation).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Parents_Students");
            });

            modelBuilder.Entity<ParentContact>(entity =>
            {
                entity.ToTable("ParentContact");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ParentContacts)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_ParentContact_Students");
            });

            modelBuilder.Entity<PinnacleAbsence>(entity =>
            {
                entity.ToTable("PinnacleAbsence");

                entity.Property(e => e.AlttoSuspension).HasMaxLength(50);

                entity.Property(e => e.ExcusedAbsence).HasMaxLength(50);

                entity.Property(e => e.ExternalSuspension).HasMaxLength(50);

                entity.Property(e => e.InternalSuspension).HasMaxLength(50);

                entity.Property(e => e.Quarter).HasMaxLength(50);

                entity.Property(e => e.SchoolYear).HasMaxLength(50);

                entity.Property(e => e.UnexcusedAbsense).HasMaxLength(50);
            });

            modelBuilder.Entity<PinnacleQuarterClass>(entity =>
            {
                entity.ToTable("PinnacleQuarterClass");

                entity.Property(e => e.Credits).HasMaxLength(50);

                entity.Property(e => e.FinalGrade).HasMaxLength(50);

                entity.Property(e => e.FinalGrade1Quarter).HasMaxLength(50);

                entity.Property(e => e.FinalGrade2Quarter).HasMaxLength(50);

                entity.Property(e => e.FinalGrade3Quarter).HasMaxLength(50);

                entity.Property(e => e.FinalGrade4Quarter).HasMaxLength(50);

                entity.Property(e => e.Grade1Quarter).HasMaxLength(50);

                entity.Property(e => e.Grade2Quarter).HasMaxLength(50);

                entity.Property(e => e.Grade3Quarter).HasMaxLength(50);

                entity.Property(e => e.Grade4Quarter).HasMaxLength(50);

                entity.Property(e => e.Pinnacle1Quarter).HasMaxLength(50);

                entity.Property(e => e.Pinnacle2Quarter).HasMaxLength(50);

                entity.Property(e => e.Pinnacle3Quarter).HasMaxLength(50);

                entity.Property(e => e.Pinnacle4Quarter).HasMaxLength(50);

                entity.Property(e => e.Points1Quarter).HasMaxLength(50);

                entity.Property(e => e.Points2Quarter).HasMaxLength(50);

                entity.Property(e => e.Points3Quarter).HasMaxLength(50);

                entity.Property(e => e.Points4Quarter).HasMaxLength(50);

                entity.HasOne(d => d.PinnacleQuarterHeader)
                    .WithMany(p => p.PinnacleQuarterClasses)
                    .HasForeignKey(d => d.PinnacleQuarterHeaderId)
                    .HasConstraintName("FK_PinnacleQuarterClass_PinnacleQuarterHeader");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.PinnacleQuarterClasses)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_PinnacleQuarterClass_TeacherClass");
            });

            modelBuilder.Entity<PinnacleQuarterHeader>(entity =>
            {
                entity.ToTable("PinnacleQuarterHeader");

                entity.Property(e => e.SchoolYear).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PinnacleQuarterHeaders)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PinnacleQuarterHeader_Students");
            });

            modelBuilder.Entity<PinnacleQuarterPoint>(entity =>
            {
                entity.Property(e => e.Points).HasMaxLength(50);

                entity.Property(e => e.Quarter).HasMaxLength(50);

                entity.HasOne(d => d.PinnacleQuarterHeader)
                    .WithMany(p => p.PinnacleQuarterPoints)
                    .HasForeignKey(d => d.PinnacleQuarterHeaderId)
                    .HasConstraintName("FK_PinnacleQuarterPoints_PinnacleQuarterHeader");
            });

            modelBuilder.Entity<PinnacleSemester>(entity =>
            {
                entity.ToTable("PinnacleSemester");

                entity.Property(e => e.ExGrade1Semester).HasMaxLength(50);

                entity.Property(e => e.ExGrade2Semester).HasMaxLength(50);

                entity.Property(e => e.Grade1Quarter).HasMaxLength(50);

                entity.Property(e => e.Grade2Quarter).HasMaxLength(50);

                entity.Property(e => e.Grade3Quarter).HasMaxLength(50);

                entity.Property(e => e.Grade4Quarter).HasMaxLength(50);

                entity.Property(e => e.Pinnacle1Quarter).HasMaxLength(50);

                entity.Property(e => e.Pinnacle2Quarter).HasMaxLength(50);

                entity.Property(e => e.Pinnacle3Quarter).HasMaxLength(50);

                entity.Property(e => e.Pinnacle4Quarter).HasMaxLength(50);

                entity.Property(e => e.Points1Quarter).HasMaxLength(50);

                entity.Property(e => e.Points2Quarter).HasMaxLength(50);

                entity.Property(e => e.Points3Quarter).HasMaxLength(50);

                entity.Property(e => e.Points4Quarter).HasMaxLength(50);

                entity.Property(e => e.SchoolYear).HasMaxLength(50);

                entity.Property(e => e.SemGrade1Semester)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SemGrade2Semester).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PinnacleSemesters)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PinnacleSemester_Students");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.PinnacleSemesters)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_PinnacleSemester_TeacherClass");
            });

            modelBuilder.Entity<PinnacleWeekly>(entity =>
            {
                entity.ToTable("PinnacleWeekly");

                entity.Property(e => e.ExamGrade)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FinalGrade).HasMaxLength(50);

                entity.Property(e => e.Goal).HasMaxLength(50);

                entity.Property(e => e.Quarter).HasMaxLength(50);

                entity.Property(e => e.SchoolYear).HasMaxLength(50);

                entity.Property(e => e.W1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.W10)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W101)
                    .HasMaxLength(50)
                    .HasColumnName("W10_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W11)
                    .HasMaxLength(50)
                    .HasColumnName("W1_")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.W111)
                    .HasMaxLength(50)
                    .HasColumnName("W11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W112)
                    .HasMaxLength(50)
                    .HasColumnName("W11_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W21)
                    .HasMaxLength(50)
                    .HasColumnName("W2_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W3)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W31)
                    .HasMaxLength(50)
                    .HasColumnName("W3_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W4)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W41)
                    .HasMaxLength(50)
                    .HasColumnName("W4_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W5)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W51)
                    .HasMaxLength(50)
                    .HasColumnName("W5_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W6)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W61)
                    .HasMaxLength(50)
                    .HasColumnName("W6_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W7)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W71)
                    .HasMaxLength(50)
                    .HasColumnName("W7_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W8)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W81)
                    .HasMaxLength(50)
                    .HasColumnName("W8_")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W9)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.W91)
                    .HasMaxLength(50)
                    .HasColumnName("W9_")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.PinnacleWeeklies)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PinnacleWeekly_Students");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.PinnacleWeeklies)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_PinnacleWeekly_TeacherClass");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgFileName).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Product_Category");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("Product_Category");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductInventory>(entity =>
            {
                entity.ToTable("Product_Inventory");

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.ProductInventories)
                    .HasForeignKey(d => d.CenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Inventory_Centers");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductInventories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Inventory_Product");
            });

            modelBuilder.Entity<ProductMovementTr>(entity =>
            {
                entity.ToTable("Product_MovementTrs");

                entity.HasOne(d => d.FromLocationNavigation)
                    .WithMany(p => p.ProductMovementTrFromLocationNavigations)
                    .HasForeignKey(d => d.FromLocation)
                    .HasConstraintName("FK_Product_MovementTrs_Centers");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductMovementTrs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_MovementTrs_Product");

                entity.HasOne(d => d.ToLocationNavigation)
                    .WithMany(p => p.ProductMovementTrToLocationNavigations)
                    .HasForeignKey(d => d.ToLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_MovementTrs_Centers1");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ProductMovementTrs)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_MovementTrs_MovementTrsType");
            });

            modelBuilder.Entity<Query>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Query");

                entity.Property(e => e.Date).HasPrecision(3);

                entity.Property(e => e.Description)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.ModeOfContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RptAttendaceReport>(entity =>
            {
                entity.ToTable("RPT_AttendaceReport");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Fullname).HasMaxLength(101);

                entity.Property(e => e.SchoolName).HasMaxLength(50);

                entity.Property(e => e.SchoolYear).HasMaxLength(101);

                entity.Property(e => e.StudentId).HasMaxLength(50);
            });

            modelBuilder.Entity<RptStudentSdfreport>(entity =>
            {
                entity.ToTable("RPT_StudentSDFReport");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullNameStudent).HasMaxLength(154);

                entity.Property(e => e.Fullnameteacher).HasMaxLength(101);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Quarter).HasMaxLength(50);

                entity.Property(e => e.SchoolYear).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(50);

                entity.Property(e => e.Weekname)
                    .HasMaxLength(128)
                    .HasColumnName("weekname");

                entity.Property(e => e.Weekvalue)
                    .HasMaxLength(50)
                    .HasColumnName("weekvalue");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SchoolCalendarYear>(entity =>
            {
                entity.ToTable("SchoolCalendarYear");

                entity.Property(e => e._1quarterEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("1QuarterEnd");

                entity.Property(e => e._1quarterStart)
                    .HasColumnType("datetime")
                    .HasColumnName("1QuarterStart");

                entity.Property(e => e._2quarterEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("2QuarterEnd");

                entity.Property(e => e._2quarterStart)
                    .HasColumnType("datetime")
                    .HasColumnName("2QuarterStart");

                entity.Property(e => e._3quarterEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("3QuarterEnd");

                entity.Property(e => e._3quarterStart)
                    .HasColumnType("datetime")
                    .HasColumnName("3QuarterStart");

                entity.Property(e => e._4quarterEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("4QuarterEnd");

                entity.Property(e => e._4quarterStart)
                    .HasColumnType("datetime")
                    .HasColumnName("4QuarterStart");
            });

            modelBuilder.Entity<SchoolYear>(entity =>
            {
                entity.ToTable("SchoolYear");

                entity.Property(e => e.SchoolYear1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SchoolYear");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.ActiveDate).HasColumnType("datetime");

                entity.Property(e => e.Address).HasMaxLength(512);

                entity.Property(e => e.AllergyDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Apnotes)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("APNotes");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CurrentGrade).HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Iep).HasColumnName("IEP");

                entity.Property(e => e.InactiveDate).HasColumnType("datetime");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastAbsentReason).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LastPointAdded).HasColumnType("date");

                entity.Property(e => e.LastSignIn).HasColumnType("datetime");

                entity.Property(e => e.LastSignOut).HasColumnType("datetime");

                entity.Property(e => e.Mentor).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.ReteinedReason)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Students_Banking");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Students_Schools");

                entity.HasOne(d => d.TutoringGroup)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.TutoringGroupId)
                    .HasConstraintName("FK_Students_TutoringGroup");
            });

            modelBuilder.Entity<StudentSign>(entity =>
            {
                entity.ToTable("StudentSign");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilterDate).HasColumnType("datetime");

                entity.Property(e => e.LastSignIn).HasColumnType("datetime");

                entity.Property(e => e.LastSignOut).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentSigns)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_StudentSign_Students");
            });

            modelBuilder.Entity<StudentTeacher>(entity =>
            {
                entity.ToTable("StudentTeacher");

                entity.Property(e => e.SchoolYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentTeachers)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentTeacher_Students");

                entity.HasOne(d => d.TeacherClass)
                    .WithMany(p => p.StudentTeachers)
                    .HasForeignKey(d => d.TeacherClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentTeacher_TeacherClass1");
            });

            modelBuilder.Entity<StudentTeacherClass>(entity =>
            {
                entity.ToTable("StudentTeacherClass");

                entity.Property(e => e.SchoolYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Studentnote>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("studentnotes");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Mentor).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(1000);
            });

            modelBuilder.Entity<SysAttendanceAverage>(entity =>
            {
                entity.ToTable("sys_AttendanceAverage");

                entity.Property(e => e.StudentId).HasMaxLength(50);
            });

            modelBuilder.Entity<SysClassCore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_ClassCore");

                entity.Property(e => e.ClassCore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Teachers_Schools");
            });

            modelBuilder.Entity<TeacherClass>(entity =>
            {
                entity.ToTable("TeacherClass");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TeacherClasses)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_TeacherClass_ClassList");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherClasses)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_TeacherClass_Teachers1");
            });

            modelBuilder.Entity<TeacherContact>(entity =>
            {
                entity.ToTable("TeacherContact");

                entity.Property(e => e.ContactDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.ModeOfContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quarter).HasMaxLength(50);

                entity.Property(e => e.TeacherClass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherFullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SchoolYear)
                    .WithMany(p => p.TeacherContacts)
                    .HasForeignKey(d => d.SchoolYearId)
                    .HasConstraintName("FK_TeacherContact_SchoolYear");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TeacherContacts)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_TeacherContact_Students");
            });

            modelBuilder.Entity<TestScore>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Levels).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ndpercentile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NDPercentile");

                entity.Property(e => e.Score).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TestName).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TestScores)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_TestScores_Students");
            });

            modelBuilder.Entity<TutoringGroup>(entity =>
            {
                entity.ToTable("TutoringGroup");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserSign>(entity =>
            {
                entity.ToTable("UserSign");

                entity.Property(e => e.LastSignIn).HasColumnType("datetime");

                entity.Property(e => e.LastSignOut).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<UserTime>(entity =>
            {
                entity.ToTable("UserTime");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.End)
                    .HasColumnType("datetime")
                    .HasColumnName("end");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");

                entity.Property(e => e.Userid)
                    .HasMaxLength(128)
                    .HasColumnName("userid");

                entity.Property(e => e.Weekend).HasColumnName("weekend");
            });

            modelBuilder.Entity<Usercenter>(entity =>
            {
                entity.ToTable("usercenters");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Center)
                    .WithMany(p => p.Usercenters)
                    .HasForeignKey(d => d.CenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usercenters_Centers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Usercenters)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usercenters_AspNetUsers");
            });

            modelBuilder.Entity<WarReviewDetail>(entity =>
            {
                entity.Property(e => e.HomeWork)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.WarreviewHeaderId).HasColumnName("WARReviewHeaderId");

                entity.HasOne(d => d.WarreviewHeader)
                    .WithMany(p => p.WarReviewDetails)
                    .HasForeignKey(d => d.WarreviewHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarReviewDetails_WARReviewHeader");
            });

            modelBuilder.Entity<WarreviewHeader>(entity =>
            {
                entity.ToTable("WARReviewHeader");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.WarreviewHeaders)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_WARReviewHeader_Students");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
