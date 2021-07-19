using System;
using System.Collections.Generic;

#nullable disable

namespace StudentAPI.Models
{
    public partial class Student
    {
        public Student()
        {
            AcademicNotes = new HashSet<AcademicNote>();
            MissedTasks = new HashSet<MissedTask>();
            Notes = new HashSet<Note>();
            OrderHeaders = new HashSet<OrderHeader>();
            ParentContacts = new HashSet<ParentContact>();
            Parents = new HashSet<Parent>();
            PinnacleQuarterHeaders = new HashSet<PinnacleQuarterHeader>();
            PinnacleSemesters = new HashSet<PinnacleSemester>();
            PinnacleWeeklies = new HashSet<PinnacleWeekly>();
            StudentSigns = new HashSet<StudentSign>();
            StudentTeachers = new HashSet<StudentTeacher>();
            TeacherContacts = new HashSet<TeacherContact>();
            TestScores = new HashSet<TestScore>();
            WarreviewHeaders = new HashSet<WarreviewHeader>();
        }

        public int Id { get; set; }
        public string StudentId { get; set; }
        public int SchoolId { get; set; }
        public int? BankId { get; set; }
        public string CurrentGrade { get; set; }
        public string Mentor { get; set; }
        public bool? AllowedToWalkHome { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool? StudentInProbation { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }
        public DateTime? ActiveDate { get; set; }
        public string Reason { get; set; }
        public string PicFilename { get; set; }
        public DateTime? LastSignIn { get; set; }
        public DateTime? LastSignOut { get; set; }
        public DateTime? LastPointAdded { get; set; }
        public string LastAbsentReason { get; set; }
        public string AllergyDescription { get; set; }
        public string Email { get; set; }
        public bool? Iep { get; set; }
        public bool? Reteined { get; set; }
        public string ReteinedReason { get; set; }
        public string Apnotes { get; set; }
        public bool? Field504 { get; set; }
        public string Language { get; set; }
        public DateTime? InactiveDate { get; set; }
        public int? TutoringGroupId { get; set; }

        public virtual Banking Bank { get; set; }
        public virtual School School { get; set; }
        public virtual TutoringGroup TutoringGroup { get; set; }
        public virtual ICollection<AcademicNote> AcademicNotes { get; set; }
        public virtual ICollection<MissedTask> MissedTasks { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
        public virtual ICollection<ParentContact> ParentContacts { get; set; }
        public virtual ICollection<Parent> Parents { get; set; }
        public virtual ICollection<PinnacleQuarterHeader> PinnacleQuarterHeaders { get; set; }
        public virtual ICollection<PinnacleSemester> PinnacleSemesters { get; set; }
        public virtual ICollection<PinnacleWeekly> PinnacleWeeklies { get; set; }
        public virtual ICollection<StudentSign> StudentSigns { get; set; }
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
        public virtual ICollection<TeacherContact> TeacherContacts { get; set; }
        public virtual ICollection<TestScore> TestScores { get; set; }
        public virtual ICollection<WarreviewHeader> WarreviewHeaders { get; set; }
    }
}
