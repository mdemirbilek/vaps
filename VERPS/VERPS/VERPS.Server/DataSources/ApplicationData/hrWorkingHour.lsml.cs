using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class hrWorkingHour
    {
        partial void WorkingTimeDiff_Compute(ref string result)
        {
            // Set result to the desired field value
            result = this.HourDiff.ToString() + ":" + this.MinuteDiff.ToString();
        }

        partial void AcceptedOvertime_Compute(ref string result)
        {
            // Set result to the desired field value
            result = this.AcceptedOTeHrs.ToString() + ":" + this.AcceptedOTMin.ToString();
        }
    }
}