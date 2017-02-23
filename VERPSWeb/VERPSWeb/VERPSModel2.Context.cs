﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VERPSWeb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VERPSEntities2 : DbContext
    {
        public VERPSEntities2()
            : base("name=VERPSEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<acaActivityType> acaActivityTypes { get; set; }
        public virtual DbSet<acaDegree> acaDegrees { get; set; }
        public virtual DbSet<acaEvalType> acaEvalTypes { get; set; }
        public virtual DbSet<acaObligationType> acaObligationTypes { get; set; }
        public virtual DbSet<acaRoomType> acaRoomTypes { get; set; }
        public virtual DbSet<acaSemester> acaSemesters { get; set; }
        public virtual DbSet<acaStaff> acaStaffs { get; set; }
        public virtual DbSet<acaStudentSet> acaStudentSets { get; set; }
        public virtual DbSet<acaStudyMode> acaStudyModes { get; set; }
        public virtual DbSet<acaStudyProfile> acaStudyProfiles { get; set; }
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<erpAcademicDepartment> erpAcademicDepartments { get; set; }
        public virtual DbSet<erpFaculty> erpFaculties { get; set; }
        public virtual DbSet<erpHRAccountingPeriod> erpHRAccountingPeriods { get; set; }
        public virtual DbSet<erpLanguage> erpLanguages { get; set; }
        public virtual DbSet<erpPosition> erpPositions { get; set; }
        public virtual DbSet<erpProgram> erpPrograms { get; set; }
        public virtual DbSet<erpUniversity> erpUniversities { get; set; }
        public virtual DbSet<hrAddress> hrAddresses { get; set; }
        public virtual DbSet<hrDepartment> hrDepartments { get; set; }
        public virtual DbSet<hrEmergencyContact> hrEmergencyContacts { get; set; }
        public virtual DbSet<hrEmpAcademicProfileByAcademician> hrEmpAcademicProfileByAcademicians { get; set; }
        public virtual DbSet<hrEmpAcademicProfileByHR> hrEmpAcademicProfileByHRs { get; set; }
        public virtual DbSet<hrEmpCours> hrEmpCourses { get; set; }
        public virtual DbSet<hrEmpDisability> hrEmpDisabilities { get; set; }
        public virtual DbSet<hrEmpEducation> hrEmpEducations { get; set; }
        public virtual DbSet<hrEmpFamilyHealthInsurance> hrEmpFamilyHealthInsurances { get; set; }
        public virtual DbSet<hrEmpFamilyMember> hrEmpFamilyMembers { get; set; }
        public virtual DbSet<hrEmpLanguage> hrEmpLanguages { get; set; }
        public virtual DbSet<hrEmpMilService> hrEmpMilServices { get; set; }
        public virtual DbSet<hrEmpPastEmployement> hrEmpPastEmployements { get; set; }
        public virtual DbSet<hrEmpProfile> hrEmpProfiles { get; set; }
        public virtual DbSet<hrEmpSkill> hrEmpSkills { get; set; }
        public virtual DbSet<hrEvalStatu> hrEvalStatus { get; set; }
        public virtual DbSet<hrHoliday> hrHolidays { get; set; }
        public virtual DbSet<hrPeople> hrPeoples { get; set; }
        public virtual DbSet<hrWorkingHour> hrWorkingHours { get; set; }
        public virtual DbSet<plActivity> plActivities { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<sylAcademicalAim> sylAcademicalAims { get; set; }
        public virtual DbSet<sylAssesmentMethod> sylAssesmentMethods { get; set; }
        public virtual DbSet<sylAssesment> sylAssesments { get; set; }
        public virtual DbSet<sylCourseMaterial> sylCourseMaterials { get; set; }
        public virtual DbSet<sylCours> sylCourses { get; set; }
        public virtual DbSet<sylCourseTeacher> sylCourseTeachers { get; set; }
        public virtual DbSet<sylLearningOutcome> sylLearningOutcomes { get; set; }
        public virtual DbSet<sylOutcomeAim> sylOutcomeAims { get; set; }
        public virtual DbSet<sylOutcomeAssesment> sylOutcomeAssesments { get; set; }
        public virtual DbSet<sylPrerequisite> sylPrerequisites { get; set; }
        public virtual DbSet<sylProgramCours> sylProgramCourses { get; set; }
        public virtual DbSet<sylSyllabi> sylSyllabis { get; set; }
        public virtual DbSet<sylSyllabusNotesSet> sylSyllabusNotesSets { get; set; }
        public virtual DbSet<sylSyllabusTeachingMethod> sylSyllabusTeachingMethods { get; set; }
        public virtual DbSet<sylSyllabusTopic> sylSyllabusTopics { get; set; }
        public virtual DbSet<sylTeachingMethod> sylTeachingMethods { get; set; }
        public virtual DbSet<sylWorkloadStructure> sylWorkloadStructures { get; set; }
    }
}