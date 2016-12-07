using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;

namespace LightSwitchApplication
{
    public partial class Application
    {
        partial void aspnet_Users_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);

        }

        partial void Faculties_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void Universities_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);

        }

        partial void Departments_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void People_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void NewPerson_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void WorkingHours_CanRun(ref bool result, string LSUser)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void EmpWorkingHours_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void WHAssignment_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void WHSupervision_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.EmployeeSupervision);
        }

        partial void EmployeeWH_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.HRManagement);
        }

        partial void AcademicDepartments_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void AcademicalAims_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void CourseMaterials_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void CourseTeachers_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void Courses_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void LearningOutcomes_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void Prerequisites_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void ProgramCourses_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void Syllabi_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void SyllabusNotes_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void SyllabusTopics_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void WorkloadStructures_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }
    }
}