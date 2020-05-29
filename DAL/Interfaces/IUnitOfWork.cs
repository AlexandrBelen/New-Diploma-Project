using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryMain<User, string> RUsers { get; }
        IRepositoryMain<DirectorySpeciality, string> RSpecialities { get; }
        IRepositoryMain<Faculty, string> RFaculties { get; }
        IRepositoryMain<KnowledgeArea, string> RAreas { get; }
        IRepositoryOnlyGet<Role> RRoles { get; }
        IRepositoryMain<Specialization, string> RSpecialization { get; }
        IRepositoryMain<Cathedra, string> RCathedra { get; }
        IRepositoryMain<Cycle, string> RCycle { get; }
        IRepositoryMain<UnderCycle, string> RUnderCycle { get; }
        IRepositoryMain<Form_of_education, string> RFormEducation { get; }
        IRepositoryMain<FormDelivery, string> RFormDelivery { get; }
        IRepositoryMain<EducationalDegree, string> REducationalDegree { get; }
        IRepositoryMain<PlanEducationalProcess, string> RPlanEducationalProcess { get; }
        IRepositoryMain<Curriculum, string> RCurriculum { get; }


        //-------

        IRepositoryMain<AcademicTitle, string> RAcaTitles { get; }
        IRepositoryMain<AcademicYear, string> RAcaYears { get; }
        IRepositoryMain<BasicEducation, string> RBaseEduc { get; }
        IRepositoryMain<Classroom, string> RClassrooms { get; }
        IRepositoryMain<ClassroomType, string> RClassroomTypes { get; }
        IRepositoryMain<Gruppa, string> RGruppas { get; }
        IRepositoryMain<ParaNumber, string> RParas { get; }
        IRepositoryMain<Position, string> RPositions { get; }
        IRepositoryMain<Rank, string> RRanks { get; }
        IRepositoryMain<Semestr, string> RSemesters { get; }
        IRepositoryMain<Shedule, int> RShedules { get; }
        IRepositoryMain<Student, string> RStudents { get; }
        IRepositoryMain<StudentInfo, string> RStudentsInfo { get; }
        IRepositoryMain<Teacher, string> RTeachers { get; }
        IRepositoryMain<TeacherInfo, string> RTeachersInfo { get; }
        IRepositoryMain<TotalLoad, string> RTotalLoads { get; }
        IRepositoryMain<Week, string> RWeeks { get; }
        IRepositoryMain<WeekDay, string> RDays { get; }

        Task Save();
    }
}
