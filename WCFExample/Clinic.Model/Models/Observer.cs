﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
  public  interface Observer
    {
       void UpdateConsult(object Patient);     
    }
}
