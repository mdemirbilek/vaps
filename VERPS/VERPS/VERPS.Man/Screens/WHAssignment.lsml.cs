﻿using Microsoft.LightSwitch.Presentation.Extensions;
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
    public partial class WHAssignment
    {
        partial void WHAssignment_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            this.hrPersonLSUser = this.Application.User.Name;
        }
    }
}