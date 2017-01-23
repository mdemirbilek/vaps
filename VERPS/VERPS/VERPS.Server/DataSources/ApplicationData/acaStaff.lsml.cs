using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class acaStaff
    {
        partial void FullName_Compute(ref string result)
        {
            result = this.Title + " " + this.Name;
        }
    }
}