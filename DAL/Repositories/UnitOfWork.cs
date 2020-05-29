using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext context;
        
        private UserRepository userRepository;
        private CathedraRepository cathedra;
        private SpecializationRepository specialization;
        private DirectorySpecialityRepository speciality;
        private FacultyRepository faculty;
        private KnowledgeAreaRepository area;
        private RoleRepository rolesOFWork;
        private FormDeliveryRepository formDeliverys;
        private Form_of_educationRepository formEducation;
        private CycleRepository cycles;
        private UnderCycleRepository underCycles;
        private EducationalDegreeRepository degrees;
        private PlanEducationalProcessRepository planEducationalProcess;
        private CurriculumRepository curriculums;

        //-----
        private AcademicTitleRepository academic;
        private AcademicYearRepository year;
        private BasicEducationRepository basic;
        private ClassroomRepository classroom;
        private ClassroomTypeRepository type;
        private GruppaRepository gruppa;
        private ParaNumberRepository para;
        private PositionRepository position;
        private RankRepository rank;
        private SemestrRepository semestr;
        private SheduleRepository shedule;
        private WeekDayRepository day;
        private WeekRepository week;
        private RoleRepository role;
        private StudentInfoRepository info;
        private StudentRepository student;
        private TeacherInfoRepository t_info;
        private TeacherRepository teacher;
        private TotalLoadRepository total;




        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public UnitOfWork(DbContextOptions connectionString)
        {
            context = new ApplicationContext(connectionString);
        }

        public IRepositoryMain<User, string> RUsers
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(context);
                return userRepository;
            }
        }
        

        public IRepositoryOnlyGet<Role> RRoles
        {
            get
            {
                if (rolesOFWork == null)
                    rolesOFWork = new RoleRepository(context);
                return rolesOFWork;
            }
        }

        public IRepositoryMain<DirectorySpeciality, string> RSpecialities
        {
            get
            {
                if (speciality == null)
                    speciality = new DirectorySpecialityRepository(context);
                return speciality;
            }
        }

        public IRepositoryMain<Faculty, string> RFaculties
        {
            get
            {
                if (faculty == null)
                    faculty = new FacultyRepository(context);
                return faculty;
            }
        }

        public IRepositoryMain<KnowledgeArea, string> RAreas
        {
            get
            {
                if (area == null)
                    area = new KnowledgeAreaRepository(context);
                return area;
            }
        }

        public IRepositoryMain<Cathedra, string> RCathedra
        {
            get
            {
                if (cathedra == null)
                    cathedra = new CathedraRepository(context);
                return cathedra;
            }
        }

        public IRepositoryMain<Specialization, string> RSpecialization
        {
            get
            {
                if (specialization == null)
                    specialization = new SpecializationRepository(context);
                return specialization;
            }
        }

        public IRepositoryMain<Cycle, string> RCycle
        {
            get
            {
                if (cycles == null)
                    cycles = new CycleRepository(context);
                return cycles;
            }
        }
        public IRepositoryMain<UnderCycle, string> RUnderCycle
        {
            get
            {
                if (underCycles == null)
                    underCycles = new UnderCycleRepository(context);
                return underCycles;
            }
        }

        public IRepositoryMain<Form_of_education, string> RFormEducation
        {
            get
            {
                if (formEducation == null)
                    formEducation = new Form_of_educationRepository(context);
                return formEducation;
            }
        }

        public IRepositoryMain<FormDelivery, string> RFormDelivery
        {
            get
            {
                if (formDeliverys == null)
                    formDeliverys = new FormDeliveryRepository(context);
                return formDeliverys;
            }
        }

        public IRepositoryMain<EducationalDegree, string> REducationalDegree
        {
            get
            {
                if (degrees == null)
                    degrees = new EducationalDegreeRepository(context);
                return degrees;
            }
        }

        public IRepositoryMain<PlanEducationalProcess, string> RPlanEducationalProcess
        {
            get
            {
                if (planEducationalProcess == null)
                    planEducationalProcess = new PlanEducationalProcessRepository(context);
                return planEducationalProcess;
            }
        }

        public IRepositoryMain<Curriculum, string> RCurriculum
        {
            get
            {
                if (curriculums == null)
                    curriculums = new CurriculumRepository(context);
                return curriculums;
            }
        }

        //------
        public IRepositoryMain<AcademicTitle, string> RAcaTitles
        {
            get
            {
                if (academic == null)
                    academic = new AcademicTitleRepository(context);
                return academic;
            }
        }

        public IRepositoryMain<AcademicYear, string> RAcaYears
        {
            get
            {
                if (year == null)
                    year = new AcademicYearRepository(context);
                return year;
            }
        }

        public IRepositoryMain<BasicEducation, string> RBaseEduc
        {
            get
            {
                if (basic == null)
                    basic = new BasicEducationRepository(context);
                return basic;
            }
        }


        public IRepositoryMain<Classroom, string> RClassrooms
        {
            get
            {
                if (classroom == null)
                    classroom = new ClassroomRepository(context);
                return classroom;
            }
        }

        public IRepositoryMain<ClassroomType, string> RClassroomTypes
        {
            get
            {
                if (type == null)
                    type = new ClassroomTypeRepository(context);
                return type;
            }
        }

      


      

      

      

   

      
        public IRepositoryMain<Gruppa, string> RGruppas
        {
            get
            {
                if (gruppa == null)
                    gruppa = new GruppaRepository(context);
                return gruppa;
            }
        }

       

        public IRepositoryMain<ParaNumber, string> RParas
        {
            get
            {
                if (para == null)
                    para = new ParaNumberRepository(context);
                return para;
            }
        }

        public IRepositoryMain<Position, string> RPositions
        {
            get
            {
                if (position == null)
                    position = new PositionRepository(context);
                return position;
            }
        }

        

        public IRepositoryMain<Rank, string> RRanks
        {
            get
            {
                if (rank == null)
                    rank = new RankRepository(context);
                return rank;
            }
        }

      

        public IRepositoryMain<Semestr, string> RSemesters
        {
            get
            {
                if (semestr == null)
                    semestr = new SemestrRepository(context);
                return semestr;
            }
        }

        public IRepositoryMain<Shedule, int> RShedules
        {
            get
            {
                if (shedule == null)
                    shedule = new SheduleRepository(context);
                return shedule;
            }
        }

        public IRepositoryMain<StudentInfo, string> RStudentsInfo
        {
            get
            {
                if (info == null)
                    info = new StudentInfoRepository(context);
                return info;
            }
        }

        public IRepositoryMain<Student, string> RStudents
        {
            get
            {
                if (student == null)
                    student = new StudentRepository(context);
                return student;
            }
        }

        public IRepositoryMain<TeacherInfo, string> RTeachersInfo
        {
            get
            {
                if (t_info == null)
                    t_info = new TeacherInfoRepository(context);
                return t_info;
            }
        }

        public IRepositoryMain<Teacher, string> RTeachers
        {
            get
            {
                if (teacher == null)
                    teacher = new TeacherRepository(context);
                return teacher;
            }
        }

        public IRepositoryMain<TotalLoad, string> RTotalLoads
        {
            get
            {
                if (total == null)
                    total = new TotalLoadRepository(context);
                return total;
            }
        }

      

        public IRepositoryMain<Week, string> RWeeks
        {
            get
            {
                if (week == null)
                    week = new WeekRepository(context);
                return week;
            }
        }

        public IRepositoryMain<WeekDay, string> RDays
        {
            get
            {
                if (day == null)
                    day = new WeekDayRepository(context);
                return day;
            }
        }

        //------



        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}
