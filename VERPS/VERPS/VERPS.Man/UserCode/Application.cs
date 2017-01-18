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



        partial void Departments_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.SecurityAdministration);
        }

        partial void People_CanRun(ref bool result)
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

        partial void AcaActivityTypes_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.Planning);
        }

        partial void AcaDegrees_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.Planning);
        }

        partial void AcaEvalTypes_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.Planning);
        }

        partial void AcaObligationTypes_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.Planning);
        }

        partial void AcaRoomTypes_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.Planning);
        }

        partial void AcaSemesters_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.Planning);
        }

        partial void AcaStudentSets_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.Planning);
        }

        partial void AcaStudyModes_CanRun(ref bool result)
        {
            result = Application.Current.User.HasPermission(Permissions.Planning);
        }
    }
}