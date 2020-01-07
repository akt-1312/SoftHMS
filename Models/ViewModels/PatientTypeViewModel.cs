﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMS.Models.ViewModels
{
    public class PatientTypeViewModel
    {
        public List<PatientType> PatientTypes { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
