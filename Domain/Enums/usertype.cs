﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    [Flags]
    public enum Usertype : short
    {

        SuperAdmin = 1,
        Admin = 2,
        User = 3,
    }
}
