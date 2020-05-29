using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicTitles",
                columns: table => new
                {
                    IdAcademicTitle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    academicTitleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicTitles", x => x.IdAcademicTitle);
                });

            migrationBuilder.CreateTable(
                name: "AcademicYears",
                columns: table => new
                {
                    IdYear = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicYears", x => x.IdYear);
                });

            migrationBuilder.CreateTable(
                name: "ClassroomTypes",
                columns: table => new
                {
                    IdType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomTypes", x => x.IdType);
                });

            migrationBuilder.CreateTable(
                name: "Cycles",
                columns: table => new
                {
                    IdCycle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCycle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cycles", x => x.IdCycle);
                });

            migrationBuilder.CreateTable(
                name: "EducationalDegrees",
                columns: table => new
                {
                    IdDegree = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    degreeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalDegrees", x => x.IdDegree);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    IdFaculty = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    facultyName = table.Column<string>(nullable: true),
                    facultyAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.IdFaculty);
                });

            migrationBuilder.CreateTable(
                name: "Form_Of_Educations",
                columns: table => new
                {
                    IdFormEducation = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_Of_Educations", x => x.IdFormEducation);
                });

            migrationBuilder.CreateTable(
                name: "FormDeliveries",
                columns: table => new
                {
                    IdDelivery = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDelivery = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormDeliveries", x => x.IdDelivery);
                });

            migrationBuilder.CreateTable(
                name: "KnowledgeAreas",
                columns: table => new
                {
                    IdArea = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    areaName = table.Column<string>(nullable: true),
                    areaCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgeAreas", x => x.IdArea);
                });

            migrationBuilder.CreateTable(
                name: "ParaNumbers",
                columns: table => new
                {
                    IdPara = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paraTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParaNumbers", x => x.IdPara);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    IdPosition = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    positionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.IdPosition);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    IdRank = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rankName = table.Column<string>(nullable: true),
                    rankDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.IdRank);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID_role = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID_role);
                });

            migrationBuilder.CreateTable(
                name: "Semestrs",
                columns: table => new
                {
                    IdSemestr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    semestrNum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semestrs", x => x.IdSemestr);
                });

            migrationBuilder.CreateTable(
                name: "StudentInfoes",
                columns: table => new
                {
                    stundtInfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(nullable: true),
                    studentMiddleName = table.Column<string>(nullable: true),
                    studentLastName = table.Column<string>(nullable: true),
                    bday = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    homeAddress = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    studentSex = table.Column<string>(nullable: true),
                    StudentFirstParentName = table.Column<string>(nullable: true),
                    StudentFirstParentPhone = table.Column<string>(nullable: true),
                    StudentSecondParentName = table.Column<string>(nullable: true),
                    StudentSecondParentPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfoes", x => x.stundtInfoID);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    IdDay = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.IdDay);
                });

            migrationBuilder.CreateTable(
                name: "Weeks",
                columns: table => new
                {
                    IdWeek = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weekNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.IdWeek);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    IdClassroom = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    classroomNum = table.Column<string>(nullable: true),
                    id_classroomType = table.Column<int>(nullable: false),
                    amount = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.IdClassroom);
                    table.ForeignKey(
                        name: "FK_Classrooms_ClassroomTypes_id_classroomType",
                        column: x => x.id_classroomType,
                        principalTable: "ClassroomTypes",
                        principalColumn: "IdType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnderCycles",
                columns: table => new
                {
                    IdUnderCycle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameUnderCycle = table.Column<string>(nullable: true),
                    CodeUnderCycle = table.Column<string>(nullable: true),
                    ID_cycle = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderCycles", x => x.IdUnderCycle);
                    table.ForeignKey(
                        name: "FK_UnderCycles_Cycles_ID_cycle",
                        column: x => x.ID_cycle,
                        principalTable: "Cycles",
                        principalColumn: "IdCycle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cathedra",
                columns: table => new
                {
                    IdCathedra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cathedraName = table.Column<string>(nullable: true),
                    ID_faculty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cathedra", x => x.IdCathedra);
                    table.ForeignKey(
                        name: "FK_Cathedra_Faculties_ID_faculty",
                        column: x => x.ID_faculty,
                        principalTable: "Faculties",
                        principalColumn: "IdFaculty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorySpeciality",
                columns: table => new
                {
                    IdSpeciality = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specialityName = table.Column<string>(nullable: true),
                    specialityCode = table.Column<string>(nullable: true),
                    ID_KnowledgeArea = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorySpeciality", x => x.IdSpeciality);
                    table.ForeignKey(
                        name: "FK_DirectorySpeciality_KnowledgeAreas_ID_KnowledgeArea",
                        column: x => x.ID_KnowledgeArea,
                        principalTable: "KnowledgeAreas",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID_user = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ID_Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID_user);
                    table.ForeignKey(
                        name: "FK_Users_Roles_ID_Role",
                        column: x => x.ID_Role,
                        principalTable: "Roles",
                        principalColumn: "ID_role",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanEducationalProcesses",
                columns: table => new
                {
                    ID_PlanEducationalProcess = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDiscipline = table.Column<string>(nullable: true),
                    Semester = table.Column<string>(nullable: true),
                    Projects = table.Column<string>(nullable: true),
                    Course = table.Column<string>(nullable: true),
                    LectureHours = table.Column<string>(nullable: true),
                    PracticesHours = table.Column<string>(nullable: true),
                    LaboratoryHours = table.Column<string>(nullable: true),
                    IndependentWorkHours = table.Column<string>(nullable: true),
                    ID_Curriculum = table.Column<int>(nullable: false),
                    ID_UnderCycle = table.Column<int>(nullable: false),
                    ID_FormDelivery = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanEducationalProcesses", x => x.ID_PlanEducationalProcess);
                    table.ForeignKey(
                        name: "FK_PlanEducationalProcesses_FormDeliveries_ID_FormDelivery",
                        column: x => x.ID_FormDelivery,
                        principalTable: "FormDeliveries",
                        principalColumn: "IdDelivery",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanEducationalProcesses_UnderCycles_ID_UnderCycle",
                        column: x => x.ID_UnderCycle,
                        principalTable: "UnderCycles",
                        principalColumn: "IdUnderCycle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasicEducations",
                columns: table => new
                {
                    IdBasicEducation = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    place = table.Column<string>(nullable: true),
                    years = table.Column<string>(nullable: true),
                    id_speciality = table.Column<int>(nullable: false),
                    qualification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicEducations", x => x.IdBasicEducation);
                    table.ForeignKey(
                        name: "FK_BasicEducations_DirectorySpeciality_id_speciality",
                        column: x => x.id_speciality,
                        principalTable: "DirectorySpeciality",
                        principalColumn: "IdSpeciality",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    ID_Specialization = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameSpecialization = table.Column<string>(nullable: true),
                    ID_Speciality = table.Column<int>(nullable: false),
                    ID_Cathedra = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.ID_Specialization);
                    table.ForeignKey(
                        name: "FK_Specializations_Cathedra_ID_Cathedra",
                        column: x => x.ID_Cathedra,
                        principalTable: "Cathedra",
                        principalColumn: "IdCathedra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specializations_DirectorySpeciality_ID_Speciality",
                        column: x => x.ID_Speciality,
                        principalTable: "DirectorySpeciality",
                        principalColumn: "IdSpeciality",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherInfoes",
                columns: table => new
                {
                    teacherInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacherName = table.Column<string>(nullable: true),
                    teacherMiddleName = table.Column<string>(nullable: true),
                    teacherLastName = table.Column<string>(nullable: true),
                    bday = table.Column<string>(nullable: true),
                    homeAddress = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    id_basicEducation = table.Column<int>(nullable: false),
                    trainingYear = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherInfoes", x => x.teacherInfoId);
                    table.ForeignKey(
                        name: "FK_TeacherInfoes_BasicEducations_id_basicEducation",
                        column: x => x.id_basicEducation,
                        principalTable: "BasicEducations",
                        principalColumn: "IdBasicEducation",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curriculum",
                columns: table => new
                {
                    IDCurriculum = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_EducationalDegree = table.Column<int>(nullable: false),
                    Qualification = table.Column<string>(nullable: true),
                    ID_Specialization = table.Column<int>(nullable: false),
                    TrainingPeriod = table.Column<string>(nullable: true),
                    ID_Form_of_education = table.Column<int>(nullable: false),
                    BasedOn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculum", x => x.IDCurriculum);
                    table.ForeignKey(
                        name: "FK_Curriculum_EducationalDegrees_ID_EducationalDegree",
                        column: x => x.ID_EducationalDegree,
                        principalTable: "EducationalDegrees",
                        principalColumn: "IdDegree",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curriculum_Form_Of_Educations_ID_Form_of_education",
                        column: x => x.ID_Form_of_education,
                        principalTable: "Form_Of_Educations",
                        principalColumn: "IdFormEducation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curriculum_Specializations_ID_Specialization",
                        column: x => x.ID_Specialization,
                        principalTable: "Specializations",
                        principalColumn: "ID_Specialization",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    idTeacher = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_position = table.Column<int>(nullable: false),
                    salary = table.Column<string>(nullable: true),
                    id_rank = table.Column<int>(nullable: false),
                    id_academicTitle = table.Column<int>(nullable: false),
                    staff = table.Column<byte>(nullable: false),
                    employmentYear = table.Column<string>(nullable: true),
                    releaseYear = table.Column<string>(nullable: true),
                    teacherInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.idTeacher);
                    table.ForeignKey(
                        name: "FK_Teachers_AcademicTitles_id_academicTitle",
                        column: x => x.id_academicTitle,
                        principalTable: "AcademicTitles",
                        principalColumn: "IdAcademicTitle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Positions_id_position",
                        column: x => x.id_position,
                        principalTable: "Positions",
                        principalColumn: "IdPosition",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Ranks_id_rank",
                        column: x => x.id_rank,
                        principalTable: "Ranks",
                        principalColumn: "IdRank",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_TeacherInfoes_teacherInfoId",
                        column: x => x.teacherInfoId,
                        principalTable: "TeacherInfoes",
                        principalColumn: "teacherInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gruppas",
                columns: table => new
                {
                    IdGruppa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gruppaName = table.Column<string>(nullable: true),
                    id_curator = table.Column<int>(nullable: false),
                    id_formOfEducation = table.Column<int>(nullable: false),
                    id_cathedra = table.Column<int>(nullable: false),
                    year = table.Column<string>(nullable: true),
                    educLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gruppas", x => x.IdGruppa);
                    table.ForeignKey(
                        name: "FK_Gruppas_Cathedra_id_cathedra",
                        column: x => x.id_cathedra,
                        principalTable: "Cathedra",
                        principalColumn: "IdCathedra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gruppas_Teachers_id_curator",
                        column: x => x.id_curator,
                        principalTable: "Teachers",
                        principalColumn: "idTeacher",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gruppas_Form_Of_Educations_id_formOfEducation",
                        column: x => x.id_formOfEducation,
                        principalTable: "Form_Of_Educations",
                        principalColumn: "IdFormEducation",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TotalLoads",
                columns: table => new
                {
                    IdTotalLoad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_teacher = table.Column<int>(nullable: false),
                    semester = table.Column<int>(nullable: false),
                    amountOfDiscipline = table.Column<string>(nullable: true),
                    totalHours = table.Column<string>(nullable: true),
                    lectures = table.Column<string>(nullable: true),
                    practices = table.Column<string>(nullable: true),
                    labs = table.Column<string>(nullable: true),
                    tutoring = table.Column<string>(nullable: true),
                    exams = table.Column<string>(nullable: true),
                    credits = table.Column<string>(nullable: true),
                    controlWorks = table.Column<string>(nullable: true),
                    courseProjects = table.Column<string>(nullable: true),
                    budgetGroup = table.Column<string>(nullable: true),
                    bugetGroupPractice = table.Column<string>(nullable: true),
                    budgetGroupsLabs = table.Column<string>(nullable: true),
                    contractGroup = table.Column<string>(nullable: true),
                    contactGroupPractice = table.Column<string>(nullable: true),
                    contractGroupLabs = table.Column<string>(nullable: true),
                    studentsAmount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalLoads", x => x.IdTotalLoad);
                    table.ForeignKey(
                        name: "FK_TotalLoads_Teachers_id_teacher",
                        column: x => x.id_teacher,
                        principalTable: "Teachers",
                        principalColumn: "idTeacher",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TotalLoads_Semestrs_semester",
                        column: x => x.semester,
                        principalTable: "Semestrs",
                        principalColumn: "IdSemestr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shedules",
                columns: table => new
                {
                    IdShedule = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_teacher = table.Column<int>(nullable: true),
                    id_gruppa = table.Column<int>(nullable: false),
                    id_discipline = table.Column<int>(nullable: false),
                    id_week = table.Column<int>(nullable: false),
                    id_day = table.Column<int>(nullable: false),
                    id_para = table.Column<int>(nullable: false),
                    id_calssroom = table.Column<int>(nullable: false),
                    id_semestr = table.Column<int>(nullable: false),
                    id_year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shedules", x => x.IdShedule);
                    table.ForeignKey(
                        name: "FK_Shedules_Classrooms_id_calssroom",
                        column: x => x.id_calssroom,
                        principalTable: "Classrooms",
                        principalColumn: "IdClassroom",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shedules_WeekDays_id_day",
                        column: x => x.id_day,
                        principalTable: "WeekDays",
                        principalColumn: "IdDay",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shedules_PlanEducationalProcesses_id_discipline",
                        column: x => x.id_discipline,
                        principalTable: "PlanEducationalProcesses",
                        principalColumn: "ID_PlanEducationalProcess",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shedules_Gruppas_id_gruppa",
                        column: x => x.id_gruppa,
                        principalTable: "Gruppas",
                        principalColumn: "IdGruppa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shedules_ParaNumbers_id_para",
                        column: x => x.id_para,
                        principalTable: "ParaNumbers",
                        principalColumn: "IdPara",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shedules_Semestrs_id_semestr",
                        column: x => x.id_semestr,
                        principalTable: "Semestrs",
                        principalColumn: "IdSemestr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shedules_Teachers_id_teacher",
                        column: x => x.id_teacher,
                        principalTable: "Teachers",
                        principalColumn: "idTeacher",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shedules_Weeks_id_week",
                        column: x => x.id_week,
                        principalTable: "Weeks",
                        principalColumn: "IdWeek",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shedules_AcademicYears_id_year",
                        column: x => x.id_year,
                        principalTable: "AcademicYears",
                        principalColumn: "IdYear",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    stundentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_gruppa = table.Column<int>(nullable: true),
                    id_speciality = table.Column<int>(nullable: false),
                    startYear = table.Column<string>(nullable: true),
                    year = table.Column<string>(nullable: true),
                    id_cathedra = table.Column<int>(nullable: false),
                    id_faculty = table.Column<int>(nullable: true),
                    institute = table.Column<int>(nullable: false),
                    educationProgram = table.Column<int>(nullable: false),
                    id_studentInfo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.stundentID);
                    table.ForeignKey(
                        name: "FK_Students_Cathedra_id_cathedra",
                        column: x => x.id_cathedra,
                        principalTable: "Cathedra",
                        principalColumn: "IdCathedra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Faculties_id_faculty",
                        column: x => x.id_faculty,
                        principalTable: "Faculties",
                        principalColumn: "IdFaculty",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Gruppas_id_gruppa",
                        column: x => x.id_gruppa,
                        principalTable: "Gruppas",
                        principalColumn: "IdGruppa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_DirectorySpeciality_id_speciality",
                        column: x => x.id_speciality,
                        principalTable: "DirectorySpeciality",
                        principalColumn: "IdSpeciality",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_StudentInfoes_id_studentInfo",
                        column: x => x.id_studentInfo,
                        principalTable: "StudentInfoes",
                        principalColumn: "stundtInfoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasicEducations_id_speciality",
                table: "BasicEducations",
                column: "id_speciality");

            migrationBuilder.CreateIndex(
                name: "IX_Cathedra_ID_faculty",
                table: "Cathedra",
                column: "ID_faculty");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_id_classroomType",
                table: "Classrooms",
                column: "id_classroomType");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculum_ID_EducationalDegree",
                table: "Curriculum",
                column: "ID_EducationalDegree");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculum_ID_Form_of_education",
                table: "Curriculum",
                column: "ID_Form_of_education");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculum_ID_Specialization",
                table: "Curriculum",
                column: "ID_Specialization");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorySpeciality_ID_KnowledgeArea",
                table: "DirectorySpeciality",
                column: "ID_KnowledgeArea");

            migrationBuilder.CreateIndex(
                name: "IX_Gruppas_id_cathedra",
                table: "Gruppas",
                column: "id_cathedra");

            migrationBuilder.CreateIndex(
                name: "IX_Gruppas_id_curator",
                table: "Gruppas",
                column: "id_curator");

            migrationBuilder.CreateIndex(
                name: "IX_Gruppas_id_formOfEducation",
                table: "Gruppas",
                column: "id_formOfEducation");

            migrationBuilder.CreateIndex(
                name: "IX_PlanEducationalProcesses_ID_FormDelivery",
                table: "PlanEducationalProcesses",
                column: "ID_FormDelivery");

            migrationBuilder.CreateIndex(
                name: "IX_PlanEducationalProcesses_ID_UnderCycle",
                table: "PlanEducationalProcesses",
                column: "ID_UnderCycle");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_calssroom",
                table: "Shedules",
                column: "id_calssroom");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_day",
                table: "Shedules",
                column: "id_day");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_discipline",
                table: "Shedules",
                column: "id_discipline");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_gruppa",
                table: "Shedules",
                column: "id_gruppa");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_para",
                table: "Shedules",
                column: "id_para");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_semestr",
                table: "Shedules",
                column: "id_semestr");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_teacher",
                table: "Shedules",
                column: "id_teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_week",
                table: "Shedules",
                column: "id_week");

            migrationBuilder.CreateIndex(
                name: "IX_Shedules_id_year",
                table: "Shedules",
                column: "id_year");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_ID_Cathedra",
                table: "Specializations",
                column: "ID_Cathedra");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_ID_Speciality",
                table: "Specializations",
                column: "ID_Speciality");

            migrationBuilder.CreateIndex(
                name: "IX_Students_id_cathedra",
                table: "Students",
                column: "id_cathedra");

            migrationBuilder.CreateIndex(
                name: "IX_Students_id_faculty",
                table: "Students",
                column: "id_faculty");

            migrationBuilder.CreateIndex(
                name: "IX_Students_id_gruppa",
                table: "Students",
                column: "id_gruppa");

            migrationBuilder.CreateIndex(
                name: "IX_Students_id_speciality",
                table: "Students",
                column: "id_speciality");

            migrationBuilder.CreateIndex(
                name: "IX_Students_id_studentInfo",
                table: "Students",
                column: "id_studentInfo");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfoes_id_basicEducation",
                table: "TeacherInfoes",
                column: "id_basicEducation");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_id_academicTitle",
                table: "Teachers",
                column: "id_academicTitle");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_id_position",
                table: "Teachers",
                column: "id_position");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_id_rank",
                table: "Teachers",
                column: "id_rank");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_teacherInfoId",
                table: "Teachers",
                column: "teacherInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalLoads_id_teacher",
                table: "TotalLoads",
                column: "id_teacher");

            migrationBuilder.CreateIndex(
                name: "IX_TotalLoads_semester",
                table: "TotalLoads",
                column: "semester");

            migrationBuilder.CreateIndex(
                name: "IX_UnderCycles_ID_cycle",
                table: "UnderCycles",
                column: "ID_cycle");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ID_Role",
                table: "Users",
                column: "ID_Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curriculum");

            migrationBuilder.DropTable(
                name: "Shedules");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TotalLoads");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "EducationalDegrees");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "PlanEducationalProcesses");

            migrationBuilder.DropTable(
                name: "ParaNumbers");

            migrationBuilder.DropTable(
                name: "Weeks");

            migrationBuilder.DropTable(
                name: "AcademicYears");

            migrationBuilder.DropTable(
                name: "Gruppas");

            migrationBuilder.DropTable(
                name: "StudentInfoes");

            migrationBuilder.DropTable(
                name: "Semestrs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ClassroomTypes");

            migrationBuilder.DropTable(
                name: "FormDeliveries");

            migrationBuilder.DropTable(
                name: "UnderCycles");

            migrationBuilder.DropTable(
                name: "Cathedra");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Form_Of_Educations");

            migrationBuilder.DropTable(
                name: "Cycles");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "AcademicTitles");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "TeacherInfoes");

            migrationBuilder.DropTable(
                name: "BasicEducations");

            migrationBuilder.DropTable(
                name: "DirectorySpeciality");

            migrationBuilder.DropTable(
                name: "KnowledgeAreas");
        }
    }
}
