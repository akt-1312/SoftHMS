﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMS.Models.ViewModels
{
    public class UnitViewModel
    {
        public List<Unit> Units { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
