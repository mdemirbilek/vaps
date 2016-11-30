using Microsoft.LightSwitch.Security.Server;
using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void hrPeople_Inserting(hrPerson entity)
        {
            entity.FullName = entity.Name + " " + entity.Surname;
        }

        partial void hrPeople_Updating(hrPerson entity)
        {
            entity.FullName = entity.Name + " " + entity.Surname;
        }

        partial void sylCourses_Inserting(sylCourse entity)
        {
            entity.Title = entity.CourseCode + " - " + entity.Name;
        }

        partial void sylCourses_Updating(sylCourse entity)
        {

        }

        partial void sylSyllabi_Inserting(sylSyllabus entity)
        {
            entity.WFState = entity.CourseCoordinator;
            entity.WFUser = entity.CourseCoordinator.LSUser;
            entity.Title = entity.sylCourse.Title;
        }

        partial void sylSyllabi_Updating(sylSyllabus entity)
        {
            entity.Title = entity.sylCourse.Title;
        }

        partial void hrPeople_Inserted(hrPerson entity)
        {
            InsertDates(entity);
        }

        partial void hrPeople_Updated(hrPerson entity)
        {
            InsertDates(entity);
        }

        public static void InsertDates(hrPerson person)
        {
            DateTime firstDate = DateTime.Parse("2016-10-01");
            DateTime lastDate = DateTime.Parse("2017-12-31");
            DateTime actualDate = firstDate;
            bool isExist = false;

            using (var serverContext = LightSwitchApplication.Application.Current.CreateDataWorkspace())
            {
                var hrs = serverContext.ApplicationData.byPerson(person.Id);
                hrWorkingHour hr;

                if (hrs != null)
                {
                    while (actualDate <= lastDate)
                    {
                        isExist = false;
                        foreach (var item in hrs)
                        {
                            hr = (hrWorkingHour)item;

                            if (hr.WorkingDate.ToShortDateString() == actualDate.ToShortDateString())
                            {
                                isExist = true;
                            }
                        }

                        if (!isExist)
                        {
                            InsertWorkingHours(person, actualDate);
                        }

                        actualDate = actualDate.AddDays(1);
                    }
                }
                else
                {
                    while (actualDate <= lastDate)
                    {
                        InsertWorkingHours(person, actualDate);
                        actualDate = actualDate.AddDays(1);
                    }
                }
            }
        }

        public static void InsertWorkingHours(hrPerson person, DateTime dt)
        {
            hrWorkingHour wh = new hrWorkingHour();

            wh.hrPerson = person;
            wh.UserName = person.LSUser;
            wh.AccessCardID = person.AccessCardID;
            wh.AccessSysID = person.AccessSysID;
            wh.WorkingDate = dt;
            wh.RecYear = dt.Year;
            wh.RecMonth = dt.Month;
            wh.RecDay = dt.Day;
            wh.DayOfWeek = dt.DayOfWeek.ToString();
            wh.IsWorkingDay = IsStdWorkingDay(dt);
            wh.TotalHours = 0;
            wh.TotalMinutes = 0;
            wh.Exception = "NA";
            wh.Note = "";
            if (IsStdWorkingDay(dt))
            {
                wh.StdWorkingHour = 8;
                wh.AssignedWorkingHour = 8;
            }
            else
            {
                wh.StdWorkingHour = 0;
                wh.AssignedWorkingHour = 0;
            }
            wh.HourDiff = 0;
            wh.MinuteDiff = 0;
            wh.IsOTAccepted = false;
            wh.OTAcceptedBy = "";
            wh.AcceptedOTeHrs = 0;
            wh.AcceptedOTMin = 0;
        }

        public static bool IsStdWorkingDay(DateTime dt)
        {
            bool workingDay = true;
            if (dt.DayOfWeek.ToString() == "Saturday" || dt.DayOfWeek.ToString() == "Sunday")
            {
                workingDay = false;
            }
            return workingDay;
        }

        partial void erpFaculties_Updated(erpFaculty entity)
        {

        }

        partial void hrEmpAcademicProfileByAcademicians_Inserted(hrEmpAcademicProfileByAcademician entity)
        {
            entity.FullName = entity.Academician.FullName;
        }

        partial void hrEmpAcademicProfileByHRs_Inserted(hrEmpAcademicProfileByHR entity)
        {
            entity.FullName = entity.Academician.FullName + " - " + entity.University.Name;
        }

        partial void hrEmpProfiles_Inserted(hrEmpProfile entity)
        {
            entity.FullName = entity.Employee.FullName;
        }

        //public static hrEvalStatu InsertInitialEvalStatus(int entityId)
        //{
        //    hrEvalStatu status = new hrEvalStatu();
        //    status.Status = "Waiting";

        //    return status;
        //}

        partial void hrEmpCourses_Inserting(hrEmpCourse entity)
        {
            //entity.Status = 
        }

        //partial void getTotalWH_PreprocessQuery(string usrName, int? RecYear, int? RecMonth, ref IQueryable<hrWorkingHour> query)
        //{

        //}
    }
}