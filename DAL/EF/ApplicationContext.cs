using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DAL.Entities;
using System.Security.Cryptography.X509Certificates;

namespace DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions connectionString) : base(connectionString)
        {

        }


        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Cathedra> Cathedra { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<KnowledgeArea> KnowledgeAreas { get; set; }
        public virtual DbSet<DirectorySpeciality> DirectorySpecialitys { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Cycle> Cycles { get; set; }
        public virtual DbSet<UnderCycle> UnderCycles { get; set; }
        public virtual DbSet<Form_of_education> Form_Of_Educations { get; set; }
        public virtual DbSet<FormDelivery> FormDeliveries { get; set; }
        public virtual DbSet<EducationalDegree> EducationalDegrees { get; set; }
        public virtual DbSet<Curriculum> Curriculums { get; set; }
        public virtual DbSet<PlanEducationalProcess> PlanEducationalProcesses { get; set; }

        //----------------
        public virtual DbSet<AcademicTitle> AcademicTitles { get; set; }
        public virtual DbSet<AcademicYear> AcademicYears { get; set; }
        public virtual DbSet<BasicEducation> BasicEducations { get; set; }
        public virtual DbSet<Cathedra> Cathedras { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<ClassroomType> ClassroomTypes { get; set; }
        public virtual DbSet<Curriculum> Curricula { get; set; }
        public virtual DbSet<WeekDay> WeekDays { get; set; }
        public virtual DbSet<DirectorySpeciality> DirectorySpecialities { get; set; }
        public virtual DbSet<Gruppa> Gruppas { get; set; }
        public virtual DbSet<ParaNumber> ParaNumbers { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Semestr> Semestrs { get; set; }
        public virtual DbSet<Shedule> Shedules { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentInfo> StudentInfoes { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherInfo> TeacherInfoes { get; set; }
        public virtual DbSet<TotalLoad> TotalLoads { get; set; }
        public virtual DbSet<Week> Weeks { get; set; }

        //----------------

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.ID_user);
            modelBuilder.Entity<Faculty>().HasKey(x => x.IdFaculty);
            modelBuilder.Entity<KnowledgeArea>().HasKey(x => x.IdArea);
            modelBuilder.Entity<DirectorySpeciality>().HasKey(x => x.IdSpeciality);
            modelBuilder.Entity<Cathedra>().HasKey(x => x.IdCathedra);
            modelBuilder.Entity<Specialization>().HasKey(x => x.ID_Specialization);
            modelBuilder.Entity<Cycle>().HasKey(x => x.IdCycle);
            modelBuilder.Entity<UnderCycle>().HasKey(x => x.IdUnderCycle);
            modelBuilder.Entity<Form_of_education>().HasKey(x => x.IdFormEducation);
            modelBuilder.Entity<FormDelivery>().HasKey(x => x.IdDelivery);
            modelBuilder.Entity<Curriculum>().HasKey(x => x.IDCurriculum);
            modelBuilder.Entity<PlanEducationalProcess>().HasKey(x => x.ID_PlanEducationalProcess);

            //--------------------------


            modelBuilder.Entity<AcademicTitle>().HasKey(x => x.IdAcademicTitle);
            modelBuilder.Entity<AcademicYear>().HasKey(x => x.IdYear);
            modelBuilder.Entity<ClassroomType>().HasKey(x => x.IdType);
            modelBuilder.Entity<Faculty>().HasKey(x => x.IdFaculty);
            modelBuilder.Entity<KnowledgeArea>().HasKey(x => x.IdArea);
            modelBuilder.Entity<ParaNumber>().HasKey(x => x.IdPara);
            modelBuilder.Entity<Position>().HasKey(x => x.IdPosition);
            modelBuilder.Entity<Rank>().HasKey(x => x.IdRank);
            modelBuilder.Entity<Semestr>().HasKey(x => x.IdSemestr);
            modelBuilder.Entity<StudentInfo>().HasKey(x => x.stundtInfoID);
            modelBuilder.Entity<Week>().HasKey(x => x.IdWeek);
            modelBuilder.Entity<WeekDay>().HasKey(x => x.IdDay);


            base.OnModelCreating(modelBuilder);
        }
    }
}
