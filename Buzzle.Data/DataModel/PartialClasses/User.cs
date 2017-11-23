﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buzzle.Data.DataModel
{
    public partial class User
    {
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}
