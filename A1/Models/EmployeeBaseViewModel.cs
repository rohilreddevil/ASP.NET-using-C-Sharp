﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class EmployeeBaseViewModel: EmployeeAddViewModel
    {
        [Key]
        public int EmployeeId { get; set; }
    }
}